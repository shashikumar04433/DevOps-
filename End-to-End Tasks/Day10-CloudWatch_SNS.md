

### Cloud Watch
```
CloudWatch enables you to monitor your complete stack such as applications, infrastructure, network,
 services and use alarms logs and events data to take automated actions and reduce mean time to resolution.
```
```
1. Dashboards
 Two types of Dashboards:
 - Custom Dashboards
 - Automatic Dashboards
```
```
 Custom Dashboards:Creating the custom dashboard and can view the metrics of all aws services
 individually and can share that with the publically and as well as with the particular user with mail id.

Automatic Dashboards: Automatic Dashboards are nothing but built in dashboards or pre-defined dashboards.
```
```
 Sharing the dashboard to public below are the steps:
eg:
1. Public share 
2. Share with credentials
3. Share with a SSO for the all the aws users in ur account.
```
```
* After creating the dashboards choose the option to share the dash board in actions.
* you will get a mail like this below and the user can access this with this userid adn password in aws account.
* you need to copy  link in cloudwatch and paste it in browser then access with below details
* Your username is shashikumarreddy023@gmail.com and temporary password is M3mZ90U%
```

**CloudWatch Alarms:**
```
They are a feature of Amazon CloudWatch that allows you to monitor metrics and automatically perform actions based on pre-defined thresholds.
* monitoring the matrics 
* time period 
* Perform actions
```

### Interview questions of cloud watch:

**1. What is Amazon CloudWatch?**
```
* Cloud watch is a montitoring tool it allows you to track metrics and collect and monitor log files.

The main features of cloud watch are:
- alarms
- dashboards
- logs
- events 
```

**2. How would you set up an alarm for an EC2 instance to monitor its CPU utilization?**
```
* Go to the CloudWatch console, create an alarm, choose the EC2 metric for CPU utilization, set the threshold and period, and define actions such as sending a notification or executing an Auto Scaling policy.
```
**3. What is CloudWatch Logs, and how is it used?**
```
* CloudWatch Logs helps you monitor, store, and access your log files from Amazon EC2 instances and it helps for troubleshooting the issues.
```
**4. How do you configure an EC2 instance to send logs to CloudWatch Logs?**
```
* Install the cloud watch log agent in ec2 and configure it to specify which log files to monitor.
```

**5. What are CloudWatch Dashboards?**
```
Dashboards are customized home pages in cloud watch where that used to monitor your resources in single view.
```
**6. What are cloud watch log insights?**
```
CloudWatch Logs Insights is a tool for searching and analyzing your log data.
```
**7. What are cloud watch events?**
```
CloudWatch Events provides real-time updates about changes in your AWS resources. It helps you react to these changes quickly.
```
**8. How does CloudWatch integrate with other AWS services?**
```
CloudWatch integrates with various AWS services such as EC2, RDS, DynamoDB, and Lambda to provide comprehensive monitoring. It can trigger AWS Lambda functions, SNS notifications, and more.
```
**9. How do you use CloudWatch in a multi-account setup?**
```
You can set up CloudWatch cross-account observability by sharing metrics, logs, and alarms across accounts using AWS Organizations and cross-account IAM roles.
```
**10. What are some best practices for using CloudWatch?**
```
Use the metrics based on application specific so that you will get to kow the issues on application level.
```

### SNS(Simple Notification Service)

**1. What is SNS?**
```
* SNS is a pub/sub (Public /Subscribe) messaging service that allows you to send messages to multiple subscribers.
* SNS supports multiple protocols such as HTTP, HTTPS, email, SMS, and mobile push notifications
```

**2. What are the main components of Amazon SNS?**
```
The main components of sns are topics, push notification ,subscriptions.
```
**3.How do you create an SNS topic?**
```
* Go to the SNS console, click on the "Create Topic" button, enter a name.
```
**4.What types of endpoints can be subscribed to an SNS topic?**
```
* HTTP/S, Email, SMS, SQS, Lambda.
```
**5. How do you publish a message to an SNS topic?**
```
Throught the aws console,aws cli,or aws sdks.
choose the topic and enter the mail id of the client who want to recieve the mail.
```
**6. What is the maximum size of a message that can be sent via SNS?**
```
256 KB.
```

**7. What is the difference between SNS and SQS?**
```
sns is push based service and sqs is pull based aws service where sqs handles the incoming notifications to reach the sns in fifo order.
```
