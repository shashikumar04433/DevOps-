### Remote_backend:

```
A Terraform backend determines how Terraform stores and manages its state file. By default,
Terraform uses the local backend, where the state file is saved locally on your machine.
However, other backends (like AWS S3, Azure Blob Storage, etc.) allow you to store state remotely,
enabling collaboration, versioning, and security.
```

```
* Multiple team members can access a shared state file.
* Present concurrent modifications to the state file.
* Security sensitive data is stored securely in a remote backend.
```
```
terraform {
  backend "s3" {
    bucket         = "my-terraform-backend-bucket"
    key            = "terraform/state"
    region         = "us-west-2"
    dynamodb_table = "terraform-lock" # Optional for state locking
    encrypt        = true
  }
}
```
**Eg2**
```
resource "aws_instance" "name" {
  ami           = var.ami
  instance_type = "t2.micro"
  
}

terraform {
  backend "s3" {
    bucket = "my-terraform-state-bucket02"
    key    = "terraform_client/terraform.tfstate"
    region = "ap-south-1"
    encrypt = true
    # profile = "my-aws-profile" # Replace with the correct AWS profile name
  }
}

```

