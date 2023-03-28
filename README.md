# Docker 


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
        
 ### Command to Login/Accessing the Docker:
            Sudo Docker exec -it -d <id docker>bash
            
 ### Command to Stop running Container:
            Sudo docker stop <id of docker>
 ### Command to kill the docker:
            Sudo docker kill <id of docker>
 ### Command to remove stopped container:
            Sudo docker rm <id of docker>
 ### Command to see the imaages in docker:
            Sudo docker images
 ### Command to delete the image in docker:
            Sudo docker rmi<ing id>
            
         
       
      
                 
     
                

  
