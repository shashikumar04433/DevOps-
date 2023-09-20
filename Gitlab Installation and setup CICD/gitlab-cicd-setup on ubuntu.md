## gitlab-cicd-setup on ubuntu

### Maven Installation steps
     1. apt-get update
     2. sudo apt install maven
     3. mvn -version
     4. sudo apt update
     5. sudo apt install default-jdk
     6. java -version
     7. apt install wget
     8.sudo nano /etc/profile.d/maven.sh
     9. export JAVA_HOME=/usr/lib/jvm/default-java
        export M2_HOME=/opt/maven
        export MAVEN_HOME=/opt/maven
        export PATH=${M2_HOME}/bin:${PATH}
     10.sudo chmod +x /etc/profile.d/maven.sh
     11.source /etc/profile.d/maven.sh
     
### Gitlab runner installation on ubuntu:
       1. Simply, Download One Of The Binaries For Your System:
           sudo curl -L --output /usr/local/bin/gitlab-runner "https://gitlab-runner-downloads.s3.amazonaws.com/latest/binaries/gitlab-runner-linux-amd64"
       2. Give It Permission To Execute:
             sudo chmod +x /usr/local/bin/gitlab-runner
       3. Create A GitLab CI User:
             sudo useradd --comment 'GitLab Runner' --create-home gitlab-runner --shell /bin/bash
       4. Install And Run As A Service:
              sudo gitlab-runner install --user=gitlab-runner --working-directory=/home/gitlab-runner
       5. As we above created a user whose name is “gitlab-runner” should have permission to execute the command in your server.
              vi /etc/sudoers
              gitlab-runner ALL=(ALL:ALL) NOPASSWD: ALL

             

        
      
