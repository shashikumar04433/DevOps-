## Configuration of Apache with Liferay Tomcat in Windows:
**Steps**

```
Step1:
Install Liferay bundle with Tomcat.

<https://learn.liferay.com/w/dxp/installation-and-upgrades/reference/liferay-home>

Step2:
Install Apache and configure in the windows:
<https://httpd.apache.org/docs/2.4/en/platform/windows.html>

Step3:
Go to this folder
C:\Users\shashi.reddy\Downloads\Apache24\Apache24\conf
Change this 
Define SRVROOT "c:/Apache24"
ServerRoot "C:/Users/shashi.reddy/Downloads/Apache24/Apache24"

Step4:
To do a reverse proxy:

<Directory "C:/Users/shashi.reddy/Downloads/Apache24/Apache24/htdocs">
    Options Indexes FollowSymLinks
    AllowOverride None
    Require all granted
</Directory>

# Basic settings
<IfModule dir_module>
    DirectoryIndex index.html
</IfModule>


# Proxy settings for Tomcat and Liferay

Step5:
ProxyRequests Off
ProxyPreserveHost On
<Proxy *>
    Require all granted
</Proxy>
ProxyPass / http://localhost:8080/
ProxyPassReverse / http://localhost:8080/

Step6:
Replace this in server.xml

<Connector port="8080" protocol="HTTP/1.1"
           connectionTimeout="20000"
           redirectPort="8443"
           proxyPort="80"
           scheme="http" />
Step7:
Restart tomcat and then restart Apache
