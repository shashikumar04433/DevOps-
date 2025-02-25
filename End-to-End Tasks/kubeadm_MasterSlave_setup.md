### Kubernetes Setup with Calico CNI 
**1. System Preparation**
```
Update the system and install necessary packages:
* sudo apt update -y
* sudo apt install -y apt-transport-https curl net-tools
```
**2. Install Kubernetes Components**
```
Add the Kubernetes repository and install kubeadm, kubelet, and kubectl:
* curl -fsSL https://pkgs.k8s.io/core:/stable:/v1.31/deb/Release.key | sudo gpg --dearmor -o /etc/apt/keyrings/kubernetes-apt-keyring.gpg
* echo 'deb [signed-by=/etc/apt/keyrings/kubernetes-apt-keyring.gpg] https://pkgs.k8s.io/core:/stable:/v1.31/deb/ /' | * sudo tee /etc/apt/sources.list.d/kubernetes.list
* sudo apt update
* sudo apt install -y kubelet kubeadm kubectl
* sudo apt-mark hold kubelet kubeadm kubectl
```
**3. Install and Configure Containerd**
```
Install containerd:
* sudo apt install -y containerd
* Generate the default containerd configuration file:
* mkdir -p /etc/containerd
* containerd config default | sudo tee /etc/containerd/config.toml > /dev/null
* Enable SystemdCgroup in containerd:
* sudo sed -i 's/SystemdCgroup = false/SystemdCgroup = true/' /etc/containerd/config.toml
Restart containerd:
* sudo systemctl restart containerd
```
**4. Enable IP Forwarding**
```
Enable IP forwarding for networking:
* sudo sysctl -w net.ipv4.ip_forward=1
* echo "net.ipv4.ip_forward = 1" | sudo tee -a /etc/sysctl.conf
* sudo sysctl -p
```
**5. Initialize Kubernetes Master Node**
```
Run the kubeadm init command:
* sudo kubeadm init --apiserver-advertise-address=<MASTER_NODE_IP> --pod-network-cidr=192.168.0.0/16 --upload-certs
* Replace <MASTER_NODE_IP> with the actual IP of the master node.
* Calico uses 192.168.0.0/16 as the default CIDR.
```
**6. Configure kubectl for Master Node**
```
Set up kubectl for the current user:
* mkdir -p $HOME/.kube
* sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
* sudo chown $(id -u):$(id -g) $HOME/.kube/config
```
**7. Install Calico as the CNI**
```
Apply the Calico YAML manifest:
* kubectl apply -f https://raw.githubusercontent.com/projectcalico/calico/v3.26.1/manifests/calico.yaml
```
**8. Verify Calico Installation**
```
Check if Calico pods are running:
* kubectl get pods -n kube-system
* Check if all nodes are in "Ready" state:
* kubectl get nodes
```
**9. Join Worker Nodes**
```
On each worker node, run the join command:
* sudo kubeadm join <MASTER_NODE_IP>:6443 --token <TOKEN> --discovery-token-ca-cert-hash sha256:<HASH>
* If the join command was lost, regenerate it on the master node:
* kubeadm token create --print-join-command
```
**10. Verify Cluster Status**
```
Check the nodes in the cluster:
* kubectl get nodes -o wide
* kubectl get pods -n kube-system
* kubectl get pods -n kube-system | grep calico
```
**Test Network**
```
kubectl expose pod nginx --port=80 --type=NodePort
kubectl get svc nginx
```
or best way
```
write deployment.yml and svc.yml and deploy the application then access with the 
http://ip:30080
```
