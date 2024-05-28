provider "aws" {
    region = "us-east-1"
  
}
provider "vault" {
  address = "http://44.201.234.190:8200"
  skip_child_token = true

  auth_login {
    path = "auth/approle/login"

    parameters = {
      role_id = "443a8f2a-3a38-eba7-86a1-56dab265ac7a"
      secret_id = "6a05138d-9292-5bde-4e3f-2df2868e4a8e"
    }
  }
}
data "vault_kv_secret_v2" "example" {
  mount = "kv" 
  name  = "test-secret" 

}
resource "aws_instance" "my_instance" {
  ami     = "ami-0fc5d935ebf8bc3bc"
  instance_type = "t2.micro"

  tags = {
    secret= data.vault_kv_secret_v2.example.data["username"]
  }
}
resource "aws_s3_bucket" "name" {
  bucket = data.vault_kv_secret_v2.example.data["username"]
  
}

