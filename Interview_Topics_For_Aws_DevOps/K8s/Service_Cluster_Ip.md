## Service_Cluster_ip

```
appVersion : v1
kind : Service

metadata:
    app:nginx

spec:
    type : ClusterIp
    -ports :
    targetport : 80
    port : 80

    selector : 
    app : nginx
    name : frontend
```
