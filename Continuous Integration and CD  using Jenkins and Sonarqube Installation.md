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
