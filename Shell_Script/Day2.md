# Day2
```
    1.Linux Network (Telnet, Netcat , Ping, SSH , Dig , tcpdump, iproute, Netstat , Nslookup)
    2.Permissions
    3.User & Group Administration
    4.Mounting
```

### Telnet :
```
    Telnet is use to check the server is reachable or not.
```
### Netcat :
```
    Netcat is alterntive command for the Telnet .
    nc -vz 172.31.42.52 80  
    v -->verbose z -->scanning
```
## Ping
```
    ping google.com  
    ping sends echo request packets to a network host to check its availability
```
### SSH (to connect a private server which doesnt have access to internet)
  ```
    ssh -J ubuntu@ip ubuntu@2ndip
  ```
### Dig
```
    dig google.com 
    dig is used to get the information
```
### Netstat
```
    netstat -tulp
    Netstat displays network connections, routing tables , listening ports.
```
### Nslookup
```
    nslookup google.com
    nslookup is used to get the ip address of the domain name
```
### tcpdump
```
    tcpdump is used to capture the packets and capture the traffic and to network troubleshoot.
    eg:
    tcpdump port 53
    tcpdump port 80
```
### Iproute
```
    ip route show
    It shows the routing table details
    ip link show
    It shows the network interfaces details
    ip addr show
    It shows the ip address details
```  
### 3.User and Group Administrator:
```
    Three types of Users:
    1.Roor User --> Super User or the root user.
    2.System User --> automatically created the user when ever u install the software and predefined users.
    3.Normal User --> It is a normal user created by root user.
```
### Creating the Use and Groups:
```
1.useradd shashi ---> For creating the user
2.groupadd newgroup --> For creating the group
```
### Modifing the username which is already exists:
```
    usermod -l olduser newusername
eg:
    usermod -l shashi newusershashi
```

### To set the password expiry:**
```
    chage -M 90 username

* To check the user password expiry date
    chage -l username

* To Lock the useraccount:
    passwd -l username
```

### Mount
```
    Adding extra volume to the server and attching the storage and using it .
```
step1:
```
    add a extra ebs volume to the ec2 and attch that to the server.
```
step2:
```
    mount the volume present or attched in the server or not with the below command
    file -s /dev/xvdi
    mkfs -t ext4 /dev/xvdi
    mkdir /shashifilestorage
    sudo mount /dev/xvdi /shashifilestorage
    eg mount /dev/xvdi /shashifilestorage
```
step3:
```
    To make the volume permanent in the server 
    sudo vim /etc/fstab
    add the below line in the file
    vi /etc/fstab
    write below content
    /dev/xvdf /data ext4 defaults 0 0
```
step4:
```
    To check the volume is mounted or not
    df -h
```
step5:
```
    To check the volume is present or not
    lsblk -f
```
step6:
```
    To unmount the volume
    umount /shashifilestorage/
    df -h
```

### Order of the commands to mount ebs volume to the other directories:
```
    lsblk
    file -s /dev/xvdi
    mkfs -t ext4 /dev/xvdi
    mkdir /shashifilestorage
    mount /dev/xvdi /shashifilestorage/
    lsblk
    df -h
    vi /etc/fstab
    df -h
    umount /shashifilestorage/
```




