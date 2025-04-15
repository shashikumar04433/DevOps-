**Advanced Interview Questions and Answers: Load Balancing & Auto Scaling**

---

###  Load Balancing – Advanced Q&A

**1. How does a Layer 7 load balancer differ from a Layer 4 load balancer?**
- Layer 4: Operates at TCP/UDP level. Routes traffic based on IP and port.
- Layer 7: Works at application level. Routes based on URL, headers, cookies.
- Example: AWS ALB (L7), AWS NLB (L4), Azure App Gateway (L7).

**2. How would you handle sticky sessions in a distributed environment?**
- Use session affinity via load balancer cookies.
- Prefer stateless design with session storage in Redis/DynamoDB.

**3. How do health checks work in a load balancer?**
- Load balancer pings targets using health check path (e.g., /health).
- On failures, targets marked unhealthy and traffic rerouted.

**4. How would you route traffic based on the user's location?**
- Use geo-routing with Route 53 (AWS), Azure Traffic Manager.
- Common for multi-region deployments.

**5. What happens if one AZ goes down and the load balancer is still routing traffic there?**
- Health checks fail and traffic automatically rerouted.
- Cross-zone LB and multi-AZ deployments help mitigate.

**6. How can you implement blue-green or canary deployments with a load balancer?**
- Use separate target groups or routing rules.
- Weighted traffic distribution for canary deployments.

**7. How do you secure traffic through the load balancer?**
- TLS termination at LB.
- Use WAF for OWASP protection.
- Redirect HTTP to HTTPS, enforce TLS policies.

**8. Difference between Classic LB, ALB, and NLB?**
| Feature         | CLB      | ALB         | NLB           |
|----------------|----------|-------------|---------------|
| Layer           | 4 & 7    | 7           | 4             |
| Use Case        | Legacy   | HTTP apps   | High perf.    |
| Path-based?     | No       | Yes         | No            |
| TLS Termination | Yes      | Yes         | Yes           |

---

###  Auto Scaling – Advanced Q&A

**1. How does Auto Scaling differ between EC2, ECS, and Lambda?**
- EC2: Scales VM instances.
- ECS: Scales container tasks.
- Lambda: Auto-scales functions with provisioned concurrency.

**2. What metrics can trigger an Auto Scaling event?**
- CPUUtilization, memory (custom via CW Agent), queue length, latency.

**3. How to ensure zero downtime during scaling?**
- Use warm pools and lifecycle hooks.
- Set minimum healthy % for rolling deployments.

**4. How to avoid flapping (rapid scaling in/out)?**
- Configure cooldown periods.
- Use step scaling with buffer thresholds.

**5. Difference between predictive and scheduled scaling?**
- Scheduled: Based on time (e.g., 9 AM daily).
- Predictive: Uses ML to anticipate traffic.

**6. Can Auto Scaling affect DB connections?**
- Yes, may overload DB.
- Use RDS Proxy or connection pooling.

**7. What are lifecycle hooks in Auto Scaling?**
- Pause launch/terminate processes to run custom scripts.
- E.g., log dumping, configuration installation.

**8. Spot instances in Auto Scaling?**
- Mixed policies allow Spot + On-Demand.
- Use capacity rebalance to manage interruptions.

---


