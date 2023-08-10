# Kubernetes (K8s)

     * What is Kubernetes and what is the use of it?

               Kubernetes also known as K8s ,and it is a open source container orchestration platform designed to automate the deployment                   scaling,and management of containerized applications.


      * Key Components of K8s are:

                Containers >> Pods >> Clusters >> Servcies.
                           
## Installation steps of MiniKube on ubuntu:

        https://phoenixnap.com/kb/install-minikube-on-ubuntu    

        Step1:(Pre-requirements)
                * apt-get update -y
                * apt-get upgrade -y
                * apt install docker.io

        Step2:
                * sudo apt-get install curl
                * sudo apt-get install apt-transport-https
                * sudo apt install virtualbox virtualbox-ext-pack
                * Then choose licence as yes
        Step3:
                * wget https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
                * sudo cp minikube-linux-amd64 /usr/local/bin/minikube
                * sudo chmod 755 /usr/local/bin/minikube
                * minikube version

## Installation of Master node in Kubelet on Ubuntu:

                    https://kubernetes.io/docs/setup/production-environment/tools/kubeadm/install-kubeadm/
                    
                    1  apt-get upgrade
                    2  sudo apt install docker.io
                    3  sudo systemctl start docker
                    4  sudo systemctl enable docker
                    5  sudo docker run hello-world
                    6  docker images
                    7  sudo apt-get install -y apt-transport-https ca-certificates curl
                    8  curl -fsSL https://dl.k8s.io/apt/doc/apt-key.gpg | sudo gpg --dearmor -o /etc/apt/keyrings/kubernetes-archive-                             keyring.gpg
                    9  echo "deb [signed-by=/etc/apt/keyrings/kubernetes-archive-keyring.gpg] https://apt.kubernetes.io/ kubernetes-                              xenial main" | sudo tee /etc/apt/sources.list.d/kubernetes.list
                   
## Requirements to be installed in Slave node:
                    1  apt-get update -y
                    2  sudo apt install docker.io
                    3  sudo systemctl start docker
                    4  sudo systemctl enable docker
                    5  curl -s https://packages.cloud.google.com/apt/doc/apt-key.gpg | sudo gpg --dearmour -o                     
                        /etc/apt/trusted.gpg.d/kubernetes-xenial.gpg
                    6  sudo apt-add-repository "deb http://apt.kubernetes.io/ kubernetes-xenial main"
                    8  sudo apt-update
                    9  sudo apt-get upgrade -y
                   10  sudo apt install kubeadm kubelet kubectl
                   11  kubeadm join 172.31.41.211:6443 --token dzdiyw.2q65onstsgav2ofp --discovery-token-ca-cert-hash             
                       sha256:159e08be212bf469933ca36485374e55dbca9a3a3ae78924d7ef959b89c0afc1
  
    

                
                
