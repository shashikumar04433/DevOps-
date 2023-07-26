# Docker Image commands worked.

      Step1:
      
           docker build -t example_image.
           1 . docker run -it --name example_app example_image
           2.  docker login
           3.   docker tag example_image:latest shashikumar023/example_image:latest
           4.  docker push shashikumar023/example_image:latest
           5. docker images

    Step2:
        Go to AWS and search for the ECS:
            * Then create a task in ECS with Fargate and attach the docker image path to that in the container path.
            * Then create the cluster and under that in the below Tasks attach the run the task.
            * Then check the logs and also the cloud watch.
            
            
  

