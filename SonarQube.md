# SonarQube:

* What is SonarQube?

      SonarQube is a Software tool which it helps Devlopers to check the quality of the code,
      bugs and Vulnerability(Possibility of the attacks).
  
 ## Features of SonarQube:
      It helps finding the:
      * Code Quality.
      * Bugs Identification.
      * Code Duplication.
      * Code Coverage.
      * Unit Test Cases.
      
## Installation on SonarQube Steps:
      
      Pre-Requirements of Installation:
      It must have 4 CPUs or 4 GB of RAM workspace required to work on SonarQube.
      
      step1:
            Install java
            sudo java-11-openjdk-devel wget unzip -y
       step2:
            Go to SonarQube Downloads:
                  wget https://binaries.sonarsource.com/Distribution/sonarqube/sonarqube-9.1.0.47736.zip
                  
        step3:
              Install unzip command.
              Yum install unzip
        step4:
              sudo unzip https://binaries.sonarsource.com/Distribution/sonarqube/sonarqube-9.1.0.47736.zip 
             
             
 ## Setup Requirements to Work on SonarQube:
            Use the T2 Medium instant type :
            1. Add user to perform in Sonar cube (Dont run as Root for the best practises).
                  useradd sonar
            2. passwd shashi
                  set password
            3. Set the permissions using Chown:
                  chown -R sonar:sonar sonar/  (it creates all same permission through out the sonarqube directory)
            4. Then go to bin folder:
                cd bin
                 cd linux.
             5. Then start the sonar.
                  sh sonar.sh start
             6.To check the status of the sonar:
                  sh sonar.sh status  and check the port (ip:9090).
                  User id & passwd:
                  admin 
                  admin
                  
