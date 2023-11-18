# Docker 

## Docker Installation in Ubuntu: 
      sudo apt-get update
      sudo apt-get install docker.io


## Docker Commands:

      attach      Attach local standard input, output, and error streams to a running container.
      
      commit      Create a new image from a container's changes.
      
 
      cp          Copy files/folders between a container and the local filesystem
      
      create      Create a new container
      
      diff        Inspect changes to files or directories on a container's filesystem
      
      exec        Run a command in a running container
      
      export      Export a container's filesystem as a tar archive
      
      inspect     Display detailed information on one or more containers
      
       kill        Kill one or more running containers
       
      logs        Fetch the logs of a container
      
      ls          List containers
      
      pause       Pause all processes within one or more containers
  
      port        List port mappings or a specific mapping for the container
  
      prune       Remove all stopped containers
  
      rename      Rename a container
  
      restart     Restart one or more containers
  
      rm          Remove one or more containers
      
      run         Run a command in a new container
      
      start       Start one or more stopped containers
      
      stats       Display a live stream of container(s) resource usage statistics
      
      stop        Stop one or more running containers
      
      top         Display the running processes of a container
      
     unpause     Unpause all processes within one or more containers
     
     update      Update configuration of one or more containers
     
     wait        Block until one or more containers stop, then print their exit codes
     
 ## Docker Commands Example:
 
 ### Command to check the version:
             docker --version
                  
 ### Command to check the Docker Images:
             sudo Docker Images
                  
 ### Command to run the docker:
            sudo docker run -it -d Ubuntu(where d is demon and it is itteractive)
            
 ### Command to display docker which started:
            sudo docker ps
      
             
 ### Command to display docker stopped one:
             sudo docker ps -a
        
 ### Command to Login/Accessing the Docker:
            sudo Docker exec -it -d <id docker>bash
            
 ### Command to Stop running Container:
            sudo docker stop <id of docker>
 ### Command to kill the docker:
            sudo docker kill <id of docker>
 ### Command to remove stopped container:
            sudo docker rm <id of docker>
 ### Command to see the imaages in docker:
            sudo docker images
 ### Command to delete the image in docker:
            sudo docker rmi<img id>
 ### Command to delete all containers at once:
            c docker rm -f $(sudo docker ps -a -q)
            
## Steps To Install Apache in Docker:

            1. sudo docker run -it -d ubuntu.
            2. sudo docker exec -it  <name of ubantu id after first cmd execution >bash.
            3. sudo apt-get update.
            4. sudo apt-get install apache2.
            5. sudo service apache2 status.
            6. sudo service apache2 start.
            7. sudo service apache2 status.
            8. sudo docker commit <container id of img> username/<anyname as u wish>.
            9. sudo docker images.
            10.sudo docker run -it -p 82:80 -d username/<same name as u have given on 8 cmd>.
            11.sudo docker ps
            12.sudo docker exec -it <id of the name which created>bash.
            13.service apache2 start.
            
## To show the Html page on Web using Docker.
            Steps:
            1. Mkdir <Dir name>.
            2. CD <that Dir>
            3. Vi Dockerfile (Wirte this below cmds in that).
                  FromFROM ubuntu
                  RUN apt-get update
                  RUN apt-get -y install apache
                  ADD . /var/www/html
                  ENTRYPOINT apachectl -D FOREGROUND
                  ENV NameisShashi Protivit
            
            4. Vi 1.html
                  write helloworld program.
            5.Build the docker file use following cmd:
                  Sudo docker build . -t new_dockerfile.
            6.Docker ps.
            7.Sudo docker run -it -p 70:80 -d new_dockerfile.
            8.Then check server ip :port/1.html.
            9.sudo docker exec -it <id>bash.
            10.cd var/www/html.
            11.Echo $name.
  
## Maven Installation:
     * First Install java:
            Sudo yum install java-1.8.0-openjdk-devel
            Sudo yum installed |grep "java"
            cd /opt
     * Maven Installation:
            Sudo Yum install wget
            Sudo wget https://dlcdn.apache.org/maven/maven-3/3.9.1/binaries/apache-maven-3.9.1-bin.tar.gz
            ls
            cd /opt
            sudo tar zxf apache-maven-3.9.1-bin.tar.gz tar.gz
            ls
            cd apache-maven-3.9.1/bin
            export path=$path:/opt/apache-maven-3.9.1 bin
            ls
            mvn --version

      
## Puppet Installation & Setting Up Puppet Master-Slave on AWS:
      * Setup on Master Server:
            sudo apt-get update
            sudo apt-get install wget
            sudo wget https://apt.puppetlabs.com/puppet-release-bionic.deb
            sudo dpkg -i puppet-release-bionic.deb
            sudo apt-get install puppet-master
            sudo apt policy puppet-master
            sudo systemctl status puppet-master.service
            sudo vim /etc/default/puppet-master
            JAVA-ARGS="-Xms512m-Xmx512m"
            sudo systemctl restart puppet-master.service
            sudo cfw allow 8140/tcp
      * Setup on Slave Server:
            All this mentioned in the above file which is in the Puppet Installation.
        
