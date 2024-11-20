## Terraform

### 1.Terraform init
```
Terraform init prepare the working directory for terraform  by installing the
equired plugins and modules and setup the configuration.
```
### 2.Terraform Validate
```
To check the configuration and syntax is proper or not (or)
verify the correctness of Terraform configuration files. 
```
### 3. Terraform .tfvars.
```
it stores the keys and pass securely runtime like tenant id ,sub id,client id,secrets etc.
 passing that :
terraform apply -var-file="filename.tfvars"
```
