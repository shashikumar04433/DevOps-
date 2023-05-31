# JBoss Installation:
        Step1:
        
            To install the tar or zip file :
            https://github.com/wildfly/wildfly/releases/download/28.0.1.Final/wildfly-28.0.1.Final.tar.gz
            
        Step2:
            tar -xvzf jboss-eap-7.4.0.zip
      
        Step3:
             cd jboss-eap-7.4.0.zip
             cd standalone
             cd configuration
             vi standalone.xml
        Step4:
              * Change 127.0.0.1 to your private ip in 3 places.
              * cd bin 
              * add user in bin:
              * sh add-user.sh
              * choose management user.
              * set passwd
              * sh standalone.sh
              * http://ip:8080
             

