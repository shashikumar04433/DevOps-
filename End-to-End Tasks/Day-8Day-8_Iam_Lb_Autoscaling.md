### IAM (Identity access Management)
```
- IAM is a service that helps you securely control access to AWS resources.
- IAM is a web service that enables you to manage users and user permissions across the AWS cloud.

Types in Identity Access Management:
- Users ----|Identity
- Roles ----|Identity
- Policies --|Access
- Groups --- |Management

```


### User 
```

Create a User named s3 and choose password as custom password then save that credentials  and attach the s3 full access policy.

- Open in incgnito window and and enter the iam username and password of above created.

- You should be able to access only s3 not any other resource.

```

### Policies
```
- Policies are documents that define one or more permissions.
```
**Three types of policies in aws:**
```
- Aws managed policies
- It managed by aws .
- Customer managed policies
- Policies should be written by you .
- Inline policies
- Policies are attached to the resource directly within that resource only.
```

**Roles:**
```
- Roles are used to grant permissions to services, applications, and tools.
- Roles are not associated with a specific user, but they can be assumed by a user.
- Roles can be assumed by a user, a service, or an application.
```
**Groups:**
```
- Groups are used to manage permissions for multiple users.
- Groups can be used to assign permissions to multiple users at once.
- db team - 1 policy
- dev team - 1 policy
```

###  Aws Auto Scaling
```
- Auto Scaling is a service that automatically adjusts the capacity instance or resources to make the application available.
Advantages are:
- It helps the high application availability
- It helps to reduce the cost effectiveness of the application.

Disadvantages:
- It is not easy to configure.
- It is not easy to monitor the application.
```

### LoadBalancer
```
- Load balancer is a service that distributes incoming traffic across multiple targets, such as EC2 instances
- Loadbalancer is a reverse proxy and it is responsiable for distributing the network traffic across multiple cloud servers
```

**Types of LoadBalancers:**
**Classic Load Balancer(CL)**
```
- It is the oldest form of load balancing which is widely used for ec2 instance
- It doesnt support the host based routing.
```

**Application Load Balancer(ALB)**
```
- It is advanced load balancing type where it supports path based and host based routing .
* It is used for the application layer load balancing.
* It is used for the http and https traffic.
```

**Network Load Balancer(NLB)**
```
* It is used recommend and designed for tcp and udp incoming requests
* It is used for the network layer load balancing.
* It is used for the high performance and high availability.
```

**Gateway Loadbalancer:**
```
* Gateway Load Balancer helps you easily deploy, scale, and manage your third-party virtual appliances.
```

