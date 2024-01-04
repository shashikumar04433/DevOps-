## Kubernetes Project using eks with 2048-game :

**Pre-Requirements:**
```
* Install the Aws-Cli, Eksctl, Kubectl in the Server that steps can be check in the kubernetes_with_aws.md .
```

**Save the file ad deploy.yaml and apply it**
```
apiVersion: apps/v1
kind: Deployment
metadata:
  name: eks-sample-linux-deployment
  labels:
    app: eks-sample-linux-app
spec:
  replicas: 3
  selector:
    matchLabels:
      app: eks-sample-linux-app
  template:
    metadata:
      labels:
        app: eks-sample-linux-app
    spec:
      affinity:
        nodeAffinity:
          requiredDuringSchedulingIgnoredDuringExecution:
            nodeSelectorTerms:
            - matchExpressions:
              - key: kubernetes.io/arch
                operator: In
                values:
                - amd64
                - arm64
      containers:
      - name: nginx
        image: public.ecr.aws/nginx/nginx:1.23
        ports:
        - name: http
          containerPort: 80
        imagePullPolicy: IfNotPresent
      nodeSelector:
    kubernetes.io/os: linux
```
**deploy the yaml file using below command**
```
kubectl apply -f deploy.yaml
```
**Copy the below file as service.yml**
```
apiVersion: v1
kind: Service
metadata:
  name: eks-sample-linux-service
  labels:
    app: eks-sample-linux-app
spec:
  selector:
    app: eks-sample-linux-app
  ports:
    - protocol: TCP
      port: 80
```
**Deploy the service**
```
kubectl apply -f deploy.yaml
```
**Install using Fargate**
```
creating cluster and creating fargate:

* eksctl create cluster --demo2 --region ap-south-1 --fargate



  




  




