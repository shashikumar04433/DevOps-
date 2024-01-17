## Aws Code Commit:

**Advantages of Code Commit**
```
* Managed git

* Scalability

* Reliability
```

**How to create and connect Aws code commit to local using gitbash**
```
* create a Iam User and add the policies attach and add AWSCodeCommitPowerUser.

* Then create a git credentials on security credential header.
  Below third type one.<HTTPS Git credentials for AWS CodeCommit
  HTTPS Git credentials for AWS CodeCommit> in this .Save the credentials.

* git clone <link of repo>

* Then add the user and password of the git credentials of which created.

* git add .

* git status

* git commit -m "added"

* git remote add https://git-codecommit.ap-south-1.amazonaws.com/v1/repos/FCRA

* git fetch

* git remote add fcra https://git-codecommit.ap-south-1.amazonaws.com/v1/repos/FCRA

* git status

* git push --set-upstream fcra master

```
**DisAdvantages of Code Commit**
```
* Features
* Aws Restricted
* Less Integration with services outside Aws.
```
