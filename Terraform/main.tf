provider "aws" {
  alias  = "ap-south-1"
  region = "ap-south-1" # Set your desired AWS region
}

provider "aws" {
  alias  = "ap-northeast-3"
  region = "ap-northeast-3" # Set your desired AWS region
}

resource "aws_instance" "Example" {
  ami           = "ami-02a2af70a66af6dfb" # Specify an appropriate AMI ID
  instance_type = "t2.micro"
  provider      = aws.ap-south-1
  key_name      = "terraform"
}
resource "aws_instance" "Example2" {
  ami           = "ami-0690c54203f5f67da" # Specify an appropriate AMI ID
  instance_type = "t2.micro"
  provider      = aws.ap-northeast-3
  key_name      = "terra"
}

  