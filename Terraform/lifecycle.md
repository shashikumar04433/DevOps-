### Lifecycle in Terraform
```
The lifecycle block in Terraform is used to control specific behaviors
during the creation, update, and deletion of resources.
```
**Eg**
```
resource "aws_instance" "example" {
  ami           = "ami-123456"
  instance_type = "t2.micro"

  lifecycle {
    create_before_destroy = true
  }
}
```
**Prevent_destroy**
```
resource "aws_s3_bucket" "example" {
  bucket = "my-important-bucket"

  lifecycle {
    prevent_destroy = true
  }
}
```
**Full Lifecycle Block**
```
resource "aws_instance" "example" {
  ami           = "ami-123456"
  instance_type = "t2.micro"

  lifecycle {
    create_before_destroy = true
    prevent_destroy        = true
    ignore_changes         = [tags]
  }
}
```

