### Kubernetes Interview Questions

Kubernetes architecture:

1.Master Node:
- API Server -->It manages and validates cluster resources.
- etcd --> (key value store)
- Controller Manager ---> It controls nodes to creating updating and deleting the pods.
- Scheduler --> It is responsible for scheduling the pods to the worker nodes.



2.Worker Node
- Kubelet --> It is responsible for managing the pods on the worker node.
- kube-proxy --> It is responsible for managing the network traffic in the cluster.
- Container Runtime --> It handles the running the container


- What is pod ?
Pod is a smallest deployable unit in k8s.

- What is a service in k8s?
Service is a way to expose the pods to the outside world.

Types of services in k8s?

- ClusterIP --> we can access it with in the node only.
- node port --> It will expose with in the internal excess for node to node connection.
- Load Balancer --> It will expose the service to the outside world.
- External Name --> (dns)It will expose the service to the outside world .


-What is Replicaset?
Replicaset is nothing but we mention in deployment.yaml  how many pods need to be created.

-What is Deployment?
Deployment is a way to manage the pods in k8s.Like rollback updates.

-What is Statefulset?
It manages stateful application where each pod has a unique identity and stable storage.

- Namespace?
 Namespace is a way to divide cluster resources between multiple users or teams

 - Configmaps?
It is used to non-sensitive data like environment variables.

- Secrets?
It is used to sensitive data like passwords and tokens.

what is Persistent Volumes (PV) and Persistent Volume Claims (PVC)?

PV is a storage in the cluster provided by the admin. PVC is a request.

What are helm Charts?
Helm is a package manager for k8s. It is used to manage the deployment of applications.

How does Kubernetes ensure high availability?
Kubernetes ensures high availability by using multiple replicas of pods and services, as well as by using mechanisms.

Ingress ?
Ingress  is a component that manages the incoming traffic to the cluster.

Egress ?
Egress  is a component that manages the outgoing traffic from the cluster.

What is Observability?
It is used to monitor and diagnose the behaviour and performance of a kubernetes cluster.





### Jenkins

1.How do you secure jenkins?

You can secure the jenkins using RBAC (Role Based Access)
You can also use the jenkins credentials plugin to store the credentials securely in the jenkins server.
And configuring the https to the jenkins server .


2.How do you configure jenkins to build a docker image?
You can configure jenkins to build a docker image by using the docker plugin in jenkins.
You can also use the jenkins pipeline to build the docker image.






