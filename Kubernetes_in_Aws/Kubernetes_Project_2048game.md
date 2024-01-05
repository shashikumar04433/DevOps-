## Kubernetes Project using eks with 2048-game :

**Pre-Requirements:**
```
* Install the Aws-Cli, Eksctl, Kubectl in the Server that steps can be check in the kubernetes_with_aws.md .
```

**Save the file ad deploy.yaml and apply it**
```
apiVersion: apps/v1
kind: Deployment
metadata:
  name: eks-sample-linux-deployment
  labels:
    app: eks-sample-linux-app
spec:
  replicas: 3
  selector:
    matchLabels:
      app: eks-sample-linux-app
  template:
    metadata:
      labels:
        app: eks-sample-linux-app
    spec:
      affinity:
        nodeAffinity:
          requiredDuringSchedulingIgnoredDuringExecution:
            nodeSelectorTerms:
            - matchExpressions:
              - key: kubernetes.io/arch
                operator: In
                values:
                - amd64
                - arm64
      containers:
      - name: nginx
        image: public.ecr.aws/nginx/nginx:1.23
        ports:
        - name: http
          containerPort: 80
        imagePullPolicy: IfNotPresent
      nodeSelector:
    kubernetes.io/os: linux
```
**deploy the yaml file using below command**
```
kubectl apply -f deploy.yaml
```
**Copy the below file as service.yml**
```
apiVersion: v1
kind: Service
metadata:
  name: eks-sample-linux-service
  labels:
    app: eks-sample-linux-app
spec:
  selector:
    app: eks-sample-linux-app
  ports:
    - protocol: TCP
      port: 80
```
**Deploy the service**
```
kubectl apply -f service.yaml
```
**Install using Fargate**
**creating cluster and creating fargate:**
```
* eksctl create cluster --demo2 --region ap-south-1 --fargate
```
**command to delete the cluster**
```
* eksctl delete cluster --name demo1 --region ap-south-1
```
**Command to update the cluster which you want to work on**
```
aws eks update-kubeconfig --name demo2 --region ap-south-1
```
**Create Fargate profile:**  
```
eksctl create fargateprofile \
    --cluster demo2 \
    --region ap-south-1 \
    --name alb-sample-app \
    --namespace game-2048
```
**Deploy the deployment, service and Ingress**
```
kubectl apply -f https://raw.githubusercontent.com/kubernetes-sigs/aws-load-balancer-controller/v2.5.4/docs/examples/2048/2048_full.yaml
```
**commands to configure IAM OIDC provider**
```
eksctl utils associate-iam-oidc-provider --cluster demo2 --approve
```
**Commands to setup alb add on to your cluster**

Download IAM policy by below command
```
curl -O https://raw.githubusercontent.com/kubernetes-sigs/aws-load-balancer-controller/v2.5.4/docs/install/iam_policy.json
```
**Create IAM Policy use below commands**
```
aws iam create-policy \
    --policy-name AWSLoadBalancerControllerIAMPolicy \
    --policy-document file://iam_policy.json
```
**Command to create a IAM Role**
```
eksctl create iamserviceaccount \
  --cluster=<your-cluster-name> \
  --namespace=kube-system \
  --name=aws-load-balancer-controller \
  --role-name AmazonEKSLoadBalancerControllerRole \
  --attach-policy-arn=arn:aws:iam::<your-aws-account-id>:policy/AWSLoadBalancerControllerIAMPolicy \
  --approve
```
**Command to Deploy ALB controller**

Add helm repo in server with below command
```
helm repo add eks https://aws.github.io/eks-charts
```
**Update the repo with below command**
```
helm repo update eks
```
**Install the Helm packages**
```
helm install aws-load-balancer-controller eks/aws-load-balancer-controller \            
  -n kube-system \
  --set clusterName=<your-cluster-name> \
  --set serviceAccount.create=false \
  --set serviceAccount.name=aws-load-balancer-controller \
  --set region=<region> \
  --set vpcId=<your-vpc-id>
```
**Verify that the deployments are running.**
```
* kubectl get deployment -n kube-system aws-load-balancer-controller
* kubectl get pods -n game-2048
* kubectl get ingress -n game-2048
**Wait till the alb create and then you can find the ingress loadbalancer link paste that in google then you can 2048 game.THANK YOU**
```




