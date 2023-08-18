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
                    10  sudo apt-get update
                    11  sudo apt-get install -y kubelet kubeadm kubectl
                    12  sudo apt-mark hold kubelet kubeadm kubectl
                    13  sudo apt-get install firewalld
                    14  sudo firewall-cmd --add-port=6443/tcp --permanent
                    15  sudo firewall-cmd --reload
                    19  export KUBECONFIG=/etc/kubernetes/admin.conf
                    19  sudo kubeadm init --pod-network-cidr=192.168.0.0/16
                    20  (you get the kubeadm code to join slave take that and paste in slave server ex:
                                kubeadm join 172.31.32.194:6443 --token 3dfp1h.munabpkjvqcikkzs \
                                --discovery-token-ca-cert-hash sha256:39f2f072c276614e2cdf9ace6366c7cdc5e40a7080684fbe01fb7e72dcbdb168)
                    21  kubectl get nodes
                    22  mkdir -p $HOME/.kube
                    23  sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
                    24  sudo chown $(id -u):$(id -g) $HOME/.kube/config
                    25  kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.26.1/manifests/tigera-operator.yaml
                    26  kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.26.1/manifests/custom-resources.yaml
                    27  watch kubectl get pods -n calico-system 
                    (check this link for reference:
                        https://docs.tigera.io/calico/latest/getting-started/kubernetes/quickstart)
                   
## Requirements to be installed in Slave node:
                    1  apt-get upgrade
                    2  sudo apt install docker.io
                    3  sudo systemctl start docker
                    4  sudo systemctl enable docker
                    5  sudo docker run hello-world
                    6  docker images
                    7  sudo apt-get install -y apt-transport-https ca-certificates curl
                    8  curl -fsSL https://dl.k8s.io/apt/doc/apt-key.gpg | sudo gpg --dearmor -o /etc/apt/keyrings/kubernetes-archive-   keyring.gpg
                    9  echo "deb [signed-by=/etc/apt/keyrings/kubernetes-archive-keyring.gpg] https://apt.kubernetes.io/ kubernetes-      xenial main" | sudo tee /etc/apt/sources.list.d/kubernetes.list
                    10  sudo apt-get update
                    11  sudo apt-get install -y kubelet kubeadm kubectl
                    12  sudo apt-mark hold kubelet kubeadm kubectl
                    13  sudo apt-get install firewalld
                    14  sudo firewall-cmd --add-port=6443/tcp --permanent
                    15  sudo firewall-cmd --reload
                    16  kubeadm join 172.31.32.194:6443 --token 3dfp1h.munabpkjvqcikkzs \
                    --discovery-token-ca-cert-hash sha256:39f2f072c276614e2cdf9ace6366c7cdc5e40a7080684fbe01fb7e72dcbdb168
  
    

                
                
