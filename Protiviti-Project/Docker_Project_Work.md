# Docker Image commands worked.

      Step1:
            Dockerfile:
                  FROM nginx
                  RUN echo "hello"

            
           git pull myapp: latest
           docker build -t myapp .
           
           1 . docker run -d -it <docker img name> 
           
           2.  docker login
           
           3. docker tag myapp:latest shashikumar023/myapp:latest
           
           4 docker push shashikumar023/myapp:latest
           
           5. docker images

    Step2:
        Go to AWS and search for the ECS:
            * Then create a task in ECS with Fargate and attach the docker <ocker.io/shashikumar023/myapp:latest>image path to that in the container path.
            * Then create the cluster and under that in the below Tasks attach the run the task.
            * Then check the logs and also the cloud watch.


 ## When you creating the custom docker images with docker file commands need to use:
            
            docker login
            docker tag ef5b41ff4ae4 shashikumar023/protivititaskmanagement:latest
            docker push shashikumar023/protivititaskmanagement:latest

## To connect to sql rds server :
            "DefaultConnection": "Server=database-1.cvdr8z18g9n4.ap-southeast- 
            2.rds.amazonaws.com;Database=FCRA;UID=admin;PWD=vWQTWrETc1mJV5jbswer;"
            
            ---> where default connection=Domain name (endpoint below you can see in rds).
            ---> Database=Name of Database in sql.
            ---> UID= username of rds .
            ---> PWD= Password of the rds.
            ----> In the Dotnet project .json file you should give the details of the rds server and user and password.
                        
            
  

