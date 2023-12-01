## Terraform Migration and Drift Detection :

    * How to get the full information of the instance through the instance_id with the terraform commands.

         provider "aws" {
          region="us-east-1"
        
      }
      import {
        id="i-0602369fe99f43a62"
        to=aws_instance.example
      }
    
    * terraform init
    * terraform plan -generate-config-out=generated_resource.tf
    
```
terraform plan -generate-config-out=generated_resource.tf this command explains 
storing the end-to-end details of instance in generated_resource.tf 
```
