## Steps for Installation of Minikube and Kubectl on Ubuntu:

**Install kubectl on Linux**
```
   * sudo apt update
   1. sudo apt install docker.io -y
   2. sudo systemctl start docker
   3. sudo systemctl enable docker
   4. sudo apt-get update && sudo apt-get install -y apt-transport-https
   5. sudo curl -s https://packages.cloud.google.com/apt/doc/apt-key.gpg | sudo apt-key --keyring /usr/share/keyrings/kubernetes-archive-keyring.gpg add -
   6. echo "deb [signed-by=/usr/share/keyrings/kubernetes-archive-keyring.gpg] https://apt.kubernetes.io/ kubernetes-xenial main" | sudo tee /etc/apt/sources.list.d/kubernetes.list
   7. sudo apt-get update
   8. sudo apt-get install -y kubectl
   9. kubectl version
  ```
  **Installing the minikube**
  
  ```
   * sudo apt-get install -y virtualbox
   * curl -LO https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
   * sudo install minikube-linux-amd64 /usr/local/bin/minikube
   * minikube start
   * kubectl config use-context minikube
   * minikube version
   * minikube start --memory=4096 --driver=docker
  ```



