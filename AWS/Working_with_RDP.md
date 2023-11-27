## Steps to allocate two public ips and two private ips using elastic Ips:

  1. Launch a instance and save the .pem .
  
  2. Connect the rdp using windows+R (mstsc)
  
  3. Login with other user and add administator <username>
 
  4. For password connect in aws and upload .pem file and get password to login into rdp.
 
  5. Then goto search bar in the server and search service manager & then click on add & configuration in the upper right.
  
  6. And Add IIS and install it.
 
  7. Then add the html file in localC/inetpub/wwwroot
  
  8. Create index.html to show your content.
  
  9. Then goto binding and add the ip & attach with the port.

  10. Then create a elastic ips ofr creating two different public ips and two private ips .
  
  11. Remember there should be two network interfaces for that (imp).
  
  12. Then create a target group and load balancer and attch the 3389 port .
  
  13. A very imp step after doing this connect with dns name of load balancer <mylb-83e26b924f238e5f.elb.us-east-1.amazonaws.com>  and then add .\ <infornt of username> to avoid the conflicts.
