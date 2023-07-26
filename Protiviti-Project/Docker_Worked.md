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
            
            
  

