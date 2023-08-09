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

## Installation of Kubelet on Ubuntu:

                    1  apt-get upgrade
                    2  sudo apt install docker.io
                    3  sudo systemctl start docker
                    4  sudo systemctl enable docker
                    5  sudo docker run hello-world
                    6  docker images
                    7  curl -s https://packages.cloud.google.com/apt/doc/apt-key.gpg | sudo gpg --dearmour -o                                                     /etc/apt/trusted.gpg.d/kubernetes-xenial.gpg
                    8  sudo apt-add-repository "deb http://apt.kubernetes.io/ kubernetes-xenial main"
                    9  sudo apt update
                   10  apt-get upgrade -y
                   11  sudo apt install kubeadm kubelet kubectl
                   12  ls
                   13  sudo apt-mark hold kubelet kubeadm kubectl
                   14  sudo swapoff -a
                   15  sudo sed -i '/ swap / s/^\(.*\)$/#\1/g' /etc/fstab
                   16  sudo kubeadm init
                   17  mkdir -p $HOME/.kube
                   18  sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
                   19  sudo chown $(id -u):$(id -g) $HOME/.kube/config
                   20  kubectl apply -f app-deployment.yaml
                   21  touch app-deployment.yaml
                   22  ls
                   23  vi app-deployment.yaml
                   24  kubectl apply -f app-deployment.yaml
                   25  apt install firewalld
                   26  sudo firewall-cmd --add-port=6443/tcp --permanent
                   27  sudo firewall-cmd --reload
                   28  kubectl apply -f app-deployment.yaml
                   29  sudo kubeadm init
                   30  kubectl get nodes

                

                
                
