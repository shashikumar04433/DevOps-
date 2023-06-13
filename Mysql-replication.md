# Installation of Mysql on ubuntu:
                Step1:

                        DB1:
                        apt-get install sql-server
                        systemctl start mysql
                        systemctl enable mysql
                        systemctl status mysql

                        vi /etc/mysql/mysql.conf.d/mysqld.cnf
                        bind-address            = 0.0.0.0
                        server-id               = 1
                        log_bin                 = /var/log/mysql/mysql-bin.log
                        systemctl restart mysql
                Step2:
                                mysql -u root -p
                                SHOW MASTER STATUS \G
                                CREATE USER 'repl'@'172.31.43.72'(ip of slave) IDENTIFIED BY 'secret';
                                GRANT REPLICATION SLAVE ON *.* TO 'repl'@'172.31.43.72';
                                SHOW MASTER STATUS \G


                Step3:
                            Go to another server 
                            DB2:

                            apt-get install sql-server

                            systemctl start mysql
                            systemctl enable mysql
                            systemctl status mysql
                            vi /etc/mysql/mysql.conf.d/mysqld.cnf

                            bind-address            = 0.0.0.0
                            server-id               = 2
                            log_bin                 = /var/log/mysql/mysql-bin.log
                            systemctl restart mysql
                            sudo mysql -u root -p
                            SHOW SLAVE STATUS \G

                               eg :
                              CHANGE REPLICATION SOURCE TO SOURCE_HOST='172.31.42.124'(private ip of DB1) ,SOURCE_LOG_FILE='mysql- bin.000002'(source                   logfile of db1),SOURCE_LOG_POS=542(sourcelog position od db1),SOURCE_SSL=1(soure sslnumber);

                                            CHANGE REPLICATION SOURCE TO SOURCE_HOST='172.31.42.124' ,SOURCE_LOG_FILE='mysql-                        
                                            bin.000002',SOURCE_LOG_POS=542,SOURCE_SSL=1;


                                    To acces enter replica of same user given above;

                                    START REPLICA USER='repl' PASSWORD='secret';

                                    SHOW REPLICA STATUS \G

                                      show databases;
                                      you can see both servers have same databases.

                                now goto db1:
                                CREATE DATABASE MANISH;


                                come to db2:
                                show databases;
                                (it will be visible)
                                then :
                                CRETAE USER 'repl'@db1private ip IDENTIFIED BY 'secret';

                                GRANT REPLICATION SLAVE ON *.* TO 'repl'@'172.31.47.42';
                                SHOW MASTER STATUS \G


                                goto DB1:
                                CHANGE REPLICATION SOURCE TO SOURCE_HOST='172.31.42.124'<IP OF DB1> ,SOURCE_LOG_FILE='mysql-                                              bin.000002',SOURCE_LOG_POS=542,SOURCE_SSL=1;

                                START REPLICA USER='repl' PASSWORD='secret';

                                goto DB2;
                                use MANISH
                                CREATE TABLE students (id int,name varchar(255));
                                show tables;
                                select * from students;


                                goto DB1:
                                use MANISH
                                show create table students;
                                insert into students value(1,'shashi');
                                show tables;
