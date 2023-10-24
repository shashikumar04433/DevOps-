# Creating the Elastic container repository in Windows:

            Step1:
            Install aws cli ,Powershell (with black label icon).  
            
            Step2:
            Create a role in aws with the access of ec2 repository and admin access and create access key and store it somewhere 
            for forther requirements example below.
            * Install-Module -Name AWSPowerShell -Force -AllowClobber
            * aws configure
            * Access key - AKIA43MM3UB4BSMWHP7D
            *  Secret access key - vOWVw00aqv9Kca4G8NkQiWaEyim/Yd5H47XQ9GzX
            *  Region - ap-northeast-1
            
            Step3:
            Create a ecr private repository and then click on push commands.
            
             * Get-ExecutionPolicy 
             * Set-ExecutionPolicy RemoteSigned 
             * Get-ExecutionPolicy
             * Import-Module AWSPowerShell
             * (Get-ECRLoginCommand).Password | docker login --username AWS --password-stdin 687014092223.dkr.ecr.ap-south-1.amazonaws.com
             
            Step4:
            example:
            
            * docker tag coretry:dev 883448062072.dkr.ecr.ap-northeast-1.amazonaws.com/worktasknew:latest
            
            change the local docker image name in the starting.
            
            Step5:
            Then push command.
            
            Step6:
            Create a ecs cluster then task definition and service and after if the task are running take the public 
            ip and paste in the browser.
            
            END 

# Creating the Elastic container repository in Linux:

            Step1:
                         * curl "https://awscli.amazonaws.com/awscli-exe-linux-x86_64.zip" -o "awscliv2.zip"
                         * unzip awscliv2.zip
                         * apt install unzip -y
                         * unzip awscliv2.zip
                         * sudo ./aws/install (To check the path where it installed)
                         * aws --version
                         * aws configure
            Step2:
                         * git clone https://github.com/shashikumar04433/FCRAnew.git
                         
                         * create a docker file with the name Docker file 
                         .

            Step3:
                        Create a ECR named Docker-ECR and then click on push commands and choose linux:

                        * aws ecr get-login-password --region ap-southeast-1 | docker login --username AWS --password-stdin 8                                       83448062072.dkr.ecr.ap-southeast-1.amazonaws.com
                        * docker build -t fcra .
                        * docker images
                        * docker tag fcra:latest 883448062072.dkr.ecr.ap-southeast-1.amazonaws.com/fcra:latest
                        * docker push 883448062072.dkr.ecr.ap-southeast-1.amazonaws.com/fcra:latest
                        * docker images
            Step4:
                        Create a ECS and attach the docker ECR image url 
                        

           
