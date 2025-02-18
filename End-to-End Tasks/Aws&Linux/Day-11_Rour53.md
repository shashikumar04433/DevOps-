## Route 53 
```
It provides DNS (Domain Name System ) as service.

Route 53 mainly perform on 4 main functions they are:
1.Domain Regisration
2.DNS Operation (Hosted Zone)
3.DNS routing.
4.Health checking.
```
**Domain Regisration**
```
Domain Regisration is the process of registering a domain name in aws .
```

**Hosted Zone**
```
A hosted zone is a container for different types DNS records. 
eg :
1. A record - support ipv4 routing
2. CNAME record - domain to domain routing
3. NS record - name server used to route subdomain.
4. AAAA Record - ipv6 routing

```
**DNS routing**
```
Dns routing is used to route the traffic based on dns queries.
or 
DNS routing is used to route the incoming and outgoing traffic of the application.
```

**2. Real time seanario of dns is:**
```
When we type a domain name eg: www.google.com  in browser it check in the internet ISP and it will be redirected to route 53 and checks with the hosted zone where the ns records are there and validate it and then it hits the lb and then it routes to the ip and checks the security group based on the permissions or allowed port if the user has right permission then it will allow you to access the appication.
```

**3. How do you create a hosted zone in Route 53?**
```
A hosted zone can be created via the AWS Management Console, AWS CLI. In the console, navigate to the Route 53 dashboard, choose "Hosted Zones," and click "Create Hosted Zone."
```

**4. What is a health check in Route 53 and how is it used?**
```
A health check in Route 53 monitors the health and of your application performance endpoints. If an endpoint fails a health check, Route 53 can redirect traffic to a healthy endpoint using failover routing.
```

**5.  Describe the process of configuring a failover routing policy.**
```
To configure failover routing, you need to create two resource record sets for the same DNS name. One set is the primary (with a primary health check), and the other is secondary (with a secondary health check). If the primary health check fails, Route 53 will route traffic to the secondary endpoint.
```
