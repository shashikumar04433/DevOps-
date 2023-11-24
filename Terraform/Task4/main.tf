provider "aws" {
    region="us-east-1"
  
}
resource "aws_instance" "newinstance" {
    instance_type = "t2.micro"
    ami="ami-0fc5d935ebf8bc3bc"
    
}
resource "aws_s3_bucket" "abucket" {
    bucket = "shashikumarabc-new"
  
}
resource "aws_dynamodb_table" "terraform_lock" {
    name = "terraform_locking_system"
    billing_mode = "PAY_PER_REQUEST"
    hash_key = "LockId"

    attribute {
      name="LockId"
      type = "S"
    }
}