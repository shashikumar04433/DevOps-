Aws Basics:
Topics in VPC:
      1. IP Addressing.
      2. Subnets
      3. Routing in VPC.
      4. Network Access Control.
      5. Internet Connectivity.
      6. VPC Peering. 
      7. VPC Connection.

      IP Address Ranges: 
      When you create a VPC, you specify an IP address range for the VPC. This range is defined using CIDR (Classless Inter-Domain             Routing) notation, such as 10.0.0.0/16. The CIDR block determines the total number of available IP addresses that can be used            within the VPC.

      Subnets:
             Subnets are logical divisions of an IP address range within a network, including a Virtual Private Cloud (VPC) in cloud                  computing. They enable you to segment and organize your network into smaller, more manageable networks. Each subnet has 
             its unique CIDR (Classless Inter-Domain Routing) block, which defines the range of IP addresses assigned to resources 
             within that subnet.
      Routing:
             A routing table is a key component of networking that is used to determine the path of network traffic between 
             different networks or subnets. It is a data structure or a configuration file that resides on a router or a network 
             device and contains a set of rules, called routes.

      Internet Connectivity:

              An Internet Gateway acts as a bridge between your VPC and the public Internet. It provides a target for internet-bound 
              traffic from resources within the VPC and allows them to access the internet or be accessed by internet users.

       NAT (Network Address Translation):

             Gateways are a managed network service provided by cloud service providers to enable outbound internet connectivity for 
             private subnets within a Virtual Private Cloud (VPC) environment. NAT gateways allow resources in private subnets to 
             communicate with the internet while hiding their private IP addresses.

       Peering connections:

                Peering connections enable resources in different VPCs to communicate with each other as if they were on the same network.
VPC Practical Demo:
      Step1:  (VPC)
                Create a VPC:
                10.0.0.0/16
                enable domain hostname

      Step2:   (Subnets) 
                Create two subnets named Public-Subnet and Private-Subnet:
                Public-Subnet---> 10.0.0.0/16 ---->It means it allocated 255 ips 
                Private-Subnet--> 10.0.1.0/16
                eg :
                10.0.2.0/16
                10.0.3.0/16
                10.0.4.0/16
                .. 
                10.0.255.0/16
                Enable auto-assign public IPv4 addresses for both subnets.

      Step3:   (IGW -->Internet Gateway):          
                It is used to connect to the internet using IGW.
                & attach to the VPC.

      Step4:   (Route Table)
                Create a Route table called Routing-Server.
                Choose VPC
                public--->public
                and in the route allow 0.0.0.0/0 IGW to connect.
                then in subnet-associations connect.
                private--->private (here need not of any IGW to connect)

     Step5:   (EC2-Instance)
                Create two instances named:
                1.Public-Ec2 -->Attach VPC & Public subnet to Public Ec2 & Allow 80 port everywhere.
                2.Private-Ec2 -->Attach VPC & Private subnet to Private Ec2 and ssh port should be custom 10.0.0.0/16 as to get                               access all within that  vpc
                3. Then MobaXterm to connect the server.
                4. Access the server and install httpd.
                5. in the path var/www/html. 
                6. vi index.html(write some content).
                7. chown 400 shashikey.pem
                8. Connect the private server using ssh.

      Step6:
                if Private-Subnets wants to connect internet in that case:
                 we use NAT Gateway for secure purpose
                * Create a NAT Gateway and select public and attach elastic IP .
                * Go back to the private routing table, allow 0.0.0.0/0, and attach the NAT gateway.


VPC Peering:
                The connection between two Vpc's is called VPC Peering.

                * The rules of Vpc Peering:
                          * You can connect the peering to the same region.
                          * You can peer one region to another region.
                          * You can peer from one account to another account.


             Same steps as above but peering should be created:
      
      Step1:  (VPC)
                Create a VPC1:
                10.0.0.0/16
                Create VPC2:
                20.0.0.0/16
                enable domain hostname for both VPC.  

      Step2:   (Subnets) 
                Create two subnets named First-Subnet and Second-Subnet:
                First-Subnet---> 10.0.0.0/16 ---->It means it allocated 255 ips 
                Second-Subnet---> 20.0.0.0/16
                Enable auto-assign public IPv4 addresses for both subnets.

      Step3:   (IGW -->Internet Gateway):          
                Create two IGWs named First IGW and Second IGW.
                It is used to connect to the first-->First-VPC and Second-->Second-Vpc
                & attach to the VPC.

      Step4:   (Route Table)
                Create a Route table called Routing-Server.
                Choose VPC
                first
                and in the route allow 0.0.0.0/0 IGW to connect first-subnet.
                then for second subnet as well.
      Step5:
                Create a Vpc-Peering two VPCS first to second.
                then accept the request.
      Step6:
                Then go to the Route table gives an alternate to connect the peer:
                for  first-routing connect--->20.0.0.0/16 the next box choose peering and connect.
                For second-routing connect--->10.0.0.0/16 the next box choose peering and connect
                
     Step7:   (EC2-Instance)
                Create two instances named:
                1.first-Ec2 -->Attach VPC & first subnet to first Ec2.
                2.Second-Ec2 -->Attach VPC & first subnet to Second Ec2
                3. Then MobaXterm to connect the server.
                4. chown 400 shashikey.pem
                5. Connect the private server using ssh.
