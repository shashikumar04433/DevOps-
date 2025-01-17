### Networking:
```
ip addr -> It shows that the private ipv4 address and inet which are connected.

curl ifconfig.me ->It displays the public ip address.

```
**Managing Network Interfaces**
```
sudo ip link set eth0 up 
sudo ip link set eth0 down
```
**Testing Connectivity**
```
* Testing a connectivity to remote host
* ping -c 4 google.com (only four lines it shows )
* ping google.com
* ping microsoft.com
```
**trace route**
```
It traces the route from source to destination
traceroute google.com
```
**netstat**
```
It shows the network socket information
netstat -tlnp
netstat -tupl
```
**tcpdump**
```
It captures and displays the network traffic
tcpdumb -i eth0
```
**wget**
```
It downloads the file from the remote server
```
**nmap**
```
It is a network scanner which shows active devices
```

**Useful command**
```
ip addr	-->Display IP addresses and interfaces.
ping [host]	-->Test connectivity to a host.
traceroute [host]-->Trace the route to a host.
netstat -tuln-->View open ports and connections.
ss -tuln-->View active sockets.
nslookup -->Query DNS servers for domain info.
curl [URL]--> Fetch a webpage or test an API.
sudo ufw allow [port]-->Open a port in the firewall.
```


## 2. Processes in Linux

```
Common options:

ps aux: Displays all processes running on the system.
ps -ef: Another way to list all processes.
ps -aux | grep process_name: Filter processes by name.
```
**Top**
```
Interactive Process Viewer which shows all the processes which are running and utilize of Cpu and Memory
```
**htop**
```
it is used for enhanced interactive way in more graphical view and which shows utilize of Cpu and Memory
```

**Process Management Commands:**
```
kill [pid]: Kill a process by its ID. (kill 1234)
killall [process_name]: Kill all processes with a given name.(eg:killall nginx)
pkill [process_name]: Kill all processes with a given name. ()
```
**PID**
```
Process ID, a unique number assigned to each process.
* pidof nginx
* pgrep nginx
```
**nice command**
```
nice [command]: Run a command with a specified priority (nice value).
* nice -n 10 firefox

Important Notes
Only the root user can run commands with a negative niceness (higher priority).
Regular users can only assign positive niceness values (lower priority).
```
**strace**
```
Traces System Calls for example
* strace -p pid
* strace -p 87676
```
**List of Open Files**
```
lsof -p 29177
lsof -u ubuntu
lsof -u root
```

**Process Control Commands Cheat Sheet**

ps
```
Display process information.
```
top
```
Real-time interactive process viewer.
```
htop
```
Enhanced real-time interactive process viewer.
```
kill [PID]
```
Kill a process by PID.
```
kill -9 [PID]
```
Forcefully terminate a process.
```
nice [command]
```
Start a process with a specific priority.
```
renice [PID]
```
Change the priority of a running process.
```
pkill [process_name]
```
Kill all processes with a specific name.
```
bg %job_number
```
Resume a suspended process in the background.
```
fg %job_number
```
Bring a background process to the foreground.
```
strace -p [PID]
```
Trace the system calls of a process.
```
lsof -p [PID]
```
List open files by a specific process.
```
crontab -e
```
Edit cron jobs for scheduling tasks.
```
crontab -l
```
List cron jobs for the current user.
```

**List of Open Files**
```
lsof -p 29177
lsof -u ubuntu
lsof -u root
```

### 3. Linux Storage Management:
Key Concepts:
Block Devices
```
Devices that store data in blocks (e.g., hard drives, SSDs).
```
File Systems: 
```
Structures that organize and manage data (e.g., ext4, xfs, ntfs).
```

Partitions: 
```
Logical divisions of storage devices.
```
Mounting: 
```
Associating a file system with a specific directory.
```

**Command to wipe existing mounted disk**
```
sudo dd if=/dev/zero of=/dev/xvds bs=1M status=progress
```

### 4. Most asked interview commands

sed (stream editor)
```
sed -i 's/old/new/g' file.txt
sed -i 's/hi/hello/g' file.txt
```

awk (pattern scanning and processing language)
```
100 manish
150 shashi
200 anand
300 kusuma
400 vadina
awk '$1>100 {print $0}' awknew.txt

output:
150 shashi
200 anand
300 kusuma
400 vadina
```
grep (global search and print)
```
grep -r "pattern" directory
```

## $0 ,$1 ..$9 $\10

abcnew.sh
```
echo "First argument: $1"
echo "Second argument: $2"
echo "third argument: $3"
echo "total arguments: $#"
```
output
```
run ./abcnew.sh shashi anand vadina shashi kumare reddy new one 
First argument: shashi
Second argument: anand
third argument: vadina
total arguments: 9
```
```
$*-->treats all arguments as a single string when quoted.
$@-->treats all arguments as separate strings when quoted.
$? --> It takes the last command as input
```
grep
```
Basic search for a string:
grep "search_name" filename.txt
```
Case-insensitive search:
```
grep -i "pattern" file.txt
```
Display line numbers with matches:
```
grep -n "pattern" file.txt
```
Count the number of matching lines:
```
grep -c "pattern" file.txt
```
Search recursively in a directory:
```
grep -r "pattern" /path/to/directory/
```

