terraform {
  
  backend "s3" {  
    bucket = "shashikumarabc-new"
    region = "us-east-1"
    key="shashi123/terraform.tfstate"
    
  }
  }