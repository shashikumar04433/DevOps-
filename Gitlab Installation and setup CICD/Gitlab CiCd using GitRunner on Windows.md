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
                     

                 
                 

                
                
                
              
            
