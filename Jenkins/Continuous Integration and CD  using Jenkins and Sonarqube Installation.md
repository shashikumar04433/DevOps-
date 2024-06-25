# Installtion of Jenkins and Sonarqube on Redhat Linux:

    Step1:
       sudo yum update
       sudo yum install java-11-openjdk-devel unzip vim wget -y
       yum update
       
    Step2:
          Stable version 
          sudo wget https://binaries.sonarsource.com/Distribution/sonarqube/sonarqube-7.6.zip
          ls
          useradd sonar
          passwd sonar
          unzip sonarqube-7.6.zip
          mv sonarqube-7.6 /opt/sonar
          cd /opt/
          cd /home/ec2-user/
 Step3:
 
        sudo su - sonar
        chown -R sonar:sonar /opt/sonar/
        sudo su - sonar


# Installation of Jenkins on Redhat:

         sudo wget -O /etc/yum.repos.d/jenkins.repo https://pkg.jenkins.io/redhat-stable/jenkins.repo
         sudo rpm --import https://pkg.jenkins.io/redhat-stable/jenkins.io-2023.key
         yum install fontconfig java-11-openjdk
         yum install jenkins

## Setup of Sonar integration in jenkins:
        * Install Sonarqube Scanner and Deploy to Container to work Ci/CD in Jenkins.
        * Go to plugin and install that both above plugins.
        * To do that first create a token in Sonarqube
        * Then goto the jenkins system and update it there with the credentials and link eg http://3.1.206.171:9000 
        * Then create a job and paste the link on git 
        * In the executive shell write a command:
            mvn clean
            mvn package sonar:sonar
        * Then Build now.
        
        
