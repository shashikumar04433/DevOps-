## Gitlab Ci/Cd using GitRunner on Windows:

#### Pre-Requirements:

                Step1:
                *  Install the Gitlab runner in windows using following link <https://docs.gitlab.com/runner/install/windows.html>
        
        
                Step2:
                * Change the name of the folder as <gitlab-runner>
        
        
                Step3:
                * Then run cmd as Administartor and copy the path of the <gitlab runner of your local where gitlab runner downloaded> and                    paste in cmd.
        
        
                Step4:
                * gitlab-runner.exe install
                * gitlab-runner.exe --version
                * gitlab-runner.exe start 
                * gitlab-runner.exe run

                Step5:
                Then go into gitlab.com and there go into ci/cd then runner generate token
                * gitlab-runner.exe register
                * https://gitlab.com
                * then enter the token in gitlab one which u creted for gitlab runner
                * name any 
                * gitlab-runner.exe start 

                Step6:
                 Write a Yaml file for the project which you wanna perform Ci/Cd:
                 Eg:
                     image: openjdk:11
                     
                        stages:
                          - build
                          - deploy
                         
                        
                        before_script:
                          - chmod +x gradlew  
                          # Name of the deployable artifact
         
                        build:
                          stage: build
                          script:
                            - echo "Building the web application"
                            - ./gradlew build
                          artifacts:
                            paths:
                              - ./build/libs/
                        
                        deploy:
                          stage: deploy
                          script:
                          - ./gradlew build
                          - ls -l build/libs/   # List files in the build/libs directory for 
                          - cp -r ./build/libs/*.jar guptamanish2110/ManishKhardProject/zyx
                          only:
                            - main


                    Step7:

                          Yaml file eg for Java and Maven project:

                          # Specify the GitLab Runner image to use
                          
                          image: maven:latest
                          
                          # Define stages for the CI/CD pipeline
                          stages:
                            - build
                            - deploy
                          
                          # Define jobs for each stage
                          build:
                            stage: build
                            script:
                              - mvn clean install
                            artifacts:
                              paths:
                                - target/*.jar
                          
                          deploy:
                            stage: deploy
                            script:
                              - echo "Deploying..."
                              - scp -P 22 -r target/*.jar shashi.reddy@10.76.150.183:\C:\Users\shashi.reddy\Downloads\javaapp
                            only:
                              - main
                                               

                 
                 

                
                
                
              
            
