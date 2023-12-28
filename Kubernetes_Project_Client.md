## Kubernetes Project using EKS:
**Pre-Requirements:**
```
Install the Aws-Cli, Eksctl, Kubectl in the os.
```      
**Aws-cli Installation:**
    
    Install AWS CLI on Linux
    
    * Step 1: Download the AWC CLI installation files using curl.
    
              curl "https://awscli.amazonaws.com/awscli-exe-linux-x86_64.zip" -o "awscliv2.zip"
    * Step 2: 
              unzip awscliv2.zip 
     Step 3:
            sudo ./aws/install
         
     

**Installation of eks:**
```
   * sudo apt update
   * curl --silent --location "https://github.com/weaveworks/eksctl/releases/latest/download/eksctl_$(uname -s)_amd64.tar.gz" | tar xz -C /tmp
   * sudo mv /tmp/eksctl /usr/local/bin
   * eksctl version
```

**Installation of Kubectl on Ubuntu:**
```
curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl"
sudo install -o root -g root -m 0755 kubectl /usr/local/bin/kubectl
chmod +x kubectl
mkdir -p ~/.local/bin
mv ./kubectl ~/.local/bin/kubectl
```
**Create a Cluster in Aws**
```
* go to aws console and create a cluster before that create a role anyone in the below mentioned.
* 1. AWS Service: eks2.
* 2. eks-cluster-role .
```
**Connect eks to kubectl:**

* aws eks update-kubeconfig --name safexpay-new --region ap-south-1
* aws configure:
* AWS Access Key ID [None]: AKIAWRMAGMDWCO3JX3FK
* AWS Secret Access Key [None]: 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
* Default region name [None]: ap-south-1
* Default output format [None]:



      
      
