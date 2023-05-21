# Elastic Search Engine:
        ELK----> Elastic Search,Logstash,Kibana.
        *  Elastic Search it is a Search Engine & it is used for Analytics.
           Eg:Google Search Engine.
           
### Process of Elastic Search:

        * Application----> Data ---->Logstash--->Elastic Search--->Kibana

## Installation Process of Elastic Search Engine:

        Download and install ElasticSearch :
        
      Step1: 
            sudo su
            apt-get install openjdk-8-jdk
      
      Step2: 
              wget -qO - https://artifacts.elastic.co/GPG-KEY-elasticsearch | sudo apt-key add -
      
      Step3: 
             apt-get install apt-transport-https
      
      Step4:  
             echo "deb https://artifacts.elastic.co/packages/7.x/apt stable main" | sudo tee –a /etc/apt/sources.list.d/elastic-7.x.list
              apt-get update
      Step5: 
            apt-get install elasticsearch
      
      Step6: 
             apt-get install vim
             vim /etc/elasticsearch/elasticsearch.yml
              Edit : Uncmment and put ur private id :
                network.host: private ip (its ur private ip)
                http.port: 9200
                discovery.seed_hosts: private ip (its ur private ip)
             
      
      Step7: Go to 
              vim /etc/elasticsearch/jvm.options   (This is to give the size of jvm)
              edit:
              -Xms512m 
              -Xmx512m
              
      Step8:
                systemctl start elasticsearch.service
                systemctl enable elasticsearch.service
         
       Step9: 
                curl -X GET "172.31.34.157:9200" 
                (or)
                ip:9200 (in web)
                
        
       
             
