### Terraform Scripting rules:

    1.Variables.
    2.Provider.
    3.Resources.
    4.Input description.
    5.Output description.


    Provider is Cloud=Aws ,Azure, Gcp etc.


###  Creating server with terraform script:
eg:It will create the server with t2.miro in mumbai region.

            provider "aws" {
          region = "ap-south-1"
        }
        
        resource "aws_instance" "example" {
          ami = "ami-xxxxxxxxxxxxx" # Change the AMI 
          instance_type = "t2.micro"
        }
