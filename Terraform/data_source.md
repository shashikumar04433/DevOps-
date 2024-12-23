### Data_source
```
A data source is nothing but it is a way of fetching the information from the existing infra
```
**Eg:**
```
data "aws_ami" "example" {
  most_recent = true
  owners      = ["amazon"]

  filter {
    name   = "name"
    values = ["amzn2-ami-hvm-*-x86_64-gp2"]
  }
}

# Use the fetched AMI in a resource
resource "aws_instance" "example" {
  ami           = data.aws_ami.example.id
  instance_type = "t2.micro"
}
```
```
It takes the latest ami id based on amazon and execute it
```
