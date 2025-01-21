### Day3-linux_Scenario_Based:

## Senario based questions:
**Delete files older than 10 days using shell script in Unix [duplicate] ??**
```
find /path/to/directory -type f -newermt "2025-01-17" ! -newermt "2025-01-21" -exec rm -f {} +
find / -type f -newermt 

/path/to/directory: Directory to search for files.
-type f: Match only files (not directories).
-newermt "2025-01-17": Files modified after January 17, 2025.
! -newermt "2025-01-21": Files modified before January 21, 2025.
-exec rm -f {} +: Delete matched files.

```
**How do you check the monitor CPU utilization**
```
mpstat
```
**How do u generate load on cpu using the alternative command?**
```
sudo apt install stress    # For Debian/Ubuntu

stress --cpu 2 --timeout 30
```

1. Linux Booting Process ?
```
Linux Booting Process is a series of steps that occur when a Linux system is powered on. 
The process involves the following steps:
- POST: Hardware initialization.
- BIOS(Basic Input output of system): Firmware and boot device search.
- Bootloader: Loads the Linux kernel.
- Kernel: Initializes the system and mounts the root filesystem.
- Init: Starts system processes and services.
- Services: Network, hardware drivers, and other services are started.
- Login: User login prompt or GUI login.
- User Environment: Final setup and user interaction.
```
2. Mount an EBS Volume to EC2 Instance
```
* Attach the EBS volume to ec2 instance.
* check the disk is empty or not :
* file -s /dev/xvdf
* Format the volume:
* sudo mkfs.ext4 -f /dev/xvdf
* Create a mount point:
* sudo mkdir shashimount
* Mount the volume:
* sudo mount /dev/xvdf shashimount
* to check the used mount space
* df -h /home/ubuntu/shashimount
* Persist in vi /etc/fstab:
* echo "/dev/xvdf shashimount ext4 defaults 0 0" | sudo tee -a /etc/fstab
```
3. Find a Specific file or Folder in a Server ?
```
find . -name "file or folder name"
```
4. Zip and Unzip a Folder or File ?
```
mkdir abc
zip -r abc.zip foldername
unzip abc.zip -d foldername
```
5. How to copy a file from one server to another server using SSH ?
```
1.scp /path/to/local/file username@remote_host:/path/to/remote/destination
2.using ftp
3.using rsync
```
6. List Out top 5 CPU and Memory consuming processes?
```
ps -eo %mem,%cpu --sort=-%cpu | head -n 5
```
**Top command just to show 5 lines**
```
top -c -b -n 1 | head -5 (to check the top 5 lines)
```
7. Explin about Load Average & Check how much long a Specific Process running ?
```
Load Average is nothing but its system load over a period of timestores which are 1 min ,5 min and 15 mins.
command to check :
* uptime
* top -p <process id>
```

8. How to start the service automatically when the server got reboot ??
```
sudo systemctl enable service_name
```

9. Schedule a Crontab which need to run every 2 day at 4:30 PM.
```
30 16 */2 * * /path/to/your/script.sh
```
10. Run a Process in BackGround Mode ?
```
When you append & at the end of a command, it will execute the command in the background.
* script.sh &
* python3 myscript.py &
```
11. How to troubleshoot a Linux Server which you cannot able to access ??
```
In multiple ways we can troubleshoot that are:
Using ping ,telnet,nslookup,dig.
ping ip
ssh -v user@server_ip
telnet ip 80
```
12. Explain the Network  concepts ( netcat, nmap, telnet, ping, dig)
```
netcat - > Its nothing but works similar to the telnet checks whether the ip is reachable to certain port
nmap -> Its nothing but port scanner which checks the open ports in the server.
telnet -> Its tests whether the port accessable certain port or not.
ping - > Check server reachability or not.
dig -> Tts a DNS query it gives dns info. 
```
13. Other Commands
```
* df -h : To check the disk space usage
* free: View memory usage.
* top: Monitor system processes.
* netstat: View network connections.
* ps: View running processes.
* kill: Terminate a process.
* find: Locate files or directories.
```

