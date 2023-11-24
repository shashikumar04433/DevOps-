provider "aws" {
    region="ap-south-1"
  
}
module "ec2_instance" {
    source = "./module/ec2_instance"
    ami_value="ami-02a2af70a66af6dfb"
    instance_type_value="t2.micro"

    
}
