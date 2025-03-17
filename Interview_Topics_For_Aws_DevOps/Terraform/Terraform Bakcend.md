### Terraform Bakcend

```
* Stores Terraform state in an S3 bucket with DynamoDB locking.
```
**Run these commands in AWS CLI:**
```
aws s3 mb s3://my-terraform-state-bucket
aws s3api put-bucket-versioning --bucket my-terraform-state-bucket --versioning-configuration Status=Enabled
```
**Step 2: Create a DynamoDB Table for Locking**
```
aws dynamodb create-table --table-name terraform-lock \
    --attribute-definitions AttributeName=LockID,AttributeType=S \
    --key-schema AttributeName=LockID,KeyType=HASH \
    --billing-mode PAY_PER_REQUEST
```
**backend.tf**
```
terraform {
  backend "s3" {
    bucket         = "my-terraform-state-bucket"
    key            = "prod/terraform.tfstate"
    region         = "us-east-1"
    dynamodb_table = "terraform-lock"
    encrypt        = true
  }
}
```
