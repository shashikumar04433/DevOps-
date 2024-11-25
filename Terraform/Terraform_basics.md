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
### 3. Terraform state list 
```
To ensure Terraform is tracking all resources correctly. or It lists all the files
```

### 4. terraform refresh 
```
It update or refresh the state file.
```
### 5. terraform destory
```
Run terraform destroy to remove everything created by terraform.
```
