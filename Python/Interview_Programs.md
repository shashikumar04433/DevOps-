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
