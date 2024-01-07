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
  
**4.Services**:
* ClusterIP, NodePort, LoadBalancer, ExternalName
* Service discovery and DNS
* Volumes and Persistent Volumes:

**5.Different types of volumes**:
* Persistent Volume (PV) and Persistent Volume Claim (PVC)
  
**6.ConfigMaps and Secrets**:
* Managing configuration data and sensitive information
  
## Configuration and Deployment:
**1.Deployments**:
* Rolling updates and rollbacks
* ReplicaSets
  
**2.StatefulSets**:
* Managing stateful applications
  
**3.DaemonSets**:
* Running a copy of a pod on every node

**4.Jobs and CronJobs**:
* Running tasks and scheduled jobs
  
**5.Helm**:
* Package manager for Kubernetes
  
## Networking:

**1.Ingress**:
* Routing external traffic to services
* Ingress controllers
  
**2.Network Policies**:
* Controlling pod-to-pod communication

## Monitoring and Logging:
**1.Metrics and Monitoring**:
* Prometheus, Grafana
* Kubernetes Dashboard
  
## Logging:
* Fluentd, Elasticsearch, Kibana (EFK stack)
* Loki, Grafana (Grafana Labs stack)

 
# Kubernetes 
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
### Kuberntes services:
```
1.Container
2.Pod
3.Deployment
4.Replicaset
5.Service
6.Namespace
7.ALB
8.NLB
9.Ingress Controller
```
**Container:**
```
Container is just a form of image of docker we can use the container in pods to perform multiple operations .
```
**Pod**
```
Pod is the smallest portion on the kubernetes where one or more container is attched to the kubernetes.
```
**Deployment**
```
 How to create or modify instances of the pods that hold a containerized application and it helps to auto scaling and auto healing.
```
**Replicaset**
```
Kubernetes object used to maintain a stable set of replicated pods running within a cluster at any given time.
```
**Services**
```
Services play a crucial role in the networking layer of a Kubernetes cluster, providing a stable endpoint for other services to connect to. They abstract away the details of the underlying pod instances, allowing for easier and more reliable communication between different components in a distributed application.

* There are four types of services that Kubernetes supports:
1.ClusterIP
2.NodePort
3.LoadBalancer

* ClusterIP (default): Internal clients send requests to a stable internal IP address.

* NodePort: Clients send requests to the IP address of a node on one or more nodePort values that are specified by the Service.

* LoadBalancer: Clients send requests to the IP address of a network load balancer.

