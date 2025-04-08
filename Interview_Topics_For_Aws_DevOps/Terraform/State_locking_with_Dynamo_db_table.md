## State_locking_with_Dynamo_db_table

**main.tf**
```
provider "aws" {
  region = "ap-south-1"
}

resource "aws_instance" "my_ec2" {
  ami           = "ami-0e35ddab05955cf57"  # Amazon Linux 2 AMI in us-east-1 (as of 2024)
  instance_type = "t2.micro"

  tags = {
    Name = "MyTerraformEC2"
  }
}
# Create S3 Bucket
resource "aws_s3_bucket" "tf_state_bucket" {
  bucket = "papspdoset"

  versioning {
    enabled = true
  }

  tags = {
    Name        = "Terraform State Bucket"
    Environment = "dev"
  }
}

# Create DynamoDB Table for State Locking
resource "aws_dynamodb_table" "tf_lock_table" {
  name         = "shashitable"
  billing_mode = "PAY_PER_REQUEST"
  hash_key     = "LockID"

  attribute {
    name = "LockID"
    type = "S"
  }

  tags = {
    Name        = "Terraform Lock Table"
    Environment = "dev"
  }
}
```
