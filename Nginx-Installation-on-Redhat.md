# Nginx
## OverView
        
          * What is Nginx?
                   Nginx is a open source software for web serving, reverse proxying, caching, load balancing, media streaming, and more.
                   It started out as a web server designed for maximum performance and stability. In addition to its HTTP server                              capabilities,NGINX can also function as a proxy server for email (IMAP, POP3, and SMTP) and a reverse proxy and load                        balancer for HTTP, TCP, and UDP servers.
                  
         
         * What are the uses of Nginx?
                    Nginx is a web server that can also be used as Reverse Proxy ,Load Balancer, Mail Proxy, and Http cache.
             
          * Working of Nginx:
                     Nginx works as Gateway 
                     Example: It works as loadbalancer.

           * UseCase:
                     Only Software tested that was capable of repliably handling over 10,100 requests per second.
                    
## Installation of Nginx on Redhat:
                     
                     * Yum install Nginx

## Connecting the nginx to apache tomcat:
                
                cd /etc/nignx
                vim nginx.conf
              
                then comment 404 all that files
                        server {
                    listen 80;
                    server_name 18.216.96.3;(tomcat public id)
                    location / {
                        proxy_pass http://18.216.96.3:8080/;((tomcat public link)
                         }
                         }
                 then save & systemctl start nginx
        
