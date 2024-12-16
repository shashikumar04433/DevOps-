## Terraform Loops
```
Three types of loops in terraform they are:
1.count
2.For_each
```
**Count**
```
Creating multiple instance with the count 
Eg:
variable "variable_name" {
  type    = list(string)
  default = ["shashi", "anand"]
}

resource "aws_instance" "name_ec2_instance" {
  count         = 2
  instance_type = "t2.micro"
  ami   = "xxxxxxxxxxxxx"


  tags = {
    name = "instance-${count.index}"
  }
}


output "outcomes" {
    value = var.variable_name
  
}
```
**For_Each**
```
variable "to_set_for_Each2" {
  type = map(string)
  default = {
    web   = "ami-0c55b159cbfafe1f0"
    db    = "ami-0d4c28fba74f72c63"
    cache = "ami-0b0f5f94e9e623a1e"
  }
}
resource "aws_instance" "count_example2" {
  for_each      = var.to_set_for_Each2
  ami           = each.value
  instance_type = var.instance_type

  tags = {
    name = "Instance -${each.key}"
  }
}
```
