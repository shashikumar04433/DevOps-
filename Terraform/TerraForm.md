## TerraForm:

### Installation of Terraform in Windows:

      Step1:
            Install a Vs Code and install the plugins HCl in it.

      Step2:
            Install the terrform in local for windows with the following link <https://developer.hashicorp.com/terraform/install>

      Step3:
            Unzip the terraform and copy the file and put in the system32 if it is ur office laptop or put in the admin local C.

      Step4:
            do the Aws configure then
      Step5:
            write a following script as main.tf file

                           provider "aws" {
                 region = "ap-south-1"  # Set your desired AWS region
               }
            
               resource "aws_instance" "shashi" {
                 ami           = "ami-0287a05f0ef0e9d9a"  # Specify an appropriate AMI ID
                 instance_type = "t2.micro"
                 availability_zone = "ap-south-1a"
                 key_name = "terraform"
               }

      Step6:
            change the above ami as urs and key name.

      Step7:
            terraform init
            terraform plan
            terraform apply
            terraform destroy (for deleting the server)
      


  
