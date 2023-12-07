https://devopscube.com/install-configure-aws-cli-linux/

## Steps for installing the aws-cli on linux:

AWS IAM user access key and secret key with permission to access AWS services. If you don’t have access and secret keys, you can get one created from the AWS IAM service.
```
    Install AWS CLI on Linux
    
    * Step 1: Download the AWC CLI installation files using curl.
    
              curl "https://awscli.amazonaws.com/awscli-exe-linux-x86_64.zip" -o "awscliv2.zip"
    * Step 2: 
              unzip awscliv2.zip 
     Step 3:
            sudo ./aws/install
  ```          

  ## If above commads does'nt work please follow below commands to install aws-cli in Redhat:
  
        Copy full command and paste:
        
      * curl "https://s3.amazonaws.com/aws-cli/awscli-bundle.zip" -o "awscli-bundle.zip"
        unzip awscli-bundle.zip
       ./awscli-bundle/install -b ~/bin/aws
      
