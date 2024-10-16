## Reversing a array using a loop
```
a= ["a","c","b","d","f","e"]
reversed_a=[]

for i in range (len (a) -1,-1,-1):
    reversed_a.append(a[i])
print(reversed_a)

```
## Reversing the Array of intergers:
```
a=[1,2,3,4,5,6]
b=a[::-1]
print(b)
```
## Reversing the strings in the array with the index:
```
a=["hello","Hi","something","everything"]
b=(a[0][::-1])
print(b)
```
## Reversing the string first sorted then in reverse order:
```
a=["apple","banana","cherry","date","elderberry","fig"]
b=sorted(a)
print(sorted(a,reverse=True))
```

## Counting the days how may times it present or not?
```
days=["wed","wed","tues","mon","thurs","sat","sun","mon"]
for i in set(days):
    print(i,days.count(i))
```

