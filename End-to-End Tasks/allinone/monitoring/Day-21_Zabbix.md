## Installation of Zabbix on Ubuntu:

### Install Zabbix repository
```
* wget https://repo.zabbix.com/zabbix/7.0/ubuntu/pool/main/z/zabbix-release/zabbix-release_7.0-2+ubuntu24.04_all.deb
* dpkg -i zabbix-release_7.0-2+ubuntu24.04_all.deb
* apt update
```

### Install Zabbix server, frontend, agent
```
* apt install zabbix-server-mysql zabbix-frontend-php zabbix-apache-conf zabbix-sql-scripts zabbix-agent
* sudo apt-get install mysql-server
* mysql -uroot -p
password
mysql> create database zabbix character set utf8mb4 collate utf8mb4_bin;
mysql> create user zabbix@localhost identified by 'password';
mysql> grant all privileges on zabbix.* to zabbix@localhost;
mysql> set global log_bin_trust_function_creators = 1;
mysql> quit;
```
### On Zabbix server host import initial schema and data. You will be prompted to enter your newly created password.
```
zcat /usr/share/zabbix-sql-scripts/mysql/server.sql.gz | mysql --default-character-set=utf8mb4 -uzabbix -p zabbix
then enter above passwd and wait till it come down like 3-4 mins
```
### Disable log_bin_trust_function_creators option after importing database schema.
```
mysql -uroot -p
password
mysql> set global log_bin_trust_function_creators = 0;
mysql> quit;
```
### Configure the database for Zabbix server
```
Edit file /etc/zabbix/zabbix_server.conf
DBPassword=password (your password)
```
### Start Zabbix server and agent processes
```
# systemctl restart zabbix-server zabbix-agent apache2
# systemctl enable zabbix-server zabbix-agent apache2
# http://host/zabbix
after setup 
Username is :Admin by default and password is zabbix which u set like above
```

### Zabbix Interview Questions

1. What is Zabbix?
```
Zabbix is an open-source monitoring tool for networks, servers, and applications.
``
How does Zabbix collect data?

Zabbix collects data using agents, SNMP, IPMI, and custom scripts.
What is a Zabbix template?

A Zabbix template is a set of predefined items, triggers, and graphs used to standardize monitoring configurations.
What are Zabbix items?

Items are the data points collected by Zabbix, such as CPU usage or disk space.

What is a Zabbix trigger?

A trigger is a condition or set of conditions that determine when an alert should be generated.
Explain Zabbix’s monitoring architecture.

Zabbix architecture includes a server, database, frontend, and agents.
What is the purpose of the Zabbix frontend?

The frontend provides a web-based interface for managing and viewing monitoring data.
How does Zabbix handle high availability?

Zabbix supports high availability through database clustering and redundant server setups.
What is the function of Zabbix’s proxy?

A Zabbix proxy collects and forwards monitoring data to the Zabbix server, often used for remote or distributed monitoring.
What types of notifications can Zabbix send?

Zabbix can send notifications via email, SMS, scripts, and integrations with external systems.


```