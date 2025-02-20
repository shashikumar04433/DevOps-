## Namespace

```
appVersion : v1
kind : namespace

metadata:
    name:dev

```

**To make other namespace for default use below command**
```
kubectl config set-context $(kubectl config current-context) --namespace = dev
```
