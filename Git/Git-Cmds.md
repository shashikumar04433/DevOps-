# Git-Basic-Commands-
## There are 3 steps of Git push :
      1.WorkPlace.
      2.Staging.
      3.Commit changes.

## Commands of the git are:
      git clone ""path of the file which copied in the github code part"
### Command to see the version of git:
     Git --version
### Command to clone the files:
### Command to configure using the mail :
    git config --global user.email"shashikumar04433@gmail.com"

### Command to configure using name:
    git config --glbal user.name"shashikumar"

### Command to configure using editor:
    git config --global core.editor "code --wait"

### Command to handle end of lines:
    git config --global core.autocrlf input
    
### Command to edit global default settings:
    git config --global -e
### Command to make changes which you updated or Taking snapshots of your project:
    git commit -m "write the reason why you changed"
### Command to add the file:
    git add filename
### Command to know what all commands are there:
    git --help

### Command to show which all basic commands present in git :
    git --h
### Commmand to list all file present in directory:
    ls -a
### Command to initialize the empty git repository:
    get init
### Command to change all modified files:
    git commit -a -m "message why what you changed"
### Command to remove the file in Directory:
    rm filename
### Command to list only the  files:
    git ls-files
### Command to restore the deleted file from staging:
    git restore --staged filename
### Command to move the file or directory to another.
    mv file.txt file1.py
### Command to remove Directory.
    rm -r directory name
### Command to make directory.
    mkdir name of the directory which you want to create.
### Command to ignore the file or directory in Git:
    echo logs/>.gitignore
### Command to see the status of staging area:
    git status -s
### Command to change all modified files:
    git status -am "All modified files"
### Command to allow us to track the changes that are staged but not committed:
    git diff --staged
### Command to remove showing another git process seems running in this repo.
    rm -f .git/index.lock
    
### Commmand to see history in git and after command press space button to see next page history:
    git log
  
### Command to show last page changes in git:
    git log --online
### Command to reverse the history which shows latest command in the last:
    git log --online --reverse

### Command to view last commit (we can see what changed)
    git show head
 
### Command to see previous commit:
    git show head~2(2 is the number like last 2 nd line)
### Command to see all directories and files:
    git ls-tree head~1
### Objects of the Git:
    1)Commits.
    2)Blobs(Files).
    3)Trees(Directories).
    4)Tags.
### Discard changes are remove changes in git:
    git restore filename
### Command to clean or delete all files permanently:
    git clean 
### Command to take help in git:
    git clean -h
### Command to restoring a file to an earlier version :
    step1:
         git rm filename
    step2:
         git log --online
    step3:
         git restore -h
    step4:
         git resource --source =head~1 filename
    step5:
         git status -s
         

         
         
         
    
         
