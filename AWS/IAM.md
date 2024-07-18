### IAM (Identity access Management)

- IAM is a service that helps you securely control access to AWS resources.
- IAM is a web service that enables you to manage users and user permissions across the AWS cloud.

**Types in Identity Access Management:**
- Users ----|Identity
- Roles ----|Identity
- Policies --|Access
- Groups --- |Management



### User 
Create a User named s3 and choose password as custom password then save that credentials  and attach the s3 full access policy.

- Open in incgnito window and and enter the iam username and password of above created.

- You should be able to access only s3 not any other resource.


### Policies
```
- Policies are documents that define one or more permissions.
```

#### Three types of policies in aws:
**Aws managed policies**
```
It managed by aws .
```
**Customer managed policies**
```
Policies should be written by you .
```
**Inline policies**
```
Policies are attached to the resource directly within that resource only.
```
## Roles:
```
- Roles are used to grant permissions to services, applications, and tools.
- Roles are not associated with a specific user, but they can be assumed by a user.
- Roles can be assumed by a user, a service, or an application.
```

## Groups:
```
- Groups are used to manage permissions for multiple users.
- Groups can be used to assign permissions to multiple users at once.
db team - 1 policy
dev team - 1 policy

```
