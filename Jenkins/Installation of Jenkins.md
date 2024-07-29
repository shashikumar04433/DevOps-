## Installation steps of jenkins.

   Step1:
  
        sudo wget -O /etc/yum.repos.d/jenkins.repo \
        https://pkg.jenkins.io/redhat-stable/jenkins.repo
        
   Step2:
   
        sudo rpm --import https://pkg.jenkins.io/redhat-stable/jenkins.io-2023.key
        sudo dnf upgrade
        
###  Add required dependencies for the jenkins package:

   Step3:

        sudo dnf install java-17-openjdk
        sudo dnf install jenkins
        sudo systemctl daemon-reload
        
## Installation steps of jenkins on ubuntu.

Step1:
```
      sudo apt update
      sudo apt install openjdk-11-jdk -y
```
Step2:
```
      curl -fsSL https://pkg.jenkins.io/debian-stable/jenkins.io-2023.key | sudo tee \
/usr/share/keyrings/jenkins-keyring.asc > /dev/null
echo deb [signed-by=/usr/share/keyrings/jenkins-keyring.asc] \
https://pkg.jenkins.io/debian-stable binary/ | sudo tee \
/etc/apt/sources.list.d/jenkins.list > /dev/null
```
Step3:
```
      sudo apt update
      sudo apt install jenkins -y
```


