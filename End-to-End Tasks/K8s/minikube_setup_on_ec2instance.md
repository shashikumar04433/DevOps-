## Minikube Setup in Ubuntu:


* sudo apt-get update -y
* sudo apt-get install -y docker.io
* sudo systemctl enable --now docker

* docker --version

* curl -LO https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
* sudo install minikube-linux-amd64 /usr/local/bin/minikube
* rm minikube-linux-amd64

* minikube version

* Make sure that instance has atleast 2 Cpu core and run this as normal user as ubuntu if required with root use force key word.
*  minikube start --driver=docker --force
* minikube start --driver=docker
* minikube status
* kubectl get nodes

**deploying the Nginx deployment:**
```
kubectl create deployment nginx --image=nginx
kubectl get pods (pod nginx will be running)
minikube logs
```
**expose the deployment:**
``` 
kubectl expose deployment nginx --type=Loadbalancer --port=80
kubectl get svc
```
```
This are optional
* kubectl expose deployment nginx --type=NodePort --port=80
suppose to patch the above as loadbalancer 
* kubectl patch svc nginx -p '{"spec":{"type":"LoadBalancer"}}'

* kubectl get svc
minikube ip (paste that ip with ip:30007)
```
**This will create a network tunnel to allow the LoadBalancer to work**
```
minikube tunnel
```
**To check the url**
minikube service nginx --url
kubectl port-forward deployment/nginx 8080:80 --address 0.0.0.0

http://ip:8080
```













# Update system and install dependencies
sudo apt update -y && sudo apt upgrade -y
sudo apt install -y curl wget apt-transport-https ca-certificates conntrack

# Install Docker
sudo apt install -y docker.io
sudo usermod -aG docker $USER && newgrp docker

# Install kubectl
curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl"
sudo install -o root -g root -m 0755 kubectl /usr/local/bin/kubectl

# Install Minikube
curl -LO https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
sudo install minikube-linux-amd64 /usr/local/bin/minikube






