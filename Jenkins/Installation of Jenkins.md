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
        
