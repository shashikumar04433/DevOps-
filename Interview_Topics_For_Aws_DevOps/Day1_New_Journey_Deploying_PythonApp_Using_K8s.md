### Deploying a Python using kubeadm involves multiple steps, including setting up a Kubernetes cluster, deploying the API, and exposing it. Here's a step-by-step guide:
**0 All stages**
```
Summary:
* Set up a Kubernetes cluster using kubeadm
* Built a Python API and created a Docker image
* Deployed the API using Kubernetes manifests
* Exposed the service using NodePort (and optionally Ingress)
```

**1. Setup Kubernetes Cluster using kubeadm**
```
If you already have a cluster set up, you can skip this part.

1. Install Dependencies on All Nodes
Run the following on all nodes (master and workers):

* sudo apt update && sudo apt install -y apt-transport-https curl
* curl -fsSL https://pkgs.k8s.io/core:/stable:/v1.29/deb/Release.key | sudo tee /etc/apt/trusted.gpg.d/kubernetes-apt-keyring.asc
* echo "deb https://pkgs.k8s.io/core:/stable:/v1.29/deb/ /" | sudo tee /etc/apt/sources.list.d/kubernetes.list
* sudo apt update
* sudo apt install -y kubelet kubeadm kubectl
* sudo apt-mark hold kubelet kubeadm kubectl
```
**2. Disable Swap (Kubernetes Requirement)**
```
sudo swapoff -a
sudo sed -i '/ swap / s/^/#/' /etc/fstab
```
**3. Initialize Kubernetes on Master Node**
```
* sudo kubeadm init --pod-network-cidr=192.168.0.0/16
After initialization, set up kubectl for the current user:
* mkdir -p $HOME/.kube
* sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
* sudo chown $(id -u):$(id -g) $HOME/.kube/config
```
**4. Install a Network Plugin (Calico)**
```
* kubectl apply -f https://docs.projectcalico.org/manifests/calico.yaml
```
**5. Add Worker Nodes (Run on Worker Nodes)**
```
To get the join command, run on the master:

* kubeadm token create --print-join-command
Run the output command on worker nodes to join them to the cluster.

* kubectl get nodes
```

**6. Build and Push Docker Image for Python API**
```
* install python and flask
* Create a Simple Python API (app.py)
* Create a Flask API (or FastAPI) for demonstration:
```
```
from flask import Flask
app = Flask(__name__)

@app.route('/')
def index():
    return "Hello from Kubernetes!"

@app.route('/home')
def home():
    return "Welcome to the Home Page!"

@app.route('/login')
def login():
    return "Login Page - Please enter your credentials."

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
```

**Create Dockerfile**

```
FROM python:3.9
WORKDIR /app
COPY requirements.txt .
RUN pip install -r requirements.txt
COPY . .
CMD ["python", "app.py"]
```
**requirements.txt**
```
flask
```

**Build and Push Image**
```
docker build -t shashikumar023/python-api:v1 .
docker login
docker push shashikumar023/python-api:v1
```
**3. Deploy Python API on Kubernetes**
```
Create Deployment YAML (deployment.yaml)

apiVersion: apps/v1
kind: Deployment
metadata:
  name: python-api
spec:
  replicas: 2
  selector:
    matchLabels:
      app: python-api
  template:
    metadata:
      labels:
        app: python-api
    spec:
      containers:
      - name: python-api
        image: shashikumar023/python-api:v1
        ports:
        - containerPort: 5000
```
**Create Service YAML (service.yaml)**
```
apiVersion: v1
kind: Service
metadata:
  name: python-api-service
spec:
  type: NodePort
  selector:
    app: python-api
  ports:
    - protocol: TCP
      port: 80
      targetPort: 5000
      nodePort: 30007
```
**Apply Manifests**
```
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml
```
**Verify Deployment**
```
kubectl get pods
kubectl get svc
```
**4. Access the Python API**
```
kubectl get nodes -o wide
kubectl get svc -o wide
browse on google with ip:nodeport
```
**5. Optional: Expose API Using Ingress**
```
To expose via a domain name, install Ingress:

kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/cloud/deploy.yaml
Then create an Ingress rule (ingress.yaml):
```
```
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: python-api-ingress
  annotations:
    nginx.ingress.kubernetes.io/rewrite-target: /
spec:
  rules:
  - host: python-api.local
    http:
      paths:
      - path: /
        pathType: Prefix
        backend:
          service:
            name: python-api-service
            port:
              number: 80
Apply it:
```
```
kubectl apply -f ingress.yaml
Now, map python-api.local to the cluster's IP in /etc/hosts.
```

**To automate this when ever new image is pushed cron job will apply those changes for that pre-requisites are service account and role binding**
**Create a service account and bind it to a ClusterRole that has permission to manage deployments.**
```
apiVersion: v1
kind: ServiceAccount
metadata:
  name: deployment-updater
  namespace: default
```
```
kubectl apply -f serviceaccount.yml
```
**Grant Cluster-Wide Permissions**
```
create a ClusterRoleBinding to give deployment-updater permission to restart deployments.
Create a file rolebinding.yml:
```
```
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRoleBinding
metadata:
  name: deployment-updater-binding
subjects:
- kind: ServiceAccount
  name: deployment-updater
  namespace: default
roleRef:
  kind: ClusterRole
  name: cluster-admin  # Gives full cluster access (Use carefully)
  apiGroup: rbac.authorization.k8s.io
```
```
kubectl apply -f rolebinding.yml
```
**reapply cron again**
```
apiVersion: batch/v1
kind: CronJob
metadata:
  name: auto-update-python-api
spec:
  schedule: "*/5 * * * *"  # Runs every 5 minutes
  jobTemplate:
    spec:
      template:
        spec:
          serviceAccountName: deployment-updater  # Use the new ServiceAccount
          containers:
          - name: update-container
            image: bitnami/kubectl
            command:
            - /bin/sh
            - -c
            - kubectl rollout restart deployment python-api
          restartPolicy: Never
```
```
kubectl apply -f cronjob.yml
```

**Python App with the Database and deploying with K8s**




