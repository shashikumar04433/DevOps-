## Interview_Questions_k8s:

**Beginner Level (Fundamentals)**

1.What is Kubernetes? Why is it used?
```
Kubernetes is an open-source container orchestration platform for automating deployment, scaling, and management of containerized applications.
```

2.What are Pods in Kubernetes?
```
A Pod is the smallest deployable unit in Kubernetes, consisting of one or more containers that share storage and networking.
```

3.What is a Node in Kubernetes?
```
A Node is a worker machine in Kubernetes that runs containerized applications, managed by the control plane.
```

4.What are Deployments in Kubernetes?
```
Deployments manage ReplicaSets and provide features like rolling updates and rollbacks for applications.
```

5.What is a Service in Kubernetes? Explain types of Services.
```
A Service exposes pods to the network and includes ClusterIP, NodePort, LoadBalancer, and Headless Services.
```

6.What is a Namespace in Kubernetes? Why is it useful?
```
A Namespace is a virtual cluster within Kubernetes used to isolate and manage resources efficiently.
```
7.What is a ConfigMap and how is it different from a Secret?
```
ConfigMaps store non-sensitive configuration data, whereas Secrets store sensitive data like passwords securely.
```

8.What is a Persistent Volume (PV) and Persistent Volume Claim (PVC)?
```
A PV is a storage resource in a cluster, and a PVC is a request to use a PV.
```

9.What is the difference between StatefulSet and Deployment?
```
StatefulSet maintains pod identity (stable hostname and storage), whereas Deployment manages stateless applications.
```
10.What is the purpose of Ingress in Kubernetes?
```
Ingress manages external access to services using HTTP/HTTPS routing.
```

**Intermediate Level (Cluster & Networking)**
11.How does the Kubernetes Scheduler work?
```
The scheduler assigns pods to nodes based on resource requirements and constraints.
```

12.What is the role of Kubelet in Kubernetes?
```
Kubelet runs on each node and ensures that containers are running in a pod.
```

13.What is a DaemonSet in Kubernetes?
```
A DaemonSet ensures that a pod runs on all (or specific) nodes in a cluster.
```

14.What are ReplicaSets and how are they different from Deployments?
```
A ReplicaSet ensures a specified number of pod replicas, while a Deployment provides version control and updates.
```

15.What are Taints and Tolerations in Kubernetes?
```
Taints prevent pods from being scheduled on certain nodes, and tolerations allow specific pods to bypass them.
```

16.What is a Headless Service and when would you use it?
```
A Headless Service (clusterIP: None) allows direct pod discovery without load balancing.
```

17.What is a Service Mesh? How does Istio help in Kubernetes?
```
A Service Mesh manages service-to-service communication, and Istio provides traffic control, security, and observability.
```

18.What is the difference between LoadBalancer, NodePort, and ClusterIP Services?
```
ClusterIP: Internal service access.
NodePort: Exposes service on a node’s IP and port.
LoadBalancer: Uses an external load balancer for public access.
```
19.How does Kubernetes handle rolling updates and rollbacks?
```
Deployments support rolling updates by replacing pods incrementally and allow rollback to previous versions if needed.
```
20.How do you scale applications in Kubernetes?
```
You can scale manually (kubectl scale deployment), automatically using Horizontal Pod Autoscaler (HPA), or via Cluster Autoscaler.
```
**Advanced Level (Security, Storage, CI/CD, and Troubleshooting)**

21.What are Network Policies in Kubernetes?
```
Network Policies control inbound and outbound traffic between pods based on rules.
```

22.What is the difference between Horizontal Pod Autoscaler (HPA) and Vertical Pod Autoscaler (VPA)?
```
HPA scales the number of pods based on CPU/memory, while VPA adjusts resource limits for individual pods.
```

23.How does Kubernetes handle Secrets securely?
```
Secrets are base64-encoded and can be encrypted at rest using Kubernetes encryption providers.
```

24.What is Pod Affinity and Anti-Affinity?
```
Pod Affinity schedules pods together, while Anti-Affinity ensures they are scheduled apart.
```

25.What is a Sidecar Container and give an example?
```
A Sidecar runs alongside the main container in a pod, e.g., a logging agent collecting logs.
```
26.What is a Job and CronJob in Kubernetes?
```
Job: Runs a task to completion.
CronJob: Schedules Jobs to run at specific times.
```
27.How does Kubernetes handle pod eviction and rescheduling?
```
Pods are evicted due to resource pressure, node failures, or taints, and may be rescheduled based on policies.
```
28.What is a Custom Resource Definition (CRD) in Kubernetes?
```
CRDs extend Kubernetes by allowing users to define custom APIs.
```
29.How would you debug a pod stuck in CrashLoopBackOff?
```
Use kubectl describe pod <pod> and kubectl logs <pod> to check errors and resource limits.
```
30.How would you set up CI/CD for Kubernetes applications?
```
Use tools like Jenkins, ArgoCD, or GitOps for automated builds, testing, and deployment.
```
