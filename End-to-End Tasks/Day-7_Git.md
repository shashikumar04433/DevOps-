### Git
```
1.Github vs Git
2.Cvcs vs Dvcs
3.Github complete flow
4.Branching (Create/Delete/rename branch)
5.Git Stash
6.Merging(Conflicts,Branchmerging ,Rebase)
7.Gitignore
8.Gitflow
9..git
10.Cherry pick
11.How to rewrite the commit message in git
12.Git logs
13.Ui(Administration, Branch Protect,Webhooks,Read.md)
```

**Github:**
```
Github is a website that allow devlopers to store and manage the code using git.
```
**git:**
```
It is a used to track changes & collaborate the teams using git.
```
**What is Central version control System?**
```
Central version control System where single server contains all the versions of file.
* if the central repository goes down devlopers cannot commit changes.
* need the internet to make changes and to connect the central version control system.
```
**What is Distributed Version control System?**
```
* Distributed Version control System where each devloper has a copy of the repository.
* need not of the internet for changing the code .
* if the  repository goes down devlopers can still commit changes.
```

**Github Complete Flow**
```
1. Create a repository
2. Create a branch
3. Make changes to the branch
4. Commit the changes
5. Push the changes to the remote repository
6. Create a pull request
7. Merge the pull request
8. Delete the branch
```
**EG:Basic Example:**
```
First we have a cloned repo in the local.
we have added the new code 
1.touch newfile        
                        
2.git add newfile
                                        
3.git commit -m "added new file" 

4.git push origin main
```

**Git Workflow**
```
1.working directory (local )
                         git reset head
                         to completely discard even with the files use 
                         git reset --hard
2.staging area  --------|
                          to completely discard even with the files use after commit 
                          git reset --hard head~1
                          this below command is used for revert the changes and go back to staging area.
                          git reset --soft head~1
3.Remote Repository ------|
```
**example**
```

1. git add newfile
to revert to working directory use below command
- git reset head
to completely discard even with the files use
- git reset --hard
2. git commit -m "added new file"
to revert to staging area use below command
- git reset --soft head~1
(or) to discard all changes use below command
- git reset --hard head~1
```

**Branching Strategy**
```
Branching strategy is used to fix the bugs and devlop on particular part without effecting to the main base code.

Types of Branching:

1. Master Branch
2. Feature Branching
3. Release Branching
4. Hotfix Branching

1.Master Branch  --> Its nothing but main code.

2.Feature Branching --> Its nothing but the new feature code which is added to the main code. or When ever u are working on particular feature to devlop it will be developed on feature branch then it merges with master branch.

3.Release Branching --> Its nothing but new version of the master branch code sent to release branch to go to the end user.

4.Hotfix Branch --> Its nothing but when u have bugs in the production to solve that rapid fix they create a Hotfix Branch.
```
**How to create a Branch**
```
- git branch <branch_name>
eg:
- git branch feature_branch
- git branch release_branch
```
**How to switch to a Branch**
```
- git checkout <branchname>
eg:
- git checkout feature_branch
```
**How to delete a Branch**
```
- git branch -d <branch_name>
eg:
git branch -d feature_branch
git branch -d release_branch
```

**How to rename a Branch**

```

git branch -m <old branch> <new branch>
eg:
git branch -m shashi anand

to directly push from the different branch command
git push --set-upstream origin <branch_name>
```

### What is Git Stash?
```
- Git stash is a command that allows you to save your changes in a temporary place.
- It is useful when you want to switch to another branch, and can keep the under construction work on temorary storage using git stash.

- Git stash ---> It stash all the files and folder
- git stash -- filename --> it allow one file to stash which you wanted too.
- git stash pop --> it is used to remove the files from the stash or from the temporary storage.
- git stash apply <id of stash> --> to bring back the apply id of file or directory to working directory.
- git stash list --> It shows the list of stash files or directories.
- git stash -m "msg" -- <filename> --> It will write the msg for the stashed specific file
- git stash show <id> -->how many changes are included in file or directory.

```
**Command to stash the untracked files**
```
- git stash -u
- git stash --include-untracked 
```


### Merging(Conflicts,Branchmerging ,Rebase)

**git merging**

```
- It is nothing but the merging the changes from one branch to another
main ---a b c 
feature branch -- d e f
- git merge feature_branch 
output -a b c d e f m --> m consists of the merge history
```

**git rebase**
```
- It is nothing but moving the changes from one branch to another.

main ---a b c 
feature branch -- d e f
- git rebase feature_branch 
output -a b c d e f
it doesnt have the history
```

**git conflict**
```
- It occurs when you make the changes in two files of same line or one person have deleted the file and another is modifing that file the error occurs.You need to solve manually only.

- git status --> it shows the conflict files --you can check using git status.
- git diff --> it shows the conflict files
- git add <filename> --> it add the conflict file to staging area
```

**.gitignore**
- It is used to ignore the files or directories which we dont want to push to the remote repository

**.git**
```
It is used to track the changes in the source code
It consists of the log folder ,remote repository branch ids and all the commit information

```

**How to change the git commit message**
```
- git commit --amend -m "new message"
eg:
git commit --amend -m "the msg need to change"
```
**Git Logs**
**Git log is used to view the history of the git repo.You can check all the commit histories.**
- git log

**It displays one line summary of commits:**
- git log --oneline

**To display particular number of logs**
- git log -n 10
**To filter the logs with specified user:**
- git log --author="author name"

**To display the logs based on particular branch**
- git log branch_name

**To display in the form of graph**
- git log --graph


### Cherry-Pick:
**Cherry-pick is a feature that allow to retrive the specific version from the other branches**
```
eg:
- git cherry-pick <commid id>

```
**To abort the merge particular id if u get conflicts:**
```
- git cherry-pick --abort
- git cherry-pick --skip
```

**To skip and continue the cherry pick :**
```
- git cherry-pick --continue
```
