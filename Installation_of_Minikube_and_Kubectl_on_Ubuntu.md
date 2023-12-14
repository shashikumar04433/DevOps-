## Steps for Installation of Minikube and Kubectl on Ubuntu:

**Installing the minikube**

  * https://minikube.sigs.k8s.io/docs/start/
  * curl -LO https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
  * sudo install minikube-linux-amd64 /usr/local/bin/minikube

**Install kubectl on Linux**
```
 Download the kubectl checksum file:
 
    * curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl.sha256"
    
 Validate the kubectl binary against the checksum file:
    * echo "$(cat kubectl.sha256)  kubectl" | sha256sum --check

 Install kubectl:
    * sudo install -o root -g root -m 0755 kubectl /usr/local/bin/kubectl
  ``` 



