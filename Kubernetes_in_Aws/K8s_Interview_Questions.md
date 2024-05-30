## Kubernetes Interview Questions:

### 1.What is Kubernetes and why is it used?
```
Kubernetes is an open-source container orchestration platform that automates the deployment,
scaling, and management of containerized applications.
```
### 2.What are the key components of Kubernetes architecture?

**The key components of Kubernetes architecture include:**

**Master Node Components:**
```
API Server: Serves as the frontend of the Kubernetes control plane, handling communication with the cluster.
etcd: A consistent and highly available key-value store used for configuration management and service discovery.
Controller Manager: Runs controller processes, ensuring the desired state of the cluster matches the current state.
Scheduler: Assigns workloads to nodes based on resource availability and other constraints.
```
**Worker Node Components:**
```
Kubelet: An agent that runs on each node, ensuring containers are running in a Pod.
Kube-proxy: Maintains network rules on nodes, allowing network communication to Pods.
Container Runtime: The software that runs the containers (e.g., Docker, containerid).
```
**Additional Components:**
```
Pods: The smallest deployable units in Kubernetes, encapsulating one or more containers.
Services: Abstract a set of Pods and provide a stable network endpoint.
ConfigMaps and Secrets: Manage configuration and sensitive information respectively.
```

### What is a Pod and how does it differ from a container?
```
A Pod is the smallest deployable unit in Kubernetes and represents a single instance ofa running process
in your cluster.It can contain one or more containers that share the same network namespace and storage volumes.
```
### What is the purpose of a Kubernetes Service?
```
A Kubernetes Service provides a stable endpoint (IP address and DNS name) for accessing a set of Pods.
Services enable communication between different parts of an application and external access to the application.
```
### What is a Kubernetes Deployment and how does it ensure high availability?
```
A Kubernetes Deployment is a higher-level abstraction that defines the desired state for a set of Pods and ReplicaSets.
 It manages the deployment and scaling of Pods and ensures high availability by:
```
```
* Creating and updating instances of applications (Pods).
* Automatically replacing or rescheduling Pods if they fail, become unresponsive, or are terminated.
* Rolling out updates with zero downtime using rolling updates and rollbacks if necessary.
```

### How does Kubernetes handle container orchestration and scaling?
```
Kubernetes handles container orchestration and scaling through several mechanisms:
 
* Scheduling: The Kubernetes Scheduler assigns Pods to nodes based on resource requirements, policies, and constraints.
* Replication: ReplicaSets and Deployments ensure that a specified number of Pod replicas are running at any time.
* Horizontal Pod Autoscaling (HPA): Automatically scales the number of Pods based on CPU utilization or other select metrics.
* Vertical Pod Autoscaling (VPA): Adjusts the resource requests and limits of Pods based on actual usage.
```
### How do you monitor and troubleshoot Kubernetes clusters?
```
Monitoring and troubleshooting Kubernetes clusters typically involve:

* Metrics Collection: Using tools like Prometheus to collect and store metrics from various components.
* Logging: Using centralized logging solutions like Elasticsearch, Fluentd, and Kibana (EFK) stack to aggregate and analyze logs.
* Tracing: Implementing distributed tracing with tools like Jaeger to track the flow of requests across services.
* Dashboards: Visualizing metrics and logs using dashboards provided by tools like Grafana.
* kubectl Commands: Using kubectl to inspect resources, events, and logs (e.g., kubectl get pods, kubectl logs, kubectl describe pod).

```
