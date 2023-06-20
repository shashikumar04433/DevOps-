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
          
 ### VPC Architecture:

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
                    and in the route allow 0.0.0.0/0 IGW to connect.
                    then in subnet-associations
                    connect
                    public--->public
                    private--->private
                    
                    
                    
          
          
          
                    
                      
                    
                      

                     
                      

          
                       
                      
                      

                    
                              
  
            
                
                
                
               
              
           
   
            
        
       
