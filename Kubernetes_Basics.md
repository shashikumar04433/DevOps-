## Kubernetes Basics 

## Core Concepts:
**1.Containers**:
* Docker basics (containerization)
  
**2.Kubernetes Architecture**:
* Control Plane components (API server, controller manager, scheduler, etcd)
* Node components (kubelet, kube-proxy, container runtime)

**3.Pods**:
* Pod lifecycle
* Multi-container pods
  
**4Services**:
* ClusterIP, NodePort, LoadBalancer, ExternalName
* Service discovery and DNS
* Volumes and Persistent Volumes:

**5Different types of volumes**:
* Persistent Volume (PV) and Persistent Volume Claim (PVC)
  
**6ConfigMaps and Secrets**:
* Managing configuration data and sensitive information
  
## Configuration and Deployment:
**1.Deployments**:
* Rolling updates and rollbacks
* ReplicaSets
  
**2.StatefulSets**:
* Managing stateful applications
  
**3.DaemonSets**:
* Running a copy of a pod on every node

**4Jobs and CronJobs**:
* Running tasks and scheduled jobs
  
**5Helm**:
* Package manager for Kubernetes
* 
## Networking:

**1.Ingress**:
* Routing external traffic to services
* Ingress controllers
  
**2Network Policies:

Controlling pod-to-pod communication
Monitoring and Logging:
Metrics and Monitoring:

Prometheus, Grafana
Kubernetes Dashboard
Logging:

Fluentd, Elasticsearch, Kibana (EFK stack)
Loki, Grafana (Grafana Labs stack)
```
Kubernetes is an open-source container orchestration platform designed to automate the deployment,
scaling, and management of containerized applications. Containers are lightweight, portable,
and consistent environments that package an application and its dependencies, allowing it to run
consistently across various computing environments.
```
```
Kubernetes Helps in automating the below methods:
  1. Hosting -->It automates hosting.
  2. Auto Scaling --> It controles the replications.
  3. Auto Scaling --> Controles the damage and fix it.
  4. Enterprises --> It supports the enterprise editions where docker doesn't.
```
## Difference between Master Node container and Slave Node container:

### Master Node
```
1.Api Server
2.Scheduler
3.Etcd
4.Controllers
5.Cloud Controller Manager
```
### Slave Node
```
1.Kube-Proxy
2.Kube let
3.Container runtime
```
