## Terraform Modules for Vpc 
```
1.create a module folder named module then vpc folder
2. then write the main.tf in module/vpc/main.tf
3.same for variables.tf  module/vpc/variables.tf

4. then come back to main central .tf file .

```
```
module "vpc" { 
  source = "./modules/vpc" 
  vpc_name = var.vpc_name 
  cidr_block = var.vpc_cidr_block 
  }
```
