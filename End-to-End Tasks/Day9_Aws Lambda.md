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
