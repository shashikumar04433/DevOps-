### Ssl_Configuration setup for Jenkins using Nginx:

```
1.sudo openssl req -newkey rsa:2048 -nodes -keyout jenkins.key -x509 -days 365 -out jenkins.crt
```
```
2.sudo openssl pkcs12 -export -in jenkins.crt -inkey jenkins.key -out jenkins.p12 -name jenkins -CAfile jenkins.crt -caname root
```
```
3.set pass and replace below with the password.
```
```
4.keytool -importkeystore -srckeystore jenkins.p12 \
-srcstorepass 'your-secret-password' -srcstoretype PKCS12 \
-srcalias jenkins.devopscube.com -deststoretype JKS \
-destkeystore jenkins.jks -deststorepass 'your-secret-password' \
-destalias jenkins.devopscube.com
```

```
5.mkdir -p /etc/jenkins
chown -R jenkins: /etc/jenkins
```

```
6.cp jenkins.jks /etc/jenkins/
```
```
7.chmod 700 /etc/jenkins
```
```
8.chmod 600 /etc/jenkins/jenkins.jks
```
```
9.sudo vi /etc/nginx/sites-available/jenkins
```
```
10.server {
    listen 80;
    server_name 13.233.216.136;

    location / {
        proxy_pass http://127.0.0.1:8080;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}

server {
    listen 443 ssl;
    server_name 13.233.216.136;

    ssl_certificate /home/ubuntu/jenkins.crt;
    ssl_certificate_key /home/ubuntu/jenkins.key;

    location / {
        proxy_pass http://127.0.0.1:8080;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}
```

```
11.sudo ln -s /etc/nginx/sites-available/jenkins /etc/nginx/sites-enabled/
```
```
12.sudo nginx -t
```
```
13.sudo systemctl restart nginx
```
```
14.sudo vi /etc/default/jenkins
```
```
15.JENKINS_ARGS="--httpPort=8080 --httpListenAddress=127.0.0.1"
```
```
16.sudo systemctl restart jenkins
```
