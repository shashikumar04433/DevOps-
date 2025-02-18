### Deploying the static website s3 and configuring to cloud front and should update the files instant using lambda function below are the steps to follow:


**Step1:**
```
Create a new S3 bucket and upload your static website files to it.
index.html
```
**step2:**
```
Go to the bucket policy permissions and give the get bucket or full permissions to it.
enable static hosting
unblock to public
then try to access from the browser
```
**Step3:**
```
Create a new CloudFront distribution and select the S3 bucket as the origin.
Choose the index.html file as the default root object.
Choose the S3 bucket as the origin domain name.
Copy the policies which origin domain automatically created and paste in s3 permissions policy.

{
	"Version": "2008-10-17",
	"Id": "PolicyForCloudFrontPrivateContent",
	"Statement": [
		{
			"Sid": "AllowCloudFrontServicePrincipal",
			"Effect": "Allow",
			"Principal": {
				"Service": "cloudfront.amazonaws.com"
			},
			"Action": "s3:GetObject",
			"Resource": "arn:aws:s3:::demo-s3-new/*",
			"Condition": {
				"StringEquals": {
					"AWS:SourceArn": "arn:aws:cloudfront::339712840183:distribution/E20EI9NN23GI9"
				}
			}
		}
	]
}
```
**Step4:**
Create a new role and attach
cloudfrontfullaccess
s3fullaccess

**Step5:**
```
Create a new lambda function and attach the role created in step4.
then create a event notification in s3 and choose lambda function as option.
```
**Step6:**
```
write lambda function as below shown code.
```
```
import boto3
import json

# Initialize CloudFront client
cloudfront_client = boto3.client('cloudfront')

def lambda_handler(event, context):
    # Log the entire event for debugging
    print("Received event: " + json.dumps(event, indent=2))
    
    # CloudFront distribution ID
    distribution_id = 'E20EI9NN23GI9'
    
    # Extract object keys from the event
    records = event.get('Records', [])
    
    if not records:
        error_message = 'No records found in the event. Event details: ' + json.dumps(event, indent=2)
        print(error_message)
        return {
            'statusCode': 400,
            'body': error_message
        }
    
    # Collect paths for invalidation
    invalidation_paths = []
    for record in records:
        s3_record = record.get('s3', {})
        object_key = s3_record.get('object', {}).get('key')
        if object_key:
            # Ensure the path starts with '/' and add it to invalidation paths
            path = f'/{object_key}'
            invalidation_paths.append(path)
            print(f"Adding path for invalidation: {path}")
        else:
            print(f"No object key found in record: {json.dumps(record, indent=2)}")
    
    if not invalidation_paths:
        return {
            'statusCode': 400,
            'body': 'No valid object keys found in the event.'
        }
    
    try:
        # Create CloudFront invalidation
        response = cloudfront_client.create_invalidation(
            DistributionId=distribution_id,
            InvalidationBatch={
                'Paths': {
                    'Quantity': len(invalidation_paths),
                    'Items': invalidation_paths
                },
                'CallerReference': str(context.aws_request_id)
            }
        )
        
        invalidation_id = response['Invalidation']['Id']
        print(f"Invalidation created with ID: {invalidation_id}")
        
        return {
            'statusCode': 200,
            'body': f'Invalidation created: {invalidation_id}'
        }
    except Exception as e:
        print(f"Error details: {str(e)}")  # Log the error details
        return {
            'statusCode': 500,
            'body': f'Error creating invalidation: {str(e)}'
        }
```
```
make sure that you replaced bucket name and distribution id. then deploy and test the invalidations are creating or not .if its creating all went right then try to upload some new file to s3 then automatically invalidation creates and shows in cloud front.
```