## kubernetes_lab_commands:


**To check the how many images and what images are there in pod**
```
kubectl describe pod webapp | grep -i "image"
```
**to create the pod**
```
kubectl run nginx --image=nginx
```
**to delete the pod**
```
kubectl delete pod nginx
```
**To check the pod running on which node and which ip and state of it**
```
kubectl get pod nginx -o wide
```
**To check the logs of the pod**
```
kubectl logs nginx
```
**To check the events of the pod**
```
kubectl get events -o wide
```
**You have create the name of the pod using**
```
kubectl run nginx --image=nginx --restart=Never

now need to change nginx to nginxnew

* kubectl edit nginx 
then edit in that yaml to nginxnew
```
