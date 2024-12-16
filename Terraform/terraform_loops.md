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
variable "variable_name"{
type = list(string)
default =["shashi","anand"]
}

resource "aws_instance" "name_ec2_instance"{
count=2
instance_type ="t2.micro"
ami="xxxxxxxxxxxxx"

tags ={
name = "instance-${count.index}"
}
}
```
