## Linux_Commands:
```
In Linux, permissions are represented by a set of three octal digits (ranging from 0 to 7),
each digit representing the permission for a specific user category: owner, group, and others.

The permissions are typically represented as:

Read (r): Permission to read the file's contents or view a directory's contents.
Write (w): Permission to modify or delete the file, or add, remove, or rename files within a directory.
Execute (x): Permission to execute the file if it is a program or script, or access files within a directory if it is executable.
The sum of these permissions for each category results in an octal number:

Read (r) = 4
Write (w) = 2
Execute (x) = 1
To represent permissions using octal notation, you add these values accordingly:

No permissions: 0
Execute only: 1
Write only: 2
Write and execute: 3
Read only: 4
Read and execute: 5
Read and write: 6
Read, write, and execute: 7
```
**systemctl**
```
It is used to get all information and to manage services in the system.
```
**journalctl**
```
It is used to collect log information.
```
**dig**
```
It is used to get DNS server info
```
**nslookup**
```
It is used to get DNS server information.
```
**shred**
```
It makes the text file to entripted form .

Eg:

* vim abc.txt
* shred abc.txt
* cat abc.txt
```
**finger**
```
* finger command is used to monitor the other user.
* apt install finger
* finger <username>
```
**ufw**
```
This enables port mapping directly
Eg:

* ufw allow 80
* ufw allow 443
```

**Network Configuration & Trouble Shooting:**
```
The basic requirements for Networking are:

1.NIC(Network Interface Controller or Card).

2.Media.

3.Topology.

4.Protocol.
```
**LVM**
```
* Steps to Create a New Partition Using fdisk
* Start fdisk for the target disk:
* sudo fdisk /dev/sdX
* Replace /dev/sdX with your actual disk identifier (e.g., /dev/sdb).(Actual path in my system is /dev/xvd11)
* then choose n or wtite n 
* choose the gb or the mount space
* then quit or save using q or w commands.

```

**eg for help**
```
Command (m for help): m

Help:

  DOS (MBR)
   a   toggle a bootable flag
   b   edit nested BSD disklabel
   c   toggle the dos compatibility flag

  Generic
   d   delete a partition
   F   list free unpartitioned space
   l   list known partition types
   n   add a new partition
   p   print the partition table
   t   change a partition type
   v   verify the partition table
   i   print information about a partition

  Misc
   m   print this menu
   u   change display/entry units
   x   extra functionality (experts only)

  Script
   I   load disk layout from sfdisk script file
   O   dump disk layout to sfdisk script file

  Save & Exit
   w   write table to disk and exit
   q   quit without saving changes

  Create a new label
   g   create a new empty GPT partition table
   G   create a new empty SGI (IRIX) partition table
   o   create a new empty DOS partition table
   s   create a new empty Sun partition table
```




