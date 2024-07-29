
### Miniproject using vpc and deploying the Python 2tierapplication.
```
https://www.linkedin.com/pulse/ep-2-devops-tier-application-deployment-maninder-singh/
refer above link
```
```
apt-get update -y
apt install docker.io -y
mkdir project
sudo apt install git -y
cd project/
git clone https://github.com/Maninderit/2-tierapplication.git
cd 2-tierapplication/
sudo docker build . -t flaskapp
sudo docker run -d -p 5000:5000 flaskapp:latest
docker ps
vi requirements.txt
```
```
cython
Flask==2.0.1
Werkzeug==2.0.1
Flask-MySQLdb==0.2.0
requests==2.26.0
```
```
pip install -r requirements.txt
sudo docker build . -t flaskapp
docker network create twotier
sudo docker run -d -p 5000:5000 --network=twotier -e MYSQL_HOST=mysql -e MYSQL_USER=admin -e MYSQL_PASSWORD=admin -e MYSQL_DB=myDb flaskapp:latest
docker ps
sudo docker run -d -p 3306:3306 --network=twotier -e MYSQL_DATABASE=myDb -e MYSQL_USER=admin -e MYSQL_PASSWORD=admin -e MYSQL_ROOT_PASSWORD=admin mysql:5.7
docker ps
docker exec -it <containerid> bash
write the db script inside the container as per the reference link shown above.
vi app.py
make sure that db details are correct in app.py
sudo apt-get install docker-ce docker-ce-cli
sudo curl -L "https://github.com/docker/compose/releases/download/v2.21.0/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose
pip install --upgrade docker
apt install python3-pip
pip install --upgrade docker
docker --version
docker-compose --version
sudo systemctl restart docker
sudo systemctl status docker
docker-compose down
docker-compose up --build

then hit the url using 
http://ip:5000
```
```
then login to the container to check the msges your entered working in db or not .

mqsql -u admin -p 
password admin
show database;
use myDb;
show tables;
select*from tablename;
you can view the data;
```

