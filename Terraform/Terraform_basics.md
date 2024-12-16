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


## Summary of Precedence (Highest to Lowest)
1. Command-line flags (-var).
```
eg: terraform apply -var "env=prod"
```
2. Environment variables (TF_VAR_<name>).
3. .auto.tfvars files.
4. terraform.tfvars file.
```
eg: terraform apply -var-file="custom.tfvars"
```
5. Manually loaded -var-file files.
6. Default value in variable block.

# Terraform Data Types:

Primitive Data Types
---------------------   
* String
```
variable "instance_type" {
  type    = string
}
output "outcomeis"{
    instance_type = "t2.miro"
}
```
* Number
```
variable "number_of_instance" {
  type    = number
}
output "outcomeis"{
    number_of_instance = 2
  ```
* Boolen
```
variable "enable_feature" {
  type        = bool
  description = "Flag to enable or disable a feature"
  default     = false
}
```
Complex Data Types
---------------------
* list
```
variable "instance_type" {
  type    = list(number)
  default = [ "1","2","3","4"]
}

output "outcomeis"{
  value= var.instance_type
}
```

* map
```
  variable var_name{
  type=map
  default={
  name ="shashi"
  age = "20"
  }
  ```
Eg2:
```
  variable var_name2{
  type=map(string)
  default={
  name ="shashi"
  age = 20
  }
  ```
eg3:
```
  variable var_name3{
  type=map(number)
  default=
{
  name =1234
  age = 20
  }

```
  
* tuple
```
  variable "instancetags"
  {
  type    = tuple([string,number])
  default = (["shashi",30])
 }
output "outcomeis"
{
  value= var.instancetags
}

```
* Eg2:
```
  variable "instancetagsone" {
  type    = tuple([number,number])
  default = ([1234,30])
}
output "outcomeis"
{
  value= var.instancetagsone
}

```

* Eg3:
```
  variable "instancetagstwo" {
  type    = tuple([string,string])
  default = (["shashi",30])
}

output "outcomeis" {
  value= var.instancetagstwo
}

```
* object
```
  variable "object_understanding" {
  type = object({
    ami_id        = string
    instance_type = map(string)
  })

  default = {
    ami_id        = "ami-12345678"
    instance_type = {
      small  = "t2.small"
      medium = "t2.medium"
      large  = "t2.large"
    }
  }
}

output "outcomes" {
  value = var.object_understanding
}
```
* List supports multiple data types  and where as map should be same data type with in the scope.
```
variable "object_with_map" {
  type = object({
    name       = string
    age        = number
    attributes = map(string)
  })

  default = {
    name       = "shashi"
    age        = 25
    attributes = {
      hobby     = "coding"
      location  = "India"
      language  = "Terraform"
    }
  }
}
```

* Any
```  
variable "instancetags" {
  type    = tuple([any,any,any])
  default = ["shashi",30, true]
}
output "outcomeis"{
  value= var.instancetags
}
```
* set
```
  variable "set_variable" {
    type = set(number)
    default = [ 0,3,2,4,7,6,5 ]
  
}
output "outcomes" {
    value = var.set_variable
  
}
```



