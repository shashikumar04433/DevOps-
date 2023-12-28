## Kubernetes Project using EKS:

Step1:

Install the Aws-Cli, Eksctl, Kubectl in the os.
      
**Aws-cli Installation:**

    ```  
    Install AWS CLI on Linux
    
    * Step 1: Download the AWC CLI installation files using curl.
    
              curl "https://awscli.amazonaws.com/awscli-exe-linux-x86_64.zip" -o "awscliv2.zip"
    * Step 2: 
              unzip awscliv2.zip 
     Step 3:
            sudo ./aws/install
     ```

**Installation of eks:**
```
   * sudo apt update
   * curl --silent --location "https://github.com/weaveworks/eksctl/releases/latest/download/eksctl_$(uname -s)_amd64.tar.gz" | tar xz -C /tmp
   * sudo mv /tmp/eksctl /usr/local/bin
   * eksctl version
```

**Installation of Kubectl on Ubuntu:**



      
      
