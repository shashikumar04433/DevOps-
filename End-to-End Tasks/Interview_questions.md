### Interview_questions:
**1. What is Terraform dynamic block and why it is used?**
```
* A Terraform dynamic block is used to generate multiple nested blocks dynamically inside a resource, module, or provisioner.
Why Use It?
* Reduces redundant code when you need multiple similar configurations.
* Helps manage variable numbers of configurations dynamically.
* Useful for defining security rules, IAM policies, tags, etc.
```
**2.What is replicaset vs deployment?**
```
* ReplicaSet: Purpose	Ensures the desired number of pod replicas are running.
*Deployment: Manages ReplicaSets and allows rolling updates.
```
**3. How do u set up dynamodb lock for your state file in terraform?**
```
* To prevent concurrent modifications to the Terraform state file, enable state locking with DynamoDB.
* resource "aws_dynamodb_table" "terraform_locks" {
  name         = "terraform-state-lock"
  billing_mode = "PAY_PER_REQUEST"
  hash_key     = "LockID"

  attribute {
    name = "LockID"
    type = "S"
  }
}

* terraform {
  backend "s3" {
    bucket         = "my-terraform-state-bucket"
    key            = "terraform.tfstate"
    region         = "us-east-1"
    dynamodb_table = "terraform-state-lock"
  }
}
```
**4.What are the types of data blocks and their use case?**
```
Data sources in Terraform fetch information from existing resources.

data "aws_ami"	-> Fetch latest AMI for an EC2 instance
data "aws_vpc"	-> Get details of an existing VPC
data "aws_s3_bucket" -> Retrieve S3 bucket information
data "terraform_remote_state" -> Fetch state from another Terraform workspace

eg: data "aws_ami" "latest_ubuntu" {
  most_recent = true
  owners      = ["amazon"]
  filter {
    name   = "name"
    values = ["ubuntu/images/hvm-ssd/ubuntu-*-amd64-server-*"]
  }
}

```
**5.How do u give the access to the person who doesnt have the access to s3 from outside or a from a different account?**
```
resource "aws_s3_bucket_policy" "cross_account" {
  bucket = "my-bucket"

  policy = jsonencode({
    Statement = [{
      Effect    = "Allow"
      Action    = ["s3:GetObject"]
      Resource  = "arn:aws:s3:::my-bucket/*"
      Principal = {
        AWS = "arn:aws:iam::ACCOUNT-ID:user/USERNAME"
      }
    }]
  })
}
* Ensure the user in the external account has an IAM policy to access S3.
```
**6.How do you solve the issue of vpc endpoint to get the logs to any third party tool or the cloud watch?**
```
* By default, VPC endpoints don't allow logs. To fix this:
* Enable VPC Flow Logs and store them in S3 or CloudWatch.
* Create a Lambda Function to forward logs to a third-party service.
* Use a third-party log collector (e.g., Datadog, Splunk) with an S3 integration.
```
**7.what is hpa and vpa how that works in k8s?**
```
* HPA (Horizontal Pod Autoscaler) -> Adjusts the number of pods
* VPA (Vertical Pod Autoscaler) -> Adjusts CPU/memory limits of existing pods
``` 
**8.what are probes?what are liveness readness and startup probes?**
```
* Probes in Kubernetes monitor pod health:
* Liveness Probe -> Checks if the app is still running (restarts it if it crashes).
* Readiness Probe	-> Checks if the app is ready to receive traffic (removes pod from service if unhealthy).
* Startup Probe	-> Ensures an app has started before other probes run.

eg:
livenessProbe:
  httpGet:
    path: /healthz
    port: 8080
  initialDelaySeconds: 3
  periodSeconds: 5

readinessProbe:
  httpGet:
    path: /ready
    port: 8080
  initialDelaySeconds: 5
  periodSeconds: 10

```
**9. types of different blocks and use case?**
```
provider -> Defines the cloud provider (e.g., AWS, Azure)
resource	-> Creates an actual resource (e.g., EC2, S3)
data	-> Fetches data from existing resources
module	-> reuses Terraform configurations
output	-> Displays important information after execution
variable -> Defines reusable input values
```

**10. what types of issues we face regarding terraform init?**
```
* No backend found	-> Backend not configured  --> Add an S3/DynamoDB backend in terraform.tf
* Plugin download failure	-> Network issues	-> Retry with terraform init -upgrade
* State lock issue -> Another user is running Terraform	-> Manually unlock with terraform force-unlock <LOCK_ID>
* Provider version conflict	-> Incorrect provider versions -> Specify the correct provider version
* 
```
