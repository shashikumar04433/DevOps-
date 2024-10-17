## Palindrome Program

```
def is_palindrome(s):
    s=s.lower()
    return s == s [::-1]
    
word="shhs"
if is_palindrome(word):
    print(word,"It is a palindrome")
else:
    print(word,"Its not a palindrome")
```
## Factorial Program

```
def factorial(n):
    if n==0 or n==1:
        return 1
    else:
        return n*factorial(n-1)

number=5
result=factorial(number)
print(number,"factorial for the number is",result)
```
