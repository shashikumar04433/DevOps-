
# Rsyncing Two Servers.

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
