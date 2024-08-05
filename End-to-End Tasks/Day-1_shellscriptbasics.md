# If-Else condition
```
#!/bin/bash  ---------------->shebang


num=5
if[$num -gt 4];
then
    echo "hello world"
else
    echo "bye world"


## elif-condition in If-Else

#!/bin/bash 

num=5
if[$num -gt 10];then
    echo "$num is gretaer then 10"
elif [$num -lt 5];y=then
    echo "$num is less then 5"
else
echo "both are the wrong statements"
```

## For loops 
```
#basic syntax of for loop:
for item in list
do
echo $item
done

for i in {1..10}
do
echo "write the i iterates"
done
```

# Using C-style loops
```
for ((i<1;i<=5;i++))
do
echo($i)
done
```


# Using array in loops
```
arr=("banana","apple","grapes")

for i in ${arr[@]}
do
echo $i
done

```
# Using the list in loops
```
#!/bin/bash
for i in 1 2 3 4 5
do
echo $i
done
```

## Xargs :
```
It is a command to build and excute commands provided through standard input

it takes input and then execute with the arguments.

(or)

Taking all input and executing in one parameter or one comment.

eg:
xargs [][]

ls *.text | xargs cat

ls *.text | xargs rm
```


## Sed (Streamline Editor):
```
Sed (It is a stream line editor where you can edit the file content with out entering in it using the below flags)

-i --> It is use to edit or insert the content into file .

eg:
sed -i 's/hello/hey/' file.txt

-n -e ---> It both works as same to print the illusionary output but the original file doesnt have any changes.


```
## Awk ()
```
Awk command is used to filter the fielddata from the larger files.

eg:if you want to filter only email or country name in the excel :
command
awk -F '{print $4}' filename.txt
```
## Cut 
```
Cut command is used to write selected characters or fields in the file

cut -b1-5 /etc/passwd ( it print the 5 characters)

cut -c1-5 /etc/passwd

```
## Practise of Conditions & Loops:
```
#!/bin/bash

num=18

if [ $num < 18 ]
then
    echo "he is eligible for voting"
elif [ $num > 18 ]
then
    echo "he is not eligible for voting"
else
    echo "he is  apply for voting"
fi
```
## Forloop 
```
#!/bin/bash
for i in $(awk '{print $2}' hostname.txt)
do
    if (ping -c 1 $i);
    then
        echo "server is up"
        ssh -o StrictHostKeyChecking=no ubuntu@$i 'sudo df -h'
    else
        echo "server is down"
    fi
done
```

## While Loops:
```
while (condition)
do
echo "print something"
done

#!/bin/bash
count=1
while[$count -le 5]
do
    echo "Count:$count"
    ((count++))
done

```

## Zip and Unzipping the directories and Files:
```
zip abcd.zip abc1.txt abc2.txt abc3.txt
```

## SoftLink 
```
It is a exact copy of file like a short cut.
ln -s /path/of/directory/file
```
## Hardlink
```
It a exact copy if u delete the file the main file also deletes
ln /path/of/directory/file
```

## Tar and UTar
```
Tar is Bundling multiple files into a single file without compression.
Utar is Unbundling the files from a single file without compression.
-c -->create a new zip or archive file.
-x  -->extract file from archive file.
-t -->list the contents of archive file.
-f etc.




 ssh -o StrictHostKeyChecking=no ubuntu@$i "sudo df -h"


```
```
#!/bin/bash
service="apache2"
if (( $(ps -ef | grep -v grep | grep $service | wc -l) > 0 ))
then
    echo "$service is running!!!"
else
    echo "$service is not running!!!"
    systemctl start apache2
fi

```

```
#!/bin/bash
if (ps -ef | grep "apache2"|wc -l>1);
then
    echo "apache2 is running"
else
    echo "apache2 is not running so now we  will be starting the apache2 " 
    systemctl start apache2
fi
```
```
#!/bin/bash

count=$(ps -ef | grep "apache2" | grep -v "grep" | wc -l)
```
# Check if apache2 is running
```
if [ $count -gt 1 ]; then
    echo "apache2 is running"
else
    echo "apache2 is not running, so now we will be starting apache2"
    systemctl start apache2
fi
```

#!/bin/bash

# Count how many apache2 processes are running
count=$(ps -ef | grep -c "apache2")

# Check if apache2 is running
if [ $count -gt 2 ]; then
    echo "apache2 is running"
else
    echo "apache2 is not running, so now we will start apache2"
    systemctl start apache2
fi

#!/bin/bash
service="apache2"
if (( $(ps -ef | grep -v grep | grep $service | wc -l) > 0 ))
then
    echo "$service is running!!!"
else
    echo "$service is not running!!!"
    systemctl start apache2
fi




























