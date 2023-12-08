## Installation of MSSQL on Ubuntu:
```
1.sudo apt install mysql-server -y
2.sudo /opt/mssql/bin/mssql-conf setup
3.sudo add-apt-repository "$(wget -qO- https://packages.microsoft.com/config/ubuntu/20.04/mssql-server-2022.list)"
4.sudo apt install mysql-server -y
5.sudo /opt/mssql/bin/mssql-conf setup
6.sudo apt-get install -y mssql-server
7.sudo /opt/mssql/bin/mssql-conf setup
8.systemctl status mssql-server.service
9.curl https://packages.microsoft.com/config/ubuntu/20.04/prod.list | sudo tee /etc/apt/sources.list.d/mssql-release.list
10.sudo apt update
11.sudo apt install mssql-tools -y
12.echo 'export PATH="$PATH:/opt/mssql-tools18/bin"' >> ~/.bash_profile
13.echo 'export PATH="$PATH:/opt/mssql-tools18/bin"' >> ~/.bashrc
14.source ~/.bashrc
15.apt install sqlcmd
16.sqlcmd -S localhost -U sa -P Admin@123
```
