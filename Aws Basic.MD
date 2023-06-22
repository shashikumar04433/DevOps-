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


### VPC Peering:
                    The connection between two Vpc's called VPC Peering.

                    * The rules of Vpc Peering:
                              * You can connect the peering to the same region.
                              * You can peer one region to another region.
                              * You can peer from one account to another account.

          

       -----BEGIN RSA PRIVATE KEY-----
MIIEpAIBAAKCAQEAsoWcLexq603fK5v9VlAwBNXFzD7TJf1hPWjeDDoJdHTYvt6e
FbrnzH888IvY6lwwJcu8s1kzNvptUwBBbUU6dnel1Ye+k7pbzfV1duSoNl/JHrSo
xf2NrG3ww61qXiakVN0JasK1lNPtx0e9eoVs0fy4zHflslCt/dVlnkhN1zeZO3Kv
Cy6+23s5kyU4epdZIwen+VAj1De2yYR5kNl1OtcByeEog1ALyhKBwy+mnLD6xrRa
+ELzV0fiXHvNluQ6nvh/znz1ZR2goF+1e9ce1h9JZndMCue0v+gVHMYhH7THX5pn
+URvQTLFwQAJKmrh69+DAtKmIhMoPw+06kvXSwIDAQABAoIBAGu02MmMPeXBkcfJ
0UrmDlKcdz4HGXVuLeDTCETwLwwoAy0FOvN5VKi4i5fFiBW9kP78sNi0FIYzCQpu
uQqoHeGjxlXSFFUktobIdRpKUoKbv8faz4jEtVk262/jjK1JOxRIV4ol90/XnToC
OntVTJZUl1olbFvs+UyQF0Mr9GrHhy9t9RKhvRr1nND8wIAxd0f2uhY9+X3wrvto
xwKo1OUN4oiZ3EsirWPs9MZbAjKJdHDmM1dpqHoPhUhpe/uEHZNovoCY9Pa/jXO7
65KPxe0t9fohHwXjsQeyP2z3oSQYPlTOHQJoyFmbIAY6RN3y0kd1UJQbUS0LXyaX
FHlQwiECgYEA+7OQkKsg5cHoTdjjKgG5haM4tr2JJ0AojEL9VpZA9x8TADpp6Y4n
tVZz8Ohc16BsEsIC/okYbkVgKknxzVbn2hHaBnyLuM+mjbKUEkXqd9Vu0wABgprI
sJd3FWekPOeufSAbokzKjXkHplcy3p23yKJ+E5/K+Sp3lKu20xOi2t0CgYEAtZIb
A07kO2Cr9yhW66jKZ/z1pXNAAkbEG7YajqpqwotQw3D7RGpnV/0Yg6AdUCC8TUob
l6bxi5kXgTikiy9vvrFjCfoF0LioLMePtucfH8IRsDrAGy2L0euPbzqJx6fDxMos
2HjgQ5vBz8TKolNdJHWxxRl0dtABo3bRujz5dEcCgYEA9vJe9MEhPqp3q+EOR0l3
5riUTR46MUtOPQcAnXI/fPV84+1rulzhcpXGnOatKFVZkzHMVETXtmDUj8kKtub8
BMUc/t41C3aXt1As3JzCBR5fZB8OXEBWhIOmr1aHGcZJOLRGyH7E//Zt3fKRkz50
cSGTxtcxAjN7LV8nuYH7dvUCgYEAltwSPalq0Dr+JpkJvzu7ELOIljMv17RcdHnV
jvvhQEroi7pvyuRtgRn1KEf8kvrf+Ye9bT90KfzFHsSlUk/TlKlmFH/8HPOQJ8SX
j+xwW76vW7E0tGAfcAc8YbpNh+nIKtWgdSvZidL8MVjc1ApXtVdkoNMJhT5GXj72
+rp2uTkCgYAds6od0YaNli0LRzUVtPXAKcouL1l8JlMRMPZcuvtnU6DzSkjBOlc2
VXZiL4FSI9GQtHswHJLl+d+Z2jBmTbR3mLldwtEwTohzL+VSod/0yJzdYmAWGwNu
w2gAAmFHLOysRuXQipq0bHs2FSvD1VTZUfyN5WR2zdAF7Uk3rV5cHA==
-----END RSA PRIVATE KEY-----
-----BEGIN RSA PRIVATE KEY-----
MIIEpQIBAAKCAQEApjvteu1lxtRoAFZ6MQVdw7mhDyeCvljelUwZIYdJPRQyc0+8
0wfxaPGC5+X+Vc3W4AIY0+49rJ3wXQgcVfLUGuILCxt9/qHpXf0YjqV4PAcRX+hv
G4Zn3J4nf3GdX//kU8qMC3Y67znU81VVprXcwRjHb7FcTC62pwULnYjnyhtxaeiE
5vJ3E/oUJuSsIMar+Xh+JklqI74OCQZLBwvzCD+AZnea2m3/RkUMKgU8Kbyz/W0C
hf0muraij8eMzPn2wEQaSi9BopzS2Le8SiH6wZBbHb+T1Kguzugi/0doCoj4eGSc
iYyTEAgH3diEzULr3LP5OGys3me5sr3eF0sxGwIDAQABAoIBAFBJn3CA2mhGzJhl
LA0jH19Z960fEymmOJL5NyYXdksWxyskdvmh23opM2WXktiUW1TEDoPFjGojuiTk
tvLYHpOBW34Y4CiswM7RYBv9VW4Ap+afl5I+v0kx5bfLAwyLxhamPC+JAfvq/awt
Kfoj2iQ1OJX8nqx432UZrbt/lRvqi8TO56InDpVMaozkGQNtK5a7wbFPs1yuiUVh
H/1IRW2lfbyN3ELrd3TGJuJUjslKnPys+AVPuu5IJY2I74QjjRPbeJz0v8Wn53vP
5iKIikPoQ0pwJIkkWWs/i64KSjpc9CI5t4x4zQIOwdiLZ/YsBmyNeHlSd/mgJmhL
mqr3oVECgYEA/VvRFUEJUxjs/G6CHTiCJZiYL4OXfFyKCHGkUEJO4LgvjN8plsGi
zp2w2WTSBl4oMYebG/RjwKtNswlo6VmUa24DQkHV9wOyJhLeMvlqT2YKeKeCCPVy
Z3KZXXlrDpLUA1KhdxgwY8+cuIsIpxpbXl3RTwnNtJoZ5XwbNDK2coMCgYEAp/eW
C6a65a+yspjk8ux0o3ZrRlIhWP5i7DyxMAGtYjxvIeD34BmrXKdWKQuE3ub2OyYN
IR0EW0d5JQ1G0++ZU/lO8/8V3+Z4oQxITlQFFiLEbuxj3suyBHl45JVAeyv/FeCC
LflLm+coOSDeTnonOO0MgJKTzFugwHvh2FYAI4kCgYEA6wjLXPk5akI8Ty1BPVRX
wALgY2ujE3ZRguXRtbbdr7CORBQeY8F8hEpbbkEOaWPdy5zuMq+z/l+sNAPttFQq
0MJ8+XFTydQ+5v0n7ofcrI2P90AF7MOt/vOb/NAPlbR2RCLasT3aXi2SSMyKGWLl
EhTcgIMqtnkivvYz0medQ3sCgYEAlIeivoDcqrl4mugLJSmlZtsTt6Zu6MRi86Yj
xWDmUoVAfMP0Tc5FM3SiAz+1amrweJOIbqy7KoCEhxg7drRccN54S9lZHZovN7Kl
yeYQbWenLrOJCP41WDGWjwPQdlsMger7Eu5tRtrdPc9r5hes0XEFajizy7WG7E9g
Ai7ihokCgYEAmMcpot/BlJvzxd36L+z5asDHZUyi55qWDQ9ndIJdlHIv9FHc+q9I
urfcEvehYwz6WjR1vKdi/PKgW1cD+6gcMay9PoE6VNWNIrvG2nOHSY/V7N+EM1Td
zyX5r2OPSOcAVqDU12ejkowC7PW/VemmxWHqxydMeG3M7vl6/J8FZjk=
-----END RSA PRIVATE KEY-----
-----BEGIN RSA PRIVATE KEY-----
MIIEogIBAAKCAQEApOokhjiuPP7/UPedoDdb5WYzOcERY4ngnyIrP5KdB3olkcmi
CrmXbm46VSVCys7N6usARHPi7eC98bQcyMWoFaX6ta38OiOm789YYnStGIFnku+x
+0xha3EnrICqkq1ECPsX8BlHRHS7Zb7Larf1UCu1Gl/FKXeQb1w9j34D7YDEcP2u
fFxg3/hX4X6YhTSONDvDYVF6s4eMSurV9FsGbnt9c1Q/VSnRSroQlUdmU3egW65K
DMZCx7BctnWCuipR+VqVVjDjR2TIH/sDS3/TTtutuEZVfActPhhSezuMZmRzmoxI
hp4BBWbYOZ3cWDeVeAeywONdKovmmaYZql3PuwIDAQABAoIBAAniXr4Mt6TAQ90+
ehwYNVHShk932ur0YJopGh59UxwXnhjW1Pd/mCvuP2DLEu3E52KlIyb3KyrGxZuv
B+qgripeAGDTRMLXUDIfY1TDWXyWhPaxlyFQuqYN6irUq2SPLfy7z/t8CGF5/aFj
hh2nWPStKfWit9Z8bBPAm4/2JZYegOExdaKY4fxdZOhbFPKvQwl6S+gwtTbqCH83
MyZUffHZl+imGmci0mzTtPG3d2lvlwWoOyQ/Cq1QWg6eARdTcutL8gz3MS5oiAye
OCpO3kZaNxLPyseA26WKhVphwsdHzo7/tBJd/tzBOJgO0nt0pytO4mczgzFkqlFI
fvKUTcECgYEA5P4fa1U4cVIkwd6569csso9wYM5j8mWSjQcI1T+x4hIQBjiwUcfF
aALRPKHttDkobd0bf3k2YJvltpulTbnydVa78wo+sKZmNWkXnraJLZc43wmS5fbL
csbCoC212W0IK6X/EJ6PlALsRKe9ucTsapdBsqt4hNFV657dOWIiV70CgYEAuF1W
x1H9k3LBQSv1Vsv/JJbkD4L8TOQqN35MNgxG19NTXg5zwvqK5FnCIUiR7oZNFPR0
f7oAkqL9yRrPLusRIg+pwYU3qak5lxI+UtIHSy1v4R/qVoo1ybDOeBwMZsi0A7tQ
BCeH1BCM/2nEVgtEvWPEldiNGbknqUGCeV5woNcCgYBmIemFh7bq5AY86cfmpkvr
QAqRQrxVKnRYriCEbCo8eG3pOHN7piwnncoQzvAkB7I+ffV7v2Y/ZIjqDzWFG0BG
kW62kYUwaKcBf2Pnh+ZbDS1yXOTF6HMJOBkqM/j9hqG0Rg8jLHVBQKR8Yow+RNRl
Hh1RQSU5p9w4gNyOcXR7yQKBgHRFETxE3gnGXlBum5wwrOjzbELIFbucTW+P7BpN
5cOpF7OCo8j8XumiHccF0FrAQg6MGIiQ0lmoByt0B+OMBdMYU7OjAzaxbYtzyvBK
WqUzs5IjoZMQONnI8n1XGw8bVkPgNpdYItY/1dwiZNrq4mAaclkaJ+poFbYthU5r
m9YjAoGAXbCyP0pBtn3RRF8ytmIOgoz4UKAvvJCnG93jJo0W8+A4V2XtDbZqTM/G
sbtg+W4O6yxHUvaXjPnkF+vY/ttZNjSy4IFH7cCUl/TXLjlwph7+Oexbf6e/PLbK
Dpz/fvVY4zRHfKPqFk6cJIm1TfB/BUJ1HgJi0KzvJ+9wxkO3zaQ=
-----END RSA PRIVATE KEY-----
-----BEGIN RSA PRIVATE KEY-----
MIIEpAIBAAKCAQEAioovKXEgs2sTJeDjLxNjSujh18Gh9RjEaBo5tVz4KuIg6c5w
Ld3IyzRHHvKdigyH8DT5CqJ8/QlvmqNg/jZvO71Rkhvyr2ARISgLOY3qtScougwR
9Q/OGoN5j0fDd6Kl8O12PyhpXhZDdSOPl3GcMBeU/0sGGAK8Gd2g5PFQTEPiY1rm
wp3hV++iXg8JTuAs04f6oHgOJ+aUwCKlvmH3nzkB69bjNdjaguFxlajW4coRcu6R
eGVBAstxvb43Ry+lQKZPMfqL7ED19Ugyn6xGa6Wl61MV2F5TcAxBaIynM900t2Rd
0hCknoWUWM1jrg833CPXwjxmdO440qsooNui/wIDAQABAoIBAQCKNcNJH8AU3lxy
7IEZBMmJAP3WBimx36yJgqhRw9ccyQ0206lcSKc5+gR93mLGRywSunY9Ys84jQJX
DmkEE4Ay4/MNxW3+AeP05QMVvvwJD3D08nezuLnP/5v1Eg3yO0Q7MFtINOOxZpqT
sQ9ecYv0+oG9krYYnBnV4CHUZN3LxnCuG9m96IrEkBdxFt0b+++43lAiN23R0W9N
vfqRcnXdM+YUaWddHFX7Vw45X8WsegE+klQUE4jg5R+WWGnAkZ/g6HZFrK7iDyXJ
05JPRAXvOV1eyYw3R5fpeCNFxfZ7qtA2fwkEYnFgiyUWPoTLv8X7x7T2QTDFN/45
cvFDVkthAoGBAMsZzgHMiVogeWrmNJHzX2r0PYkzwwS2z2X87nyqgd7jRnjrex8K
49iUjJh6ElXZbrK0UWekxqlET+ZNBCtmrjmveSw7SHBKpwfC/sb+t2xSEmRho7+t
l9qxs2ORHS+NpAUVnMAhkRok3t8v3S3uavLgTk/a53khL/B1VPG7xT6PAoGBAK6f
oXuTg5DFJCPEvrdbZ6b3MeGNEREgfyGUC1MK25u0lVBGs9+9ItCSxV+solQk7f3M
VuaiiEJETJCDVE8uRiE4oS8L3/nYZxSPioXpCCiW2c6o+l2XcXUUELdqQiDxGDjL
BFXwouohlNy5gSJ0sVInQSFPQLINcfS1PkWvw4yRAoGBALZ3rYQiPXgyWsM2pR5G
93/AhJSCY4AVuYkYTy7DhUA5EjRK42eFQiRveUz3xwdH/FMi+0vRVwX1sI7ovIk9
i+OZiZS6gh8Ygq3Pe1ROvX3c0ldK/XGUxSweoFsgoYb6itRikVxwC8vgOjdr6ht8
6qrf6JuHwJQrw8UVtMYk+1VzAoGALzWs/LHW4e7KZHkubnfhv/wYmjf/Izg75qIV
pa/Ly36412kl/BkwLl9fyQvtHv6U8Qarf9L1L6UzZeZ7hqSmBRlASm3VccCVrbNY
6fckY4TVAdAhT+g/nj18f3nUwv8rYz9PvsQ95zqI+luUk/IkdmdybkT04q5L3rKZ
UVHBdmECgYAFWZI+p2vMJQdRKukqANG4O/TJLd8K6JhW7L55xc5AyoEGDfJIf74j
0mPvHlJoYTomlPQOpajoMOupvgK1VrOt6Z8JeiGO4QyWnPwz/Ee8mnSrzZ3FBgpz
PmEte2KQGlub4cMklUv8YPVG/16HOAFihHo5EH5BBQxe663iDiBSjg==
-----END RSA PRIVATE KEY-----             
          
                    
                    
                    
          
          
          
                    
                      
                    
                      

                     
                      

          
                       
                      
                      

                    
                              
  
            
                
                
                
               
              
           
   
            
        
       
