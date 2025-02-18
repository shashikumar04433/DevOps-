1. What is GitHub and how does it differ from Git?
Answer: GitHub is a cloud-based platform for hosting and managing Git repositories. It provides features like issue tracking, pull requests, and code reviews. Git is a version control system used to track changes in source code. While Git is a command-line tool that manages code repositories locally, GitHub provides a web-based interface and additional collaboration tools to enhance team workflows.

2. Explain the process of creating a new repository on GitHub.
Answer: To create a new repository on GitHub:
Log in to your GitHub account.
Click on the "+" icon in the top-right corner and select "New repository."
Enter a repository name and optional description.
Choose the repository visibility (public or private).
Initialize the repository with a README if desired.
Click "Create repository" to finalize.

3. What is a pull request and how do you create one?
Answer: A pull request (PR) is a request to merge code changes from one branch into another, typically from a feature branch into the main branch. To create a PR:
Push your branch to GitHub.
Go to the repository on GitHub and switch to the branch with your changes.
Click on "Pull requests" and then "New pull request."
Select the base branch (e.g., main) and the compare branch (your feature branch).
Review the changes, add a title and description, then click "Create pull request."

4. What are GitHub Actions, and how can you use them in your workflow?
Answer: GitHub Actions is a CI/CD and automation tool that allows you to create workflows to build, test, and deploy code. You define workflows using YAML files in the .github/workflows directory of your repository. Actions can be triggered by various events like pushes, pull requests, or scheduled intervals, enabling automated processes such as running tests, building applications, or deploying code.

5. How do you handle merge conflicts in GitHub?
Answer: To handle merge conflicts:
Pull the latest changes from the base branch to your feature branch.
Resolve conflicts in the affected files by manually editing the code to combine changes.
After resolving conflicts, mark the files as resolved with git add.
Commit the resolved changes using git commit.
Push the changes to GitHub.
Update the pull request to reflect the resolved conflicts.

6. Explain the difference between git merge and git rebase.
Answer: git merge combines changes from different branches and creates a merge commit, preserving the history of both branches. git rebase integrates changes by applying commits from one branch onto another branch, resulting in a linear history without merge commits. Rebase can simplify history but alters commit hashes, which can be problematic for shared branches.

7. What is a GitHub fork, and how is it different from a branch?
Answer: A GitHub fork is a copy of a repository under a different account, allowing independent development or experimentation without affecting the original repository. A branch is a parallel version of a repository within the same account, used to manage different features or versions of the project. Forks are typically used for contributing to other projects, while branches are used for collaboration within the same project.

8. How do you revert a commit in GitHub?
Answer: To revert a commit:
Use git log to identify the commit hash you want to revert.
Run git revert <commit-hash> to create a new commit that undoes the changes.
Push the new commit to GitHub.

9. What are Git tags, and how do you create and use them?
Answer: Git tags are used to mark specific points in history, typically for releases. To create a tag:
Use git tag <tag-name> to create a lightweight tag.
For annotated tags, use git tag -a <tag-name> -m "Tag message".
Push tags to GitHub with git push origin <tag-name>.
Tags can be used to reference specific versions in releases or deployments.

10. How do you view the commit history in GitHub?
Answer: To view commit history:
Navigate to the repository on GitHub.
Click on "Commits" to see a list of all commits.
Click on individual commit hashes to view details and changes associated with each commit.