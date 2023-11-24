## TerraForm Basic Commands:
     
      * terraform init
      * terraform plan
      * terraform validate
      * terraform apply
      * terraform destroy
      * terraform init -migrate-state
      * terraform init -reconfigure
      * terraform.tfstate
      * terraform destroy -target 
      
      * If you wish to attempt automatic migration of the state, use :
        --> terraform init -migrate-state
      
         If you wish to store the current configuration with no changes to the state, use 
        --> terraform init -reconfigure

        -->terraform.tfstate 
       * file is the heart of TerraForm (Do not make it public so that it could be secure and doesnt lead to go out the ensitive                     information)
       
### Advantages of Terraform:

       * Resource Tracking
       * concurrency control
       * Plan Calculation
       * Resource Planing
       
### Disadvantages of Terraform:

        * Security Risks
        * Versioning Complexity
        * To overcome this disadvantages please follow StateFile_Configuring_S3_with.md

### Names of Security Groups in TerraForm:

          * ingress --->Inbound 
          * egress --->Outbound
### Command to login into server without .pem file if its configured in terraform file:
          * ssh -i ~/.ssh/id_rsa ubuntu@54.86.201.62
