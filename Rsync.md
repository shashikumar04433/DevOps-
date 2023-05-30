
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
                           
                    * if suppose u forform with user example shashi:
                           generate ssh-keygen in user then paste id_rsa.pub in S2 then run below command:
                            rsync -av -e ssh /home/shashi/manishproject/* root@172.31.6.43:/home/ec2-user/shashifold/
                     
 ### For creating cronjobs(which is autosyncing of two servers)
                  mkdir source in S1 server
                  mkdir destination in S2 server
                   create .sh file 
                           
                          * example: backing.sh
                          *  vi backing.sh
                          *  !#/bin/bash
                          * /usr/bin/rsync -av -e ssh /root/source/* root@172.31.3.142:/root/destination
                          
                     Then create crontab -e write inside that:
                     
                                    contab -e
                                    * * * * * bash /root/backing.sh  (syntax)
                                     min hour day week month bash /root/backing.sh
                           Example:
                                    33 05 * * * bash /root/backing.sh
                           
                           Then check logs in :
                                    * tail -f /var/log/corn
                    
                     If suppose you have created user name mani in S2 server all the source files should visible in shashi user in                                destination folder :

                   
                   

                
