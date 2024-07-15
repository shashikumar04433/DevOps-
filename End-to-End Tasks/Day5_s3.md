# Day5

1.Region
2.Zones
3.Edge Locations
4.S3

### What is Region?
A region is a physical location in the AWS Cloud that contains one or more Availability Zones.
(or)
Region is cluster of data centers

### What is Zone?
A group of isolated data centers are called zones .

### What is edge locations?
A site that CloudFront uses to cache copies of your content for faster delivery to users at any location.


### S3 (Simple Storage Service)

1.Bucket overview:
We can check the overview of the bucket details like which region and creation date of bucket.

2.Bucket Versioning :
Versioning is a means of keeping multiple variants of an object in the same bucket. we can also retrive the object which is deleted.

3.Bucket Tags:
We can use bucket tags to track storage costs and organize buckets.

4.Default encryption:
S3 will allocate default encryption with the SSE(Server Side Encryption).
You can configure encryption with the kms(key management service) also if your are required.

5.Intelligent-Tiering Archive configurations:
Intelligent-Tiering Archive configurations in AWS S3 allow you to save money on storage costs by automatically moving data to the most cost-effective storage tier based on how often it's accessed.

6.Server access logging:
s3 enable to see the logs of the bucket to access it is used for check the health of your server access logging

7.AWS CloudTrail data events :

8.Event notifications:
Event notifications are nothing but a trigger of a mail when ever the object created or deleted or performmed anything.
You can configure event notifications using Sqs.

For eg:
when ever the object is deleted you need to get a mail that we can configure in sns and attach to the particular bucket which needs on trigger.

9.Amazon EventBridge:


10.Transfer acceleration:


11.Object Lock:
Object Lock is a feature of Amazon S3 that enables you to store objects using a write-once

12.Requester pays:
Requester pays is a feature that allows you to pass the cost of storing an object in Amazon S3.

eg:
you have upload s3 bucker and enabled the requester pays when ever the requester access or fetch the data bill payed for request by the requester that is one way to do a cost effectiveness.

13.Static website hosting:
Static website hosting is a feature where we can host the static website directly on s3 buckets.

