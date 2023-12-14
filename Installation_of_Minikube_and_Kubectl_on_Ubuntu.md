## Steps for Installation of Minikube and Kubectl on Ubuntu:
```
**Installing the minikube**

  * https://minikube.sigs.k8s.io/docs/start/
  * curl -LO https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
  * sudo install minikube-linux-amd64 /usr/local/bin/minikube
```
**Install kubectl on Linux**
```
 Download the kubectl checksum file:
    * curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl"
    
 Validate the kubectl binary against the checksum file:
    * echo "$(cat kubectl.sha256)  kubectl" | sha256sum --check

 Install kubectl:
    * sudo install -o root -g root -m 0755 kubectl /usr/local/bin/kubectl
    * chmod +x kubectl mkdir -p ~/.local/bin mv ./kubectl ~/.local/bin/kubectl ( not recommanded // and then append (or prepend) ~/.local/bin to $PATH)

    * kubectl version --client
    * kubectl version --client --output=yaml
    * sudo apt-get update
    * sudo apt-get install -y apt-transport-https ca-certificates curl
    * curl -fsSL https://pkgs.k8s.io/core:/stable:/v1.28/deb/Release.key | sudo gpg --dearmor -o /etc/apt/keyrings/kubernetes-apt-keyring.gpg
    * echo 'deb [signed-by=/etc/apt/keyrings/kubernetes-apt-keyring.gpg] https://pkgs.k8s.io/core:/stable:/v1.28/deb/ /' | sudo tee /etc/apt/sources.list.d/kubernetes.list
    * sudo apt-get update
    * sudo apt-get install -y kubectl
    * kubectl version
  ``` 



