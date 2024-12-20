### Provisioners:
```
Provisioners in terraform are used to execute scripts or commands.
* Installing software.
* Configuring services.
* Running scripts.
```
Types of provisioners in Teraform
```
1.local-exec provisioner
2.remote-exec provisioner
3.file provisioner
```
**local-exec provisioner**
```
This provisioner is used to execute a local command or script on the terraform 
```
Eg:
```
# Declare a variable for the AMI

# EC2 Instance resource
resource "aws_instance" "example2" {
  ami           = var.ami
  instance_type = "t2.micro"

  # Local-exec provisioner to save public IP to a file
  provisioner "local-exec" {
    command = "echo ${self.public_ip} >> server_ip.txt"
  }
}

# Output block to display the public IP
output "instance_public_ip" {
  description = "The public IP address of the instance"
  value       = aws_instance.example2.public_ip
}
```
**remote-exec provisioner**
```
This provisioners is used to execute a remote server and runs a command or scripts.
```
Eg:
```
resource "aws_instance" "name" {
  ami           = var.ami
  instance_type = var.instance_type
  key_name = "terraform_client"
}

resource "null_resource" "execution" {
  depends_on = [aws_instance.name]
  connection {
    type        = "ssh"
    host        = aws_instance.name.public_ip
    user        = "ec2-user"
    private_key = file("./terraform_client.pem")
  }

  provisioner "remote-exec" {
    inline = [
      "sudo yum install nginx -y",
      "sudo service nginx start"
    ]
  }
}
```
**file provisioner**
```
This provisioner is used to copy a file from the local machine to the remote machine.
```
