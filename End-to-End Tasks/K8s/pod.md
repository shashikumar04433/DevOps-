appVersion : v1
kind : Pod
metadata :
  name : nginx
  Labels:
  app : nginx

spec:
  containers:
  - name : nginx
  image : nginx:latest
  imagePort : 80
