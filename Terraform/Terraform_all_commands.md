### Terraform_all_commands:
```
Main commands:
  init          Prepare your working directory and install the all required plugin and also installs the provider with mentioned version.
  validate      Checks the syntax or configuration is valid or not
  plan          Its like a dry run shows what will happen if we apply.
  apply         It create or update infrastructure
  destroy       Destroy previously-created infrastructure
```
**terraform console**
```
It is a interactive use where u can test the code or execute for testing purpose
```
```
Eg: terraform console 
>length(["a", "b", "c"])
output is 3
```
**terraform fmt**
```
It is used to format the terraform code in right order of syntax format
```
**terraform force-unlock**
```
Terraform force-unlock <id_ofterraform_lock_hcl>
The above command is used for forcely unlock the lock id
* Use Case: Resolve issues caused by interrupted or stuck operations.
```
**Terraform get**
```
It is used to download the provider and modules which ever required form the documntaion example.

Eg:
module "vpc" {
  source = "terraform-aws-modules/vpc/aws"
  cidr   = "10.0.0.0/16"
}
```
```
terraform get 
terraform init
terraform plan
```





