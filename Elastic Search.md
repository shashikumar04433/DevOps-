# Elastic Search Engine:
        ELK----> Elastic Search,Logstash,Kibana.
        *  Elastic Search it is a Search Engine & it is used for Analytics.
           Eg:Google Search Engine.
           
### Process of Elastic Search:

        * Application----> Data ---->Logstash--->Elastic Search--->Kibana

## Installation Process of Elastic Search Engine:

        Download and install the RPM manually using below link:
        
      Step1: 
             wget https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-7.17.10-x86_64.rpm
      
      Step2: 
             wget https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-7.17.10-x86_64.rpm.sha512 shasum -a 512 -c                          elasticsearch-7.17.10-x86_64.rpm.sha512
      
      Step3: 
             sudo rpm --install elasticsearch-7.17.10-x86_64.rpm
      
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
                network.host: 172.31.46.149 
                http.port: 9200
                discovery.seed_hosts: 172.31.46.149 (its ur private ip)
       Step9:
                service elasticsearch restart
                service elasticsearch status
                
       Step10: 
                ip:9200
                
        
       
             