14. Count Number of Lines in a File
```
wc -l filename.txt
```
15. Exclude a String in a file and print ?
```
grep -v "string" filename.txt
```


Shell Script Scenarios 
======================
a. Check a Process ( Apache) is running or not. If not running start the process. Else, Skip.
```
#!/bin/bash
if ! ps -ef | grep -v grep | grep apache > /dev/null then
    echo "Apache is not running. Starting it..."
    systemctl apache start
else
    echo "Apache is already running."
```
or 

```
#!/bin/bash

if !pgrep apache2 > /dev/null; then
    echo "Apache is not running. Starting it..."
    systemctl apache start
else
    echo "Apache is already running."
```


b. Remove files which created in specific time zone ( Ex: Files created in between Jan-2012 to Feb-2020)
```
#!/bin/bash

# Define the directory to search
DIRECTORY="/path/to/files"

# Find files modified between Jan 10, 2025 and jan 25, 2025 and remove them
find "$DIRECTORY" -type f -newermt "2025-01-10" ! -newermt "2025-01-15" -exec rm {} +

echo "Files modified between 2025-01-10 and 2025-01-15 have been deleted. newermt is a modified after this date"

```
```
c. Get All the Unique IP's from the error Log file.

    Summary : 
    - Front End Application Running on Apache and Which is Public Faced ( Everyone abale to access the Website)
    - Few users able to access the website and few not ( Due to various scenarios )
    - All the Access logs stored under "/var/log/httpd/access_logs"  and Error Logs will be stored under "/var/log/httpd/error_logs"
    - From the Error Logs filter All Unique IP's ( Only IPs. Not Other content)
```
```
awk '{print $1}' access.log| sort | uniq>unique.txt
```
```
d. I have a List of IP's. Copy "dummy.txt" file from one server to all the servers.

    Ex: ["56.89.05.30", "78.90.50.4", "45.78.9.10"]
```
```
#!/bin/bash

# List of IPs
SERVER_IPS=("192.168.1.101" "192.168.1.102" "192.168.1.103")

# File to copy
SOURCE_FILE="dummy.txt"

# Destination path on remote servers
DEST_PATH="/home/user/"

# Loop through each IP and copy the file
for IP in "${SERVER_IPS[@]}"; do
    echo "Copying $SOURCE_FILE to $IP:$DEST_PATH"
    scp "$SOURCE_FILE" user@"$IP":"$DEST_PATH"

    if [ $? -eq 0 ]; then
        echo "File copied successfully to $IP"
    else
        echo "Failed to copy to $IP"
    fi
done

echo "All done!"
```

e. Take a Backup of Old logs more than 60+ days ??
```
#!/bin/bash

# Define variables
LOG_DIR="/var/log/myapp"  # Replace with your log directory
BACKUP_DIR="/backup/logs" # Replace with your backup directory

# Create backup directory if it doesn't exist
mkdir -p "$BACKUP_DIR"

# Find and compress logs older than 60 days
find "$LOG_DIR" -type f -mtime +60 -exec tar -rvf "$BACKUP_DIR/old_logs_$(date +%Y%m%d).tar" {} +

# Delete old logs after backup (optional)
find "$LOG_DIR" -type f -mtime +60 -delete

echo "Backup completed successfully!"

```

or 

d.I have a List of IP's. Copy "dummy.txt" file from one server to all the servers.
```
#!/bin/bash
for IP in 192.168.1.101 192.168.1.102 192.168.1.103; do
    scp dummy.txt user@"$IP":/home/user/ && echo "Copied to $IP" || echo "Copy failed: $IP"
done
echo "Task complete!"
```

e. Take a Backup of Old logs more than 60+ days ??
```
find / -type f -mtime +60 -exec tar -rvf backup.tar {} + -exec rm {} \;
```
