## Types_of_Deployments in K8s:

**1.Rollback Update**
```
Replaces the pods  gradually to minimize downtime . (it replaces one by one if something goes wrong u can undo those changes)
```
**2. Blue Green Deployment**
```
Blue Green Deployment is a deployment strategy where two identical environments (blue and green) are created.
The blue environment is the new version of the application, and the green environment is the current version.
The traffic is routed to the green environment, and once the blue environment is verified to be working correctly.
```
**3. Canary Deployment**
```
Canary deployment is a deployment strategy where a small percentage of users are routed to the new version .
```
