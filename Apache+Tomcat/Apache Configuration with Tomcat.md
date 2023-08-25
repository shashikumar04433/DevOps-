## Installation and Apache Configuration with Tomcat:

		step 1:
		
		yum install wget,httpd,java-11-openjdk-devel -y
		service httpd start
		service httpd status
		
		step2:
		wget https://dlcdn.apache.org/tomcat/tomcat-9/v9.0.75/bin/apache-tomcat-9.0.75.tar.gz
		tar -xvf apache-tomcat-9.0.75.tar.gz
		cp -pr apache-tomcat-9.0.75 tomcat1
		cp -pr apache-tomcat-9.0.75 tomcat2
			       remove the context in the context.xml file on webapps META-INF on four repos such as 
			       (docs host-manager  manager  ROOT go each repo and inside META-INF remove the two lines
		    		<Valve className="org.apache.catalina.valves.RemoteAddrValve"
		         	allow="127\.\d+\.\d+\.\d+|::1|0:0:0:0:0:0:0:1" /> )
		
		https://crunchify.com/how-to-run-multiple-tomcat-instances-on-one-server/
		
		
		step3:
		Add the below content in the tomcat-user.xml
		<role rolename="manager-gui"/>
		<role rolename="admin-gui"/>
		<role rolename="manager-script"/>
		<user username="admin" password="admin" roles="manager-gui, admin-gui"/>
		<user username="deployer" password="deployer" roles="manager-script"/>
		<user username="tomcat" password="s3cret" roles="manager-gui"/>
		
		Step4:
		sudo vi /etc/httpd/conf.d/proxy.conf
		<VirtualHost *:80>
		<Proxy balancer://mycluster>
		    BalancerMember http://13.233.80.182:9090/
		    BalancerMember http://13.233.80.182:8080/
		</Proxy>
		    ProxyPreserveHost On
		    ProxyPass / balancer://mycluster/
		    ProxyPassReverse / balancer://mycluster/
		</VirtualHost>
		
		service httpd restart
		
		
		 change the name in Ui tomcat1 ----
				|
				|------Webapps
					-root
					index.js
					


### Installation of Jenkins on Redhat:
		sudo wget -O /etc/yum.repos.d/jenkins.repo https://pkg.jenkins.io/redhat-stable/jenkins.repo
		sudo rpm --import https://pkg.jenkins.io/redhat-stable/jenkins.io-2023.key
  		yum install fontconfig java-11-openjdk
		yum install jenkins
 		systemctl status jenkins
  		systemctl enable jenkins




































