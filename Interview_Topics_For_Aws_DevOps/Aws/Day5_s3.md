## Day5 -S3


### S3 (Simple Storage Service)
```
when ever you create a bucket it used as standard storage class
```
### What is S3 Bucket?
```
A bucket is a container that holds your objects, such as files and folders.
```
### What is S3 Object?
```
An object is a file or folder that you store in an S3 bucket.
```
### Types of Buckets
```
1. General purpose - most of the projects use this one as it supports the multiple storage classes.
2.Directory -> It is used for low latency use cases.These buckets are only use the s3 express one zone storage class. 

### Types of Storage classes:
```
1.Standard -Frequently accessed data(higher cost)
2.Standard - IA - Infrequently accessed, but requires quick access (lower cost compare to Standard)
3.One Zone IA - Infrequent access in a single availability zone
4. Multi-tier intelligence
5.Glacier - Archival with minutes-to-hours retrieval times
6.Deep Archive - Long-term archival with 12+ hours retrieval
```


**1.Bucket overview:**
```
We can check the overview of the bucket details like which region and creation date of bucket.
```

**2.Bucket Versioning:**
```
Versioning is a means of keeping multiple variants of an object in the same bucket. we can also retrive the object which is deleted.
```

**3.Bucket Tags:**
```
We can use bucket tags to track storage costs and organize buckets.
```

**4.Encryption types:**
```
S3 will allocate default encryption with the SSE(Server Side Encryption).
You can configure encryption with the kms(key management service) also if it is required.

1.Server-side encryption (SSE-S3) - it is used for general encryption.
2.Server-side encryption with AWS KMS keys (SSE-KMS) - SSE-KMS provides access control for S3 objects, while SSE-S3 does not. 
3.Dual layer server-side encryption with Aws Kms keys(DSSE-KMS) - its a dual layer of security
```

**5.Intelligent-Tiering Archive configurations:**

```
Intelligent-Tiering Archive configurations in AWS S3 allow you to save money on storage costs by automatically moving data to the most cost-effective storage tier based on how often it's accessed.

Frequent Access- (default for new objects).
Infrequent Access- (moved after 30 days of no access).
Archive Access- ( moved after 90 days of no access).
Deep Archive Access- (moved after 180 days of no access).
```

**6.Server access logging:**
```
s3 enable to see the logs of the bucket to access it is used for check the health of your server access logging
```

**7.AWS CloudTrail data events :**


**8.Event notifications:**
```
Event notifications are nothing but a trigger of a mail when ever the object created or deleted or performmed anything.
You can configure event notifications using Sqs.
  
For eg:
when ever the object is deleted you need to get a mail that we can configure in sns and attach to the particular bucket which needs on trigger.
```

**9.Amazon S3 EventBridge:**

* S3 eventBridge
Send notifications to Amazon EventBridge for all events in this bucket

**10.Transfer acceleration:**
Use an accelerated endpoint for faster data transfers

**11.Object Lock:**
```
Object Lock is a feature of Amazon S3 that enables you to store objects using a write-once
```

**12.Requester pays:**
```
Requester pays is a feature that allows you to pass the cost of storing an object in Amazon S3.

eg:
you have upload s3 bucket and enabled the requester pays when ever the requester access or fetch the data bill payed for request by the requester that is one way to do a cost effectiveness.
```

**13.Static website hosting:**
```
Static website hosting is a feature where we can host the static website directly on s3 buckets.
```



