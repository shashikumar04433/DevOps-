## What is Pod Eviction :

```
Pod eviction in Kubernetes happens when a pod is forcibly removed from a node. 
This can happen due to resource constraints, node failures, or policy enforcement.
```
**Common Reasons for Pod Eviction**
```
Common Reasons for Pod Eviction
Node Pressure (Resource Shortage)

* If a node runs out of memory (OOM) or CPU, Kubernetes evicts less critical pods to free up resources.
* Kubernetes uses Eviction Thresholds (kubelet monitors resource usage).
* Node Drain (Maintenance or Upgrade)

* When a node is drained (kubectl drain <node>), all running pods are evicted.
* Used for node upgrades, maintenance, or scaling down a cluster.
* Taints and Tolerations (NoExecute Taint)

* If a node gets a taint with NoExecute, all pods that don’t tolerate the taint are evicted.
```

