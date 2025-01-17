# Day2-Linux

## Scripting:
```
- for loop
- while loop
- if else conditions
- open a file & read content and start the process
```
# If-Else condition
#!/bin/bash  ---------------->shebang


num=5
if[$num -gt 4];
then
    echo "hello world"
else
    echo "bye world"
fi

## elif-condition in If-Else

#!/bin/bash 
num=5
if[$num -gt 10];then
    echo "$num is greater then 10"
elif [$num -lt 5];then
    echo "$num is less then 5"
else
echo "both are the wrong statements"
fi

## For loops 
#basic syntax of for loop:
for item in list
do
echo $item
done

for i in {1..10}
do
echo "write the i iterates"
done


# Using C-style loops

for ((i<1;i<=5;i++))
do
echo($i)
done



# Using array in loops
arr=("banana","apple","grapes")

for i in ${arr[@]}
do
echo $i
done

# Using the list in loops
#!/bin/bash
for i in 1 2 3 4 5
do
echo $i
done
