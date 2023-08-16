# FCRA PROJECT:
          Step1:
          Create an AWS user & Setting Permissions



          . Create an ECR Repository:
          
                * Go to the AWS Management Console.
                * Navigate to the Amazon ECR service.
                * Create a new repository for your Docker images.
                
          2. Authenticate Docker with ECR:

              * Run the following command to authenticate your Docker client with ECR:



    2. Deploy Docker Image to Amazon ECS:

A. Create an ECS Task Definition:

    Go to the AWS Management Console.
    Navigate to the Amazon ECS service.
    Create a new task definition, specifying your ECR image.
    
B. Create an ECS Cluster:

    * Create an ECS cluster where your task will be deployed.
    
C. Create an ECS Service:

* Create an ECS service using the task definition and cluster you created.
