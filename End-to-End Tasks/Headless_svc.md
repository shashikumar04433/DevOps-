## Headless_svc:
```
A headless service in Kubernetes is a service that does not have a ClusterIP (clusterIP: None).
Instead of providing a single virtual IP to balance traffic, it allows direct access to individual pod IPs.

Headless services are useful for stateful applications, where clients need to
communicate with specific pods rather than being load-balanced.

```
**eg1**
```
When clusterIP: None is set, Kubernetes does not assign a virtual IP.
```
**Eg2**
```
apiVersion: v1
kind: Service
metadata:
  name: my-headless-service
spec:
  clusterIP: None  # Headless service
  selector:
    app: my-app
  ports:
    - protocol: TCP
      port: 80
```
