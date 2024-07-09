## Day-4

1.VPC Peering 

2.VPC Endpoints

3.EBS and its Types

4.Perform a vpc peering and get a snap shot of ebs and replicate in different region .


1.Whai is Vpc?
VPC is a virtual private network which has isolated environment with the aws cloud.

2.what is subnet?
A subnet is  a range of IP addresses in your VPC.

3.What is CIDR range?
CIDR is a Class-Inter-Domain-Routing .It allocates the ip address range.

4.What is Nat Gateway?
Nat Network address translation used to provide the internet to the private network.
where it works as only one way traffic from the private subnet.

5.What is Nacl?
Network access control list it is similar to sg (security groups ) but in nacl you can deny the ip iddress.

6.What is Route Table?
Route table are used to route the traffic to the subnets.

7.What is IGW?
Internet gateway is used to provide the internet access to the vpc.



# Vpc Endpoint:

A VPC Endpoint in AWS allows you to privately connect your VPC.VPC endpoint services doesnt requiring an internet gateway, NAT device, VPN connection.

They are two types of Vpc Endpoints:

1.Interface Endpoints:
 It operates the elastic network interface with in your vpc.

2.Gateway Endpoints: 
It operates the mainly route table, used for supported services such as S3 and DynamoDB.

# EBS (Elastic Block Storage)

EBS is a block level storage it is used for store the persistent data.Where we attach the extra storage space to the ec2.

Three types of EBS:
1.SSD Volumes
2.HDD Volumes
3.Previous generation volumes

* SSD Volumes:
    SSD volumes are used for high performance and low latency storage.
    Types are:
    1.General Perpose
    2.GP2 
    3.GP3
* gp2 and gp3 are nothing but the versions.
    4.IO1   
    5.IO2
    6.IO3

io1,io2 & io3 are also versions but iops is input output per second it is used for faster access it is used mainly when u have large applications.Common gp2 and gp3 is preferred.



## To create a snapshot from the Ec2 and attach it to another vm or Ec2 follow the below Steps:
```
Step1:
Create a instance 

Step2:
Create a ebs volume with 1 gb or as per urwish.

Step3:
Attach the volume to the instance 

Step4:
lsblk
lsblk to list the block level storage

fdisk -l
fdisk command to check the disk path or disk partition.

Step5:
check the disk is empty or not use below command
file -s /dev/path

Step6:
if it is empty then create a file system
mkfs -t xfs /dev/path  --> for large file storage
(or)
mkfs -t ext4 /dev/path --> commonly used file system ext4

Step7:
mkdir shashi
mount the file system
mount /dev/path /shashi
then create any two files it will help in snapshot and replicate in another server
touch abc1 abc2

Step8:
create a snapshot of the volume in the console
in that snapshot in actions create a new volume with that snapshot.

Step9:
create new instance ebs2
attach the volume to the instance ebs2

Step10:
lsblk
fdisk -l
file -s /dev/path
it shows file sistem is not empty it means the snap shot is replicated from the ebs1 data  to ebs2.
mkdir newfolder
mount /dev/path /newfolder
then the files created in  ebs1 instance should replicate in ebs2 instance.

END
```


