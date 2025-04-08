## Backend_for_statelock
```
terraform {
  backend "s3" {
    bucket         = "papspdoset"
    key            = "state/terraform.tfstate"
    region         = "ap-south-1"
    dynamodb_table = "shashitable"
    encrypt        = true
  }
}
```
