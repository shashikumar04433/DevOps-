### VPC Interview Questions:
**Intermediate-Level VPC Questions with Answers:**
**1.What is a VPC in AWS and why is it used?**
```
A VPC is a logically isolated section of the AWS Cloud where you can launch AWS resources in a virtual network that you define. It allows full control over IP addressing, subnets, route tables, and gateways.
```
**2.What are subnets in a VPC? What's the difference between public and private subnets?**
```
Subnets divide a VPC into smaller IP ranges. Public subnets have access to the internet (via Internet Gateway), whereas private subnets do not unless via NAT Gateway or NAT Instance.
```

**3.How does an Internet Gateway work with a VPC?**
```
An Internet Gateway is a horizontally scaled, redundant AWS-managed gateway that allows communication between instances in your VPC and the internet.
```

**4.What are route tables, and how do they control traffic in a VPC?**
```
Route tables determine how traffic is directed within the VPC. Each subnet must be associated with a route table, and it includes rules (routes) for traffic to specific destinations.
```

**5.What is a NAT Gateway and when would you use it over a NAT instance?**
```
A NAT Gateway allows instances in private subnets to access the internet without exposing them to inbound traffic. It's preferred over a NAT instance for scalability, availability, and managed maintenance.
```

**6.How do security groups differ from network ACLs in a VPC?**
```
Security groups are stateful, instance-level firewalls that allow inbound and outbound rules. NACLs are stateless, subnet-level firewalls that apply rules to both inbound and outbound traffic independently.
```

**7.What is the default VPC and how does it differ from a custom VPC?**
```
A default VPC is automatically created with public subnets in each AZ. A custom VPC is manually created and gives more granular control over network configuration.
```

**8.Can a VPC span across multiple Availability Zones or Regions? Explain.**
```
A VPC can span multiple AZs in a single region, enabling high availability. However, it cannot span multiple regions — for that, you use multiple VPCs.
```

**9.How would you connect two VPCs together? What is VPC Peering?**
```
VPC Peering connects two VPCs to route traffic between them using private IPs. It requires route table updates and does not support transitive routing.
```

**10.What are the limitations of VPC Peering and how do you overcome them?**
```
Limitations include no transitive peering, no overlapping CIDRs, and scalability challenges. Overcome them using Transit Gateway or service mesh for large-scale communication.
```
**Advanced-Level VPC Questions with Answers:**

**11.What is a Transit Gateway and how does it differ from VPC Peering?**
```
A Transit Gateway is a central hub to connect multiple VPCs and on-prem networks. Unlike VPC Peering, it supports transitive routing, better scalability, and simpler management.
```

**12.How would you implement high availability and fault tolerance in a VPC design?**
```
Distribute subnets across multiple AZs, use ELBs, enable auto-scaling groups, deploy multi-AZ RDS, and configure health checks and failover mechanisms.
```

**13.Explain flow logs in VPC — what are they used for and where are they stored?**
```
VPC Flow Logs capture IP traffic going to/from interfaces in a VPC. They are useful for monitoring, troubleshooting, and auditing. Logs can be stored in CloudWatch Logs or S3.
```
**14.How would you secure a VPC that handles sensitive data?**
```
Use private subnets for sensitive resources, NACLs and security groups, VPC endpoints for S3 access, flow logs, encryption (at-rest and in-transit), and IAM role policies for access control.
```

**15.How do you handle hybrid cloud connectivity using VPC (e.g., on-prem to AWS)?**
```
Use VPN Gateway for secure tunneling, or AWS Direct Connect for dedicated connectivity. Ensure encryption, routing, and failover are properly configured.
```
