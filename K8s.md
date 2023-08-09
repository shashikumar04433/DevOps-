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

## Installation of Kubelet:

                * curl -LO https://storage.googleapis.com/kubernetes-release/release/`curl -s https://storage.googleapis.com/kubernetes-                    release/release/stable.txt`/bin/linux/amd64/kubectl
                * chmod +x ./kubectl
                * mv ./kubectl /usr/local/bin/kubectl
                * kubectl version -o json
                * before running minikube exit as root and run as ubuntu user
                * minikube start
                * or if you want to run as root then ---> minikube start --force 
                * kubectl config view
                * kubectl config-info
                * kubectl get nodes
                * kubectl get pod 
                * minikube ssh
                * exit
                * minikube stop 
                * minikube status
                * minikube delete
                *  minikube addons list
                * minikube dashboard
                * minikube dashboard --url
                * Enter the ip in the browser to access the Kubernetes dashboard.
                

                
                
