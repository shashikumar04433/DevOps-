### RBAC (Role Based Access Control) in K8s:
```
RBAC is a method of controlling access to resources in a Kubernetes cluster.
It is based on the concept of roles, which are collections of permissions that can be assigned to users
or service accounts.
```

**Key RBAC Components**
**Roles & ClusterRoles**

**Role**
```
Defines permissions within a specific namespace.
```
**ClusterRole**
```
Defines permissions cluster-wide across all namespaces.
```

**RoleBindings & ClusterRoleBindings**
**RoleBinding** 
```
Grants a Role's permissions to a user, group, or service account in a specific namespace.
```
**ClusterRoleBinding**
```
Grants a ClusterRole's permissions to a user, group, or service account across the cluster.
```

**Eg to check role assigned  or not**
```
kubectl auth can-i --as system:serviceaccount:test:foo get pods -n test
```
```
role.yml
```
```
apiVersion: rbac.authorization.k8s.io/v1
kind: Role
metadata:
  namespace: test
  name: testadmin
rules:
  - apiGroups: ["*"]
    resources: ["*"]
    verbs: ["*"]
```
rolebinding.yml
```
apiVersion: rbac.authorization.k8s.io/v1
kind: RoleBinding
metadata:
  namespace: test
  name: testadmin-binding
subjects:
  - kind: ServiceAccount
    name: foo  # Replace with actual service account name
    namespace: test
roleRef:
  kind: Role
  name: testadmin
  apiGroup: rbac.authorization.k8s.io
```
```
kubectl auth can-i --as system:serviceaccount:test:foo get pods -n test
```


**Cluster Binding with Role**
```
ClusterRole
```
```
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRole
metadata:
  name: cluster-admin-role
rules:
  - apiGroups: ["*"]
    resources: ["*"]
    verbs: ["*"]
```

```
ClusterRoleBinding
```
```
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRoleBinding
metadata:
  name: cluster-admin-binding
subjects:
  - kind: ServiceAccount
    name: foo 
    apiGroup: ""
    namespace: test
roleRef:
  kind: ClusterRole
  name: cluster-admin
  apiGroup: ""
```
**Testing the RBAC**
```
kubectl auth can-i --as system:serviceaccount:test:foo create deployment -n all
If you applied cluster yml then only it shows yes otherwise
it shows no as it doesnt have all permissions with in the cluster.
```

**Full List of RBAC Verbs**
```
Verb -->Description
get	--> Retrieve a specific resource
list -->List multiple resources
watch-->Monitor resources for changes
create-->Add new resources
update-->Modify existing resources
patch-->Partially modify a resource
delete-->Remove a resource
bind-->Attach roles to users or groups
escalate-->Grant higher permissions (modify RBAC roles)
* --> All possible actions (admin-level access)
```
**Types of Access in RBAC**
**Read-Only Access**
```
Allows users to view resources but not modify them.
verbs: ["get", "list", "watch"]
```
**Read-Write Access**
```
Allows users to view and modify resources.
verbs: ["get", "list", "watch", "create", "update", "patch"]
```
**Delete Access**
```
Allows users to remove resources.
verbs: ["delete"]
```
**Full Admin Access**
```
Grants full control over resources.
verbs: ["*"]
```
**Escalation Privileges**
```
Allows modifying RBAC roles and permissions.
verbs: ["bind", "escalate"]
```
 
