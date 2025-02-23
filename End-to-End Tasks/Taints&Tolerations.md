## Taint & Tolerations:
```
* Taints are key-value pairs that are attached to a node or a pod. 
```
### Types of Taints:
- **NoSchedule**
```
* The scheduler will not schedule any pod on this node unless the pod has a matching toleration.
* kubectl taint nodes <node-name> key=value:NoSchedule
```
- **PreferNoSchedule**
```
* The scheduler tries to avoid placing pods on this node, but it may still schedule a pod there if necessary.
* kubectl taint nodes <node-name> key=value:PreferNoSchedule
```
- **NoExecute**
```
* The scheduler will not schedule new pods, and existing pods that do not tolerate the taint will be evicted from the node.
* kubectl taint nodes <node-name> key=value:NoExecute
```
