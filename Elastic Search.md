# Elastic Search Engine:
        ELK----> Elastic Search,Logstash,Kibana.
        *  Elastic Search it is a Search Engine & it is used for Analytics.
           Eg:Google Search Engine.
           
### Process of Elastic Search:

        * Application----> Data ---->Logstash--->Elastic Search--->Kibana

## Installation Process of Elastic Search Engine:
sudo su
    
   
    apt-get install apt-transport-https~
    apt-get install apt-transport-https
    echo "deb https://artifacts.elastic.co/packages/7.x/apt stable main" | sudo tee –a /etc/apt/sources.list.d/elastic-7.x.list
    apt-get update
    apt-get install elasticsearch
    vim /etc/elasticsearch/elasticsearch.yml
    vim /etc/elasticsearch/jvm.options
    systemctl start elasticsearch.service
    systemctl enable elasticsearch.service
    curl -X GET "172.31.34.157:9200"

        Download and install the RPM manually using below link:
        
      Step1: 
            sudo su
            apt-get install openjdk-8-jdk
      
      Step2: 
              wget -qO - https://artifacts.elastic.co/GPG-KEY-elasticsearch | sudo apt-key add -
      
      Step3: 
             apt-get install apt-transport-https
      
      Step4:  
             systemctl demon-reload
      
      Step5: 
             systemctl enable elasticsearch.service
      
      Step6: 
             systemctl Start elasticsearch.service
      
      Step7: Go to 
              vi ./etc/elasticsearch/elasticsearch.yml 
      Step8:
              Edit : Uncmment and put ur private id :
                network.host: 172.31.46.149 (its ur private ip)
                http.port: 9200
                discovery.seed_hosts: 172.31.46.149 (its ur private ip)
       Step9:
                service elasticsearch restart
                service elasticsearch status
                
       Step10: 
                ip:9200
                
        
       
             
