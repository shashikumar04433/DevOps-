### Aws Lambda
```
- Lambda is a serverless compute service that runs your code in response to events.
or
It runs your code without managing the servers.
or 
It is a serverless event based trigger.
- Lambda is a compute service that runs your code in response to events.

- Lambda runs your code only when needed and scales automatically.

- You pay only for the compute time you consume.
- There is no charge when your code is not running.
- There is no charge for idle time, or for compute time taking less than 100ms.
```
### 
**Function:**
```
A Lambda function is a self-contained application or script written in one of the supported languages.
```
**Event Source:**
```
An AWS service or custom application that triggers the function.
```

**Trigger:**
```
Configured to invoke your Lambda function.
```
**Execution Role:**
``` 
An IAM role that grants your function permission to access AWS services and resources.
```
### Supported languags

```
Node.js
Python
Ruby
Java
Go
.NET Core
```

**Custom Runtime**
```
Lambda supports custom runtimes. You can use any language that runs on the Linux operating system.
You need to setup everything.
```

### Basic Workflow
```
Write code: Write your Lambda function code in your preferred language.

Upload code: Deploy your code to Lambda via the AWS Management Console, CLI, or SDKs.

Set triggers: Configure triggers from event sources like S3, DynamoDB, API Gateway, etc.

Execute: Lambda runs your function when triggered.

Monitor: Use AWS CloudWatch to monitor, log, and trace function execution.
```


### Create basic s3 listing using lambda:
```

1. Create a new lambda function
2. select the runtime as python 3 or above.
3. create and go to the code and replace the .py file with below code
```
```
import json
import boto3

s3 = boto3.resource('s3')

def lambda_handler(event, context):
    bucketlist = []
    for bucket in s3.buckets.all():
        bucketlist.append(bucket.name)
    print(json.dumps(bucketlist))
    return {
        'statusCode': 200,
        'body': json.dumps(bucketlist)  # Convert to JSON string for HTTP response
    }
```


## 1. Create s3 bucket and upload index.html and then configure this in cloud front and make use of aws lambda
   Create a s3 bucket then upload index.html code and then enable the public block check box and then allow in properties in the end static web hosting enable that.
   Then in the permissions write the below policy:
   ```
   {
    "Version": "2012-10-17",
    "Statement": [
        {
            "Effect": "Allow",
            "Principal": "*",
            "Action": "s3:GetObject",
            "Resource": "arn:aws:s3:::abc-ne/*"
        }
    ]
}
```

## 2. Real time seanario of  schedule job to start and stop the instance using the lambda:

:**Step1::**
```
create ec2 instance
```

:**Step2::**
```
create the new ploicy  and select write and in that  the stop and start ec2 should check and attach it to the IAM role.
```
:**Step3::**
```
create the lambda function and attach the IAM role to it.
create a lambda function for starting and stopping the server using nametags or instance id.
```

### for starting the ec2 with lambda function.
```
import boto3
def lambda_handler(event, context):
    # Initialize boto3 client for EC2
    ec2 = boto3.client('ec2')
    
    # Define the instance ID
    instance_id = 'i-0c199fd445941f837'
    
    # Stop the EC2 instance
    response = ec2.start_instances(InstanceIds=[instance_id])
    print(f'Starting instance: {instance_id}')
    
    return {
        'statusCode': 200,
        'body': f'Starting instance: {instance_id}'
    }
```
### for stopping the ec2 with lambda function.
```
import boto3

def lambda_handler(event, context):
    # Initialize boto3 client for EC2
    ec2 = boto3.client('ec2')
    
    # Define the instance ID
    instance_id = 'i-0c199fd445941f837'
    
    # Stop the EC2 instance
    response = ec2.stop_instances(InstanceIds=[instance_id])
    print(f'Starting instance: {instance_id}')
    
    return {
        'statusCode': 200,
        'body': f'Starting instance: {instance_id}'
    }
```
## Stopping instance with tag name:
```
import json
import boto3

ec2 = boto3.resource('ec2', region_name='ap-south-1')

def lambda_handler(event, context):
    # Find running instances with the specific tag
    instances = ec2.instances.filter(
        Filters=[
            {'Name': 'instance-state-name', 'Values': ['running']},
            {'Name': 'tag:auto-start-stop', 'Values': ['Yes']}
        ]
    )
    
    # Stop each instance found
    for instance in instances:
        instance.stop()
        print(f"Instance ID stopped: {instance.id}")
    
    return {
        'statusCode': 200,
        'body': 'Successfully stopped instances with the tag.'
    }
```


**Step4:**
```
Create the cloudwatch and schedule the time there and attach the role.
```
```
EventBridge: Event bridge support third party saas applications.
Can handle a wide range of event sources, including API calls, changes in AWS resources, or custom events from your applications.
```
```
Lambda : where as lamba supports only with in aws 
Primarily focused on scheduling the execution of the Lambda function itself, using CloudWatch Events.
```


### 3. Ec2 Server ebs volume encryption:
```
for new volumes go the ebs volume take a snapshot and in actions enable the encryption check box and add the default kms (key management service ) to get more secure.

(or) you can do that using the aws-cli:

aws ec2 create-volume \
  --availability-zone <availability-zone> \
  --size <size-in-gb> \
  --encrypted \
  --kms-key-id <kms-key-id>
  ```
