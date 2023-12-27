##  To get into container & install the telnet in container:

	kubectl exec -it <podid > -n namespacename /bin/sh
	kubectl exec -it core-deployment-5446479b7f-dnrgm -n ingress-nginx /bin/sh


# Update the package index

	apk update
 
# Install telnet inside the container.

	apk add --no-cache --repository http://dl-cdn.alpinelinux.org/alpine/edge/main/ telnet
 
# Start your application or shell

	sh

	apk add --no-cache busybox-extras
