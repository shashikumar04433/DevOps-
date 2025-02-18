provider "aws" {
    region = var.region
    access_key=var.access_key
    secret_key = var.secret_key
}

resource "aws_vpc" "vpc1" {
  cidr_block = "10.0.0.0/16"
  enable_dns_hostnames = true
  enable_dns_support = true
  
}
resource "aws_subnet" "pub_subnet" {
  vpc_id     = aws_vpc.vpc1.id
  cidr_block = "10.0.1.0/24"
  map_public_ip_on_launch = true
  
}
resource "aws_subnet" "priv_subnet" {
  vpc_id     = aws_vpc.vpc1.id
  cidr_block = "10.0.2.0/24"
  map_public_ip_on_launch = false
  
}
resource "aws_internet_gateway" "igw" {
  vpc_id = aws_vpc.vpc1.id
}
resource "aws_route" "route_table" {
  destination_cidr_block = "0.0.0.0/0"
  route_table_id = aws_vpc.vpc1.id
 gateway_id = aws_internet_gateway.igw.id
 
}


resource "aws_instance" "ec2_instance1" {
  ami =var.ami
  instance_type = "t2.micro"
  vpc_security_group_ids = [aws_security_group.sg.id]
  subnet_id = aws_subnet.pub_subnet.id  
}

resource "aws_eks_cluster" "eks_cluster_frontend" {
  name = "eks_cluster_demo_project"
  role_arn = aws_iam_role.eks_cluster_role.arn
  vpc_config {
    subnet_ids = [aws_subnet.pub_subnet.id, aws_subnet.priv_subnet.id]
  }
}

resource "aws_eks_node_group" "eks_node_group" {
  cluster_name    = aws_eks_cluster.eks_cluster_frontend.name
  node_group_name = "eks_node_group_demo_project2"
  node_role_arn   = aws_iam_role.eks_node_role.arn
  subnet_ids = [aws_subnet.pub_subnet.id, aws_subnet.priv_subnet.id]
}





write a function or script which excepts which input as string whose length is less then or equal 10




second input value whic is integer , default value delta = 3


input = "test"
delta = 3
 output = whvw

 input = "whvw"
delta = -3
 output = test



a = "test"
delta =3
def reverse_val (val):
    return_val val[::3]
    print(reverse_val (a))