## Jenkins Installation Steps:
            step1: Install Java, Git, Maven, Jenkins. 
            step2: https://pkg.jenkins.io/debian-stable/ follow that commands.
            step3: IP:8080 in the browser & Then follow CAT the given path.
            step: Paste the Key in Password.
            
     
## To work on Websites with HTML to show in Server:
            1) create a New Item choose freestyle project.
            2) Attach the Github link to work on it in that.
            3) then come to the server & cd/var/lib/jenkins/workspace.
            4) cd var/www/html.
            5) mv the github file to index.html.
            6) 16.16.124.242  in chrome.
            
 
## Jenkins Pipeline Synatx:
            Jenkinsfile (Declarative Pipeline)
             pipeline {
                  agent any (1)
                   stages {
                        stage('Build') { (2)
                          steps {(3)
                                 // 
                         }
                      }
                        stage('Test') { (4)
                          steps {(5)
                                  // 
                              }
                           }
                     stage('Deploy') { (6)
                          steps {
                                     // (7)
                           }
                         }
                   }
                 }
                 Below steps are the explanation of the above numbers:
                 
                   1) Execute this Pipeline or any of its stages, on any available agent.
                   2) Defines the "Build" stage.
                   3) Perform some steps related to the "Build" stage.
                   4) Defines the "Test" stage.
                   5) Perform some steps related to the "Test" stage.
                   6) Defines the "Deploy" stage.
                   7) Perform some steps related to the "Deploy" stage.
                   
                   
 ## Jenkins Pipeline Example:
                        
                            pipeline{
                               agent any
                                     stages{
                                          stage("clone repo and clean"){
                                                 steps{
                                                       sh "git clone https://github.com/shashikumar04433/my-app.git"
                                                       sh "mvn clean -f my-app"
                                                      }
                                                     }
                                          stage("test"){
                                                 steps{
                                                        sh "mvn test -f my-app"
                                                      }
                                                   }
                                          stage("Deploy"){
                                                steps{
                                                         sh "mvn package -f my-app"
                                                      }
                                                    }
                  
                                              }
                                          }
## Jenkins Pipeline link for Reference:
                  https://www.jenkins.io/doc/book/pipeline/
                  
## Managing and Assing Roles in Jenkins:
            step1:
                  Go to Configure Global Security  and Enable Security and Role based Strategy.
            step 2:
                  Role and Add --> Employee(Then give the permissions what ever you want).
 
                       
# KUBERNETES(K8s):
      * Containers are a good way to bundle and run your applications.
            In a Production Environment ,you need to manage the containers that run the applications and ensure that there is no downtime ,
            and thats where the kubernetes comes into picture.Its similar to Docker and added few features.
            
       * Kubernetes takes care of Scaling and Failover of your application and provides deployment patterns and more.
          
           Maintaing all the containers called Kubernetes.
           (Maintaining Workloads & Services using Kubernetes)
           Container:
                        -->App
                            |
                        -->Dependencies in Container
                         Out side Container
                         Container Engine 
                         OS(Kernal)
                         eg: Linux,Windows,Ubuntu.
                         
           *  Pods :Combo of Containers.
            
           * Replication Controller : Used in different kind of Docker use cases.
            
           * Storage Management : Storing and Delivering Containers.
            
                   
           *  Kube Ctl:
                        It will connect to Master to API Server.
           * ETDC(DataBase):
                        It is used to store the  Key & Value Pair .
           * Schedules:
                        It schedules when the Kubernetes and Containers down and make it to scale up.
                        
## Kubernetes Feature:

                  * Installation of Kubernetes steps mentioned above in the word file please go though that .
### Features of Kubernetes:

                  * Service Discovery and Load Balancing.
                  * Storage Orchestration(multiple servers use)
                  * Automated rollouts & rollbacks.
                  * Automatic Bin Packing.
                  * Self Healing.
                  * Secret & Configuration Management.
                  
### Kubernetes Architecture:
                  1. Etcd.
                  2. Api Server.
                  3. Kube-Conroller-Manager.
                  4. Scheduler.
                  5. Cloud-Controller-Manager.
   
   
  # Apache-Tomcat:
            Tomcat types:
                  1. Manager Application.
                  2. Host Manager Application.
            Task:
                  Create a two tomcats with different port one with the 8080 and 9090 then configure with the apache2.
                  
                Installation and Apache Configuration with Tomcat:
            step 1:

                  yum install wget,httpd,java-11-openjdk-devel -y
                  service httpd start
                  service httpd status

            step2:
                  wget https://dlcdn.apache.org/tomcat/tomcat-9/v9.0.75/bin/apache-tomcat-9.0.75.tar.gz
                  tar -xvf apache-tomcat-9.0.75.tar.gz
                  cp -pr apache-tomcat-9.0.75 tomcat1
                  cp -pr apache-tomcat-9.0.75 tomcat2
                  https://crunchify.com/how-to-run-multiple-tomcat-instances-on-one-server/

            step3:
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

            * service httpd restart
            * To change the content in Ui tomcat1:
		 Webapps>root>index.js.
   		
		 
			
			 
                  
            
                        
            
