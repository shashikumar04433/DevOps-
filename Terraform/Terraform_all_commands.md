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
**terraform graph**
``` 
terraform graph
# Output: A visual representation of the Terraform configuration as a graph.

graph using the specified command you can view the png files in graphical way.
terraform graph -type=plan tfplan | dot -Tpng -o graph.png
```

**terraform import**
```
It is used to import existing infrastructure into Terraform

Eg:
terraform import aws_instance.example i-1234567890abcdef0
It imports the existing ec2 which created manually created into under terraform for automation

```

**Terraform Provides**
```
Show the providers required by the configuration.
* terraform providers
```

**Terraform refresh**
```
Sync the state file with the current state of real infrastructure.
```

**terraform show**
```
Review the state or a saved execution plan in detail.
```
**terraform state list**
```
List all resources in the state file
```
**terraform taint**
```
Mark a resource as tainted, which means it will be recreated on the next apply.
```
**terraform untaint**
```
Mark a resource as untainted, which means it will not be recreated on the next apply.
```
**terraform Workspace**
```
 Manage Terraform workspaces for multiple environments.Separate environments like dev, staging, and prod using different workspaces.

terraform workspace list
terraform workspace new staging
terraform workspace select staging
terraform workspace delete staging
```




