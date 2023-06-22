## Aws Basics:

### Topics in VPC:
          1. IP Addressing.
          2. Subnets
          3. Routing in VPC.
          4. Network Access Control.
          5. Internet Connectivity.
          6. VPC Peering. 
          7. VPC Connection.
    
   ## Working on VPC:
   
          1. Create a VPC called as MANISH -10.1.0.0/16  --65000 IP's --Enable DNS Hostnames.
          
          2. Create Subnets for web,App and DB Servers . Enable auto Assign Ip:
          
                Web Servers -- 10.1.1.0/24 -->Server1
                App Servers -- 10.1.2.0/24 -->Server2
                DB Servers -- 10.1.3.0/24 -->Server3
                
          3. Create a internet gateway and attach it to VPC.
          
          4.Creating routing Table & Assign IGW(Internet Gate Way) & subnets to it.
          
          5.Create a Security Group (As Firewall) and allow traffic.
          
          6.Create a Keypair.
          
          7.Convert .pem file to .ppk using Putty ppk tool.
          
          8.Deploy a Instance(VM) and access using putty.
          
 ### VPC Practical Demo:

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
                    2.Private-Ec2 -->Attach VPC & Private subnet to Private Ec2 and ssh port should be custom 10.0.0.0/16 as to get                               access all within that  vpc.
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
![](https://i.stack.imgur.com/qTmrX.png)


### VPC Peering:
                    The connection between two Vpc's is called VPC Peering.

                    * The rules of Vpc Peering:
                              * You can connect the peering to the same region.
                              * You can peer one region to another region.
                              * You can peer from one account to another account.
![](https://disaster-recovery.workshop.aws/images/vpc-peering-diagram.png)

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
                    For second-routing connect--->20.0.0.0/16 the next box choose peering and connect
                    
         Step7:   (EC2-Instance)
                    Create two instances named:
                    1.first-Ec2 -->Attach VPC & first subnet to first Ec2.
                    2.Second-Ec2 -->Attach VPC & first subnet to Second Ec2
                    3. Then MobaXterm to connect the server.
                    4. chown 400 shashikey.pem
                    5. Connect the private server using ssh.
                              
                              
                    
          
                    
                    
                    
          
          
          
                    
                      
                    
                      

                     
                      

          
                       
                      
                      

                    
                              
  
            
                
                
                
               
              
           
   
            
        
       