VPC connection between two regions:
  Step1:  (VPC)
            Create a VPC1 in the Mumbai region:
            10.0.0.0/16
            Create VPC2 the Tokyo region :
            20.0.0.0/16
            enable domain hostname for both VPCs.  

  Step2:   (Subnets) 
            Create subnet named First-Subnet in the Mumbai Vpc region and Second-Subnet in the Tokyo Vpc region:
            First-Subnet---> 10.0.0.0/16 ---->It means it allocated 255 ips 
            Second-Subnet---> 20.0.0.0/16
            Enable auto-assign public IPv4 addresses for both subnets.

  Step3:   (IGW -->Internet Gateway):          
            Create two IGWs named First IGW in the Mumbai Vpc region and Second IGW Tokyo Vpc region.
            It is used to connect to the first-->First-VPC and Second-->Second-Vpc
            & attach to the VPC.

  Step4:   (Route Table)
            Create a Route table called Routing-Server.
            Choose VPC  in the Mumbai Vpc region and Second-Route in Tokyo Vpc region.
            and in the route allow 0.0.0.0/0 IGW to connect first-subnet.
            then for second subnet as well. 
  Step5:
            Create a peering connection from Mumbai to the Tokyo region.
                First step choose Mumbai in peering to different region selections and then select Tokyo region.
                Connection accepts in the second region.
                Connect alternatives to each other in the route table.
 Step6:
      Create instances in each region using their own Vpc's.
                then connect it using ssh.
Vpc Endpoint:
            Vpc Endpoints enable private connections between your Vpc and supported AWS services.

            Types of Endpoints:
            1. Interface Endpoints---->It supports 86 services.
            2. Gateway Endpoints----->It supports only s3 & Dynamo DB.
            3. Gateway Load Balancer.
Vpc Endpoint Hands-on:
            Step1:  (VPC)
  
                      Create a VPC:
                      10.0.0.0/16
                      enable domain hostname

             Step2:   (Subnets) 
  
                      Create two subnets named Public-Subnet and Private-Subnet:
                      Public-Subnet---> 10.0.0.0/16 ---->It means it allocated 255 ips 
                      Private-Subnet--> 10.0.1.0/16
                      Enable auto-assign public IPv4 addresses for both subnets.

            Step3:   (IGW -->Internet Gateway):   

                      It is used to connect to the internet using IGW.
                      & attach to the VPC.

            Step4:   (Route Table)

                      Create a Route table called Routing-Server.
                      Choose VPC
                      public--->public
                      and in the route allow 0.0.0.0/0 IGW to connect.
                      then in subnet-associations connect.
                      private--->private (here need not of any IGW to connect)

             Step5:   (EC2-Instance)

                      Create two instances named:
                      1.Public-Ec2 -->Attach VPC & Public subnet to Public Ec2 & Allow 80 port everywhere.
                      2.Private-Ec2 -->Attach VPC & Private subnet to Private Ec2 and ssh port should be custom 10.0.0.0/16 as                                   to get access all within that  vpc
                      3. Then MobaXterm to connect the server.

            Step6:   Then create an IAM role:

                      1. Create an IAM Role.
                      2. select ec2 below & click next
                      3. Create a policy and select AmazonS3FullAccess & click next.
                      4. Give role name as s3role & click create the role.

            Step7:    Then create an endpoint:

                      1. Go to the Vpc section and create a endpoint name as s3-endpoint.
                      2. below choose com.amazonaws.ap-south-2.s3 service as interface one.
                      3. Then choose vpc and private subnet to which you want to connect.
                      4. Then select default security group and click create endpoint.
                      5. Then go to ec2-instance click and go to actions security and click on modify iam role and select the                                      iam role u created.
                      6. Then write the command 
                         aws s3 ls --endpoint-url https://bucket.vpce-019d6908cb4472d22-c5jwui77.s3.ap-south-                                                     2.vpce.amazonaws.com --region ap-south-2  (careful with the role which u choose for the ec2-user to                                     avoid a errors ..
DevOps-/AWS/AWS-Vpc/Aws Basic.MD at main · shashikumar04433/DevOps- · GitHub
