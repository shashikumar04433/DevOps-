## Service_LoadBalancer

```
appVersion : v1
kind : Service

metadata:
    app:nginx

spec:
    type : LoadBalancer
    -ports :
    targetport : 80
    port : 80
    NodePort : 30090

    selector : 
    app : nginx
    name : frontend
```
