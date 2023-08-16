
# Creating the Elastic container repository in Windows:

            Step1:
            Install aws cli ,Powershell (with black label icon).
            
            Step2:
            Create a role in aws with the access of ec2 repository and admin access and create access key and store it somewhere 
            for forther requirements example below.
            Access key - AKIA43MM3UB4BSMWHP7D
            Secret access key - vOWVw00aqv9Kca4G8NkQiWaEyim/Yd5H47XQ9GzX
            Region - ap-northeast-1
            
            Step3:
            Create a ecr private repository and then click on push commands.
            
            Step4:
            example:
            docker tag coretry:dev 883448062072.dkr.ecr.ap-northeast-1.amazonaws.com/worktasknew:latest
            change the local docker image name in the starting.
            
            Step5:
            Then push command.
            
            Step6:
            Create a ecs cluster then task definition and service and after if the task are running take the public ip and paste in the               browser.
            
            
            END 


           
