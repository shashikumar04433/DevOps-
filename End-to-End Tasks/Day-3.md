## Day3
```
1. Find
2. Lsof
3. $$ $# $? $1 $0 $@ $- $-x $-p $-h $-v $-n $-e $-f $-i $-s $-t $-u $-w $
4. Crontabs
5.File System
6.How to update a particular single package
```

## Find
```
    find /home/ubuntu | grep "shashi"

    find . "var"
```
## lsof
```
    It will check that which files are opened in the server or the user.
    lsof
    lsof -u ec2-user
    lsof -u ubuntu
    lsof -i :22
```
## $$ 
```
It will give the process id of the current process.
echo $1
$#
It will give the number of arguments passed to the script.

.sh file

## $#
echo "total number of args"
```


## Crontab
```
* * * * *
| |  |  | |
| |  |  | +----- day of week (0 - 6) (Sunday-saturday)
| |  | +------- month (1 - 12)
| | +--------- day of month (1 - 31)
| +----------- hour (0 - 23)
+------------- min (0 - 59)
```






