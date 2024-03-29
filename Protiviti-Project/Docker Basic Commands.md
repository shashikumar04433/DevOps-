# Docker

  https://www.pluralsight.com/guides/create-docker-images-docker-hub 
  
  Docker image create and push to docker hub reference.
  
  ## Docker Installation in Ubuntu:
        Sudo apt-get update
        Sudo apt-get install docker.io
  
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
             Docker --version
                  
 ### Command to check the Docker Images:
             Sudo Docker Images
                  
 ### Command to run the docker:
            Sudo docker run -it -d Ubuntu(where d is demon and it is itteractive)
            
 ### Command to display docker which started:
            Sudo docker ps
      
             
 ### Command to display docker stopped one:
             Sudo docker ps -a
        
 ### Command to Login/Access the Docker:
            Sudo Docker exec -it -d <id docker>bash
            
 ### Command to Stop running Container:
            Sudo docker stop <id of docker>
 ### Command to kill the docker:
            Sudo docker kill <id of docker>
 ### Command to remove stopped container:
            Sudo docker rm <id of docker>
 ### Command to see the images in docker:
            Sudo docker images
 ### Command to delete the image in docker:
            Sudo docker rmi<img id>
 ### Command to delete all containers at once:
            docker rm -f $(docker ps -qa)
 ### Command to delete all the images at once:
            docker rmi -f $(docker images -aq)
            
            
## Steps To Install Apache in Docker:

            1. Sudo docker run -it -d ubuntu.
            2. Sudo docker exec -it  <name of ubuntu id after first cmd execution >bash.
            3. Sudo apt-get update.
            4. Sudo apt-get install apache2.
            5. Sudo service apache2 status.
            6. Sudo service apache2 start.
            7. Sudo service apache2 status.
            8. Sudo docker commit <container id of img> username/<anyname as u wish>.
            9. Sudo docker images.
            10.Sudo docker run -it -p 82:80 -d username/<same name as u have given on 8 cmd>.
            11.Sudo docker ps
            12.Sudo docker exec -it <id of the name which created>bash.
            13.Service apache2 start.
            
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

# Four basic Docker CLI comes into action:

              Docker export - Export a container’s filesystem as a tar archive.
              
              Docker import - Import the contents from a tarball to create a filesystem image.
              
              Docker save - Save one or more images to a tar archive (streamed to STDOUT by default).
              
              Docker load - Load an image from a tar archive or STDIN.


                Example :
                          Step1:
                                Docker pull nginx

                          Step2:
                                docker run -d -p 80:80 nginx

                          Step3:
                                docker ps -a

                          Step4:  
                                where below df2 is container first three letters
                                docker export df2 > nginx.tar

                          Step5:
                                docker import - mynginx < nginx.tar
                                You could upload the tar file on a web server(docker hub) and let your collaborator download it and use 
                                the import command on his Docker hub.

                          Step6:
                                docker save -o mynginx1.tar nginx

                          Step7:
                                docker rmi mynginx
                                and now try to load the image to get back that image.

                          Step8:
                                docker load < mynginx1.tar

# Installation of docker on RHEL:

                          Step1:
                                yum install docker

                          Step2:
                                docker --version

                          Step3:
                                systemctl status docker

                          Step4:
                                systemctl start docker

                          Step5:
                                systemctl enable docker

                          Step6:
                                Docker pull centos

                          Step7:
                                docker run -d -it centos /bin/bash

                          Step8:
                                docker push shashikumar023/centos
                                
                                


                          
                                
                          
                  

                 
