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
            sudo java-11-openjdk-devel -y
       step2:
            Go to SonarQube Downloads:
                  wget https://binaries.sonarsource.com/Distribution/sonarqube/sonarqube-9.9.1.69595.zip?_gl=1*1kog3oh*_ga*MTg2ODY3OTQ3Mi4xNjg0MjEyNjA1*_ga_9JZ0GZ5TC6*MTY4NDIxMjYwNC4xLjEuMTY4NDIxNTg2Ni41NC4wLjA.
                  
        step3:
              Install unzip command.
              Yum install unzip
        step4:
              sudo unzip https://binaries.sonarsource.com/Distribution/sonarqube/sonarqube-9.9.1.69595.zip?_gl=1*1kog3oh*_ga*MTg2ODY3OTQ3Mi4xNjg0MjEyNjA1*_ga_9JZ0GZ5TC6*MTY4NDIxMjYwNC4xLjEuMTY4NDIxNTg2Ni41NC4wLjA. 
             
             
 ## Setup Requirements to Work on SonarQube:
            1. Add user to perform in Sonar cube (Dont run as Root for the best practises).
                  useradd sonar
            2. passwd shashi
                  set password
            3. Set the permissions using Chown:
                  chown -R sonar:sonar sonar/  (it creates all same permission through out the sonarqube directory)
            4. Then go to bin folder:
                cd bin
                vim linux (linux folder as we are working in linux).
                Uncomment Run_as_user=sonar
             5. Then start the sonar.
                  sh sonar.sh start
             6.To check the status of the sonar:
                  sh sonar.sh status 
