### Attaching the Volume and Portioning the Volumes:

Step1:
```
create a ebs and attach it to the ec2 instance.
```
Step2:
```
1. fdisk /dev/xvdk
2. fdisk -l
3. lsblk
4. pvcreate /dev/xvdk1
5. pvs
6. vgcreate vg0 /dev/xvdk1
7. vgs
8. pvs
9. lvcreate -n lv0 -L +3GB vg0
lv0 ---logical volume name and vg0 is volume group name -L is for dividing the 4gb and doing the partiotion to +3GB.
10. lvdisplay

11. mkdir.ext4 /dev/xvdk1

12. mkdir /data
13. mount /dev/xvdk1 /data
14. fdisk -l
15. dh -h
```

