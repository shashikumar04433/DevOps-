
# Rsyncing Two Servers.
         Pre-requirement :
          * Perform all this in root folder so that u wont get any problem.
          * If u want to perform in any other user create the user and give permissions as root:
            useradd username
            passwd username
            chown -R username:username /root/
       
       * First launch a two servers think example of S1 and S2 :

           Step1:
                 Go to server s1 and generate ssh-keygen
           Step2:
                 Go to:
                  cd ~/.ssh
                  vi id_rsa.pub
                  copy the script
            Step3:
                  Go to S2 server:
                     cd ~/.ssh
                     vi authorized_keys
                     paste the copied code from s1 server.
             Step4:
                   Now come back to S1 server:
                   * visudo
                   if u have created user then give the nopasswd=all
                   like below:
                   * shashi  ALL=(ALL)  NOPASSWD:ALL
                    
                    Now goto :
                             cd /etc/ssh/
                             vi sshd_config
                    at the last line make  permission-yes
                    In S1:
                           mkdir folders
                    In S2: 
                           mkdir folders
                    In S1:
                           rsync -av -e ssh /root/folders/* root@172.31.6.43:/home/ec2-user/shashifold
                           
                    * if suppose u forform with user ex shashi:
                           rsync -av -e ssh /shashi/folders/* root@172.31.6.43:/home/ec2-user/shashifold
                           
                    
                   
                   

                
