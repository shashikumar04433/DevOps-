# Shell_Script:
**Types of Shells**

```
* /bin/sh
* /bin/bash
* /usr/bin/sh
* /usr/bin/bash
* /usr/bin/tmux
* /usr/bin/screen
```
**!# (Shebang)**
```
The #!/bin/bash at the beginning of the script indicates that
the script should be interpreted using the Bash shell.
```

**Variables in Shell Script**
```
var1="shashi"
var2=123
```
**Executing the variables**
```
echo $var1 $var2
```

**Writing a shellscript in linux**
```
echo $BASH
echo $BASH_VERSION
echo $HOME
echo our current working directory is $PWD
name=Mask
value=10
echo the name is $name
echo value $value
```
**Input.sh file**
```
set -x #Debug mode
free -g
nproc
```
**Output file**
```
+ free -g
               total        used        free      shared  buff/cache   available
Mem:              31           1          13           0          16          29
Swap:              0           0           0

+ nproc
8
```
**Basic Practises of the Shell Script**
```
echo -x #Debug Mode
echo -e #exit the script when there is an error
echo -o pipefail
```

**Example of if-else condition in Shell Script**
```
a=40
b=100

if [ $a -gt $b ];
then
    echo "a is greater than b"
else
    echo "a is not greater than b"
fi
```
