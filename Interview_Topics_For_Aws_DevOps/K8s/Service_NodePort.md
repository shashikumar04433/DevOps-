## Service_NodePort

```
appVersion : v1
kind : Service

metadata:
    app:nginx

spec:
    type : NodePort
    -ports :
    targetport : 80
    port : 80
    NodePort : 30080

    selector : 
    app : nginx
    name : frontend
```
