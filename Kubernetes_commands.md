## Kubernetes Commands :
    https://kubernetes.io/docs/reference/kubectl/
    
  **List the API resources that are available.**
   * kubectl api-resources
     
  **List the API versions that are available.**
   * kubectl api-versions

  **Apply a configuration change to a resource from a file or create a pod.**
   * kubectl apply -f pod.yml
     
  **Attach to a running container either to view the output stream or interact with the container (stdin).**
   * kubectl attach POD -c CONTAINER [-i] [-t] [flags]
  

**Installation of Minikube and Kubectl in ubuntu**

* curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl"
* chmod +x kubectl
  mkdir -p ~/.local/bin
  mv ./kubectl ~/.local/bin/kubectl
( not recommanded // and then append (or prepend) ~/.local/bin to $PATH)
* kubectl version --client
* kubectl version --client --output=yaml
* sudo apt-get update
* sudo apt-get install -y apt-transport-https ca-certificates curl
* curl -fsSL https://pkgs.k8s.io/core:/stable:/v1.28/deb/Release.key | sudo gpg --dearmor -o /etc/apt/keyrings/kubernetes-apt-keyring.gpg
* echo 'deb [signed-by=/etc/apt/keyrings/kubernetes-apt-keyring.gpg] https://pkgs.k8s.io/core:/stable:/v1.28/deb/ /' | sudo tee /etc/apt/sources.list.d/kubernetes.list
* sudo apt-get update
* sudo apt-get install -y kubectl
* kubectl version
* minikube version
  
* Vi pod.yaml
* apiVersion: v1
kind: Pod
metadata:
  name: nginx
spec:
  containers:
  - name: nginx
    image: nginx:1.14.2
    ports:
    - containerPort: 80

* kubectl create -f pod.yaml
* kubectl get nodes
* kubectl get pods -o wide
* curl<ip>
* minikube ssh
* kubectl delete pod<pod name>

### How Pods work?

* kubectl apply -f pod.yaml
* kubectl describe pod nginx
* kubectl logs nginx
  
