## Profiles and their uses:
```
* aws configure --profile myprofile
```
## unsetting or deleting the profile
```
* aws configure unset aws_access_key_id --profile myprofile
* aws configure unset aws_secret_access_key --profile myprofile
* aws configure unset aws_session_token --profile myprofile
```
## To check which user name and account id is using with aws configure use below command:
```
* aws iam get-user
(or)
* aws sts get-caller-identity
```
