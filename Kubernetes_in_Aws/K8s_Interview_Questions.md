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
Container Runtime: The software that runs the containers (e.g., Docker, containerd).
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
