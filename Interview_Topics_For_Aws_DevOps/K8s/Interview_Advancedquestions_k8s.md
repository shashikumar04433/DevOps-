### Kubernetes Architecture & Components
**1. Explain the architecture of Kubernetes and the role of etcd, API Server, Controller Manager, Scheduler, and Kubelet.**
```
Kubernetes follows a master-worker architecture:

* API Server: The main control plane component, processes API requests.
* etcd: A key-value store for cluster configuration and state.
* Controller Manager: Runs controllers that maintain the cluster’s desired state.
* Scheduler: Assigns new pods to nodes based on resource availability.
* Kubelet: Runs on worker nodes, manages pod lifecycle, and communicates with the API Server.
* Kube-proxy: Manages networking, load balancing, and service discovery.
```
**2. How does the Kubernetes Scheduler determine which node to schedule a pod on?**
```
The scheduler follows these steps:

Filtering -> Eliminates nodes that do not meet resource requirements (CPU, memory, affinity, taints).
Scoring ->Scores the remaining nodes based on node affinity, resource usage, and other factors.
Binding -. Assigns the highest-scoring node to the pod.
```
**3. What are the key controllers in Kubernetes, and how do they work?**
```
* Node Controller: Detects node failures and reschedules pods.
* ReplicaSet Controller: Ensures a specified number of pod replicas are running.
* Deployment Controller: Manages rolling updates and rollbacks.
* Job & CronJob Controllers: Manages batch and scheduled job execution.
```
### Networking & Services
**4. How does Kubernetes networking work, and what are the different networking models?**
```
Kubernetes networking ensures every pod has a unique IP. Models include:

Pod-to-Pod: Handled by CNI plugins like Calico, Flannel, and Cilium.
Pod-to-Service: Managed via ClusterIP, NodePort, and LoadBalancer.
Ingress for external traffic: Uses controllers like NGINX and Traefik.
```
**5. What is the difference between ClusterIP, NodePort, and LoadBalancer services?**
```
Type	Accessibility	Use Case
ClusterIP	Internal only	Default service for internal communication
NodePort	Exposes service on node IPs	External access via node’s IP
LoadBalancer	Uses cloud provider’s LB	External access with auto-scaling
```
**6. How do Ingress Controllers work in Kubernetes?**
```
Ingress Controllers route external HTTP/S traffic to services.
```
**Example NGINX Ingress:**
```
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: example-ingress
spec:
  rules:
  - host: myapp.example.com
    http:
      paths:
      - path: /
        pathType: Prefix
        backend:
          service:
            name: my-service
            port:
              number: 80
```
### Security & RBAC
**7. How does RBAC (Role-Based Access Control) work in Kubernetes?**
```
RBAC controls permissions using:

Roles: Namespace-specific permissions.
ClusterRoles: Cluster-wide permissions.
RoleBindings & ClusterRoleBindings: Assign roles to users, groups, or service accounts.
```

**Example Role:**
```
apiVersion: rbac.authorization.k8s.io/v1
kind: Role
metadata:
  name: pod-reader
  namespace: default
rules:
- apiGroups: [""]
  resources: ["pods"]
  verbs: ["get", "list", "watch"]
```
**8. How do you secure Kubernetes Secrets?**
```
Encrypt secrets using encryption-provider-config.
Use external stores like Vault or AWS Secrets Manager.
Mount secrets as files, not environment variables.
```
**Example Secret:**
```
apiVersion: v1
kind: Secret
metadata:
  name: my-secret
type: Opaque
data:
  password: cGFzc3dvcmQ=  # Base64 encoded
```
**9. What are NetworkPolicies, and how do they work?**
```
NetworkPolicies control pod communication.
```

**xample: Allow only web pods to access the database.**
```

apiVersion: networking.k8s.io/v1
kind: NetworkPolicy
metadata:
  name: allow-web-to-db
  namespace: default
spec:
  podSelector:
    matchLabels:
      role: db
  policyTypes:
  - Ingress
  ingress:
  - from:
    - podSelector:
        matchLabels:
          role: web
```
### Storage & Persistent Volumes
**10. What is the difference between PersistentVolumes (PV) and PersistentVolumeClaims (PVC)?**
```
PV: Cluster-wide storage resource.
PVC: User’s request for storage.
```
**Example PVC:**
```
apiVersion: v1
kind: PersistentVolumeClaim
metadata:
  name: my-pvc
spec:
  accessModes:
    - ReadWriteOnce
  resources:
    requests:
      storage: 5Gi
```
### Monitoring & Troubleshooting
**11. How do you debug a pod stuck in CrashLoopBackOff?**
```
Check logs: kubectl logs <pod-name>
Describe pod: kubectl describe pod <pod-name>
Run an interactive shell: kubectl exec -it <pod-name> -- /bin/sh
```
### Scaling & Performance Optimization
**12. How does Horizontal Pod Autoscaler (HPA) work?**
```
HPA scales pods based on CPU/memory usage.
```
**Example:**
```
apiVersion: autoscaling/v2
kind: HorizontalPodAutoscaler
metadata:
  name: my-hpa
spec:
  scaleTargetRef:
    apiVersion: apps/v1
    kind: Deployment
    name: my-deployment
  minReplicas: 2
  maxReplicas: 10
  metrics:
  - type: Resource
    resource:
      name: cpu
      target:
        type: Utilization
        averageUtilization: 70
```
**13. How do you optimize resource requests and limits for better performance?**
```
Set appropriate requests and limits:
```
```
resources:
  requests:
    cpu: "500m"
    memory: "256Mi"
  limits:
    cpu: "1000m"
    memory: "512Mi"
Requests: Guaranteed minimum resources.
Limits: Maximum allowed usage.
```
**14. How does Cluster Autoscaler work?**
```
It scales worker nodes up/down based on pending pods.
Works with cloud providers like AWS, GCP, Azure.
Automatically removes underutilized nodes.
```
**15. How do you implement rolling updates in Kubernetes?**
```
apiVersion: apps/v1
kind: Deployment
metadata:
  name: my-app
spec:
  strategy:
    type: RollingUpdate
    rollingUpdate:
      maxUnavailable: 1
      maxSurge: 1
Ensures zero downtime during updates.
```
