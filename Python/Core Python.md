# Core Python.
## Python Download.

        

    https://www.python.org/downloads/
    
## Pycharm Download.
    https://www.jetbrains.com/pycharm/download/#section=windows

## Basic Concepts of Python:
### Data types in python:
 * Integer:
            
       operation on integers:
        a=20;
        b=30;
        c=a+b;
        print(c);
       answer=50..
   ### To find the length of an String:
       Name="Shashikumar reddy"
       print(name[0:7]);
       Answer:Shashi
    ### To find the length of an String in rev (only single word) :
         Name="Shashikumar reddy"
         print(name[-4]);
         Answer:e
   ### How to comment in single line:
      
          #Shashi is too lazy.
          #Anand works hard.
   ### How to comment in multiline:
        """
        Work hard for better process.
        Otherwise its tough to survive 
        in the society.
        """
   
   ### What are Variables?
   
        Variables which have a reserved memory location to store values.
       eg:
        x=20
        x="Shashi"
        y=2.0
        
   ### Rules of variables:
   
        1.Variables name must start with the alphabet or underscore .
        2.A variable cannot start with a number.
        3.A variable name can only contain alpha-numeric characters and under scores.

### Cases of Variables:

        1.Camel Case 
        There is hump based on that they have named it is a camel case.
        eg: myVariable='shashi'
        
        2.Pascal Case
        It came the word from Pascal programming language which starts from Capital alphabet.
        eg: My_Name='shashi'
        
        3.Snake Case
        It start with underscore looks like snake so it named as snake case.
        eg: my_name_='shashi'
        
    
   ### Assigning multiple variables:
   
       eg: x,y,z="shashi","kusuma vadina","anand"
        print(x)
        print(y)
        print(z)
        
        
       eg2:
       x=y=z="shashi"
       print(x)
       print(y)
       print(z)
       
       if you want to imort from the word which contain the values in it.
       
      eg:
      shashi=['Hardwork','Dedication','Goal']
      print(shashi)
      
      eg2:
      shashi=['Hardwork','Dedication','Goal']
      x,y,z='Hardwork','Dedication','Goal'
      print(x)
      print(y)
      print(z)
      
  ### Global Variables
        x='Awsome'
        def myfunc()
        print("Python is" +x)
        myfunc()
      
 ### Data types in Python.
        1.string-str(which is a text data type)
        2. Integer.
        3.Float.
        4.Complex.
        5.List.
        6.Tuple.
        7.Range.
        8.Set.
        9.Dictionary.
        
  ## String.
       x=("Hello World")
       print(x)
       print(type(x))

  ## Interger.
        x=10
        print(x)
        print(type(x))
        
  ## Float.
        x=10.0
        print(x)
        print(type(x))
  ## Complex.
        x=3+1j
        print(x)
        print(type(x))
        
   ## List.
        x=["apple","banana","sweet"]
        print(x)
        print(type(x))
   
   ## Tuple.
        x=("apple","banana","grapes")
        print(x)
        print(type(X))
        
   ## Set.
        x={"apple","banana","nuts"}
        print(x)
        print(type(x))
        
   ## Dictionary.
        x={
            "apple":"red",
            "grape":"blue",
            "orange":"orangetype"
            }
        print(x)
        
   ## Range.
        x=("Hello,Wolrd")
        y=x.range(2:6)
        print(y)

### Number Casting:
    Number casting is a technique of changing number into different data types:
    eg:
     x=int('3')
     y=float(3)
     z=str(3)
     print(x)
     print(y)
     print(z)
     output is:3,3.0,'3'.

### Strings and Its Types:
    a)Slicing String.
    b)Modification String.
    c)Concatenate String.
    d)Format Strings.
    e)String Methods.
    f)String Exercises.
    
    
## Slicing Strings:
    a="hello world"
    b=a[2:5]
    print(b)
    
### slicing from start:
    a="hello hi how r u"
    b=a[:6]
    print(b)
    
### Slicing from the end:
    a="hello world"
    b=a[0:]
    print(b)
    
### Negative Indexing:
    a="Hello world"
    b=a[-5:-3]
    print(b)
    
### Modifying the strings to upper case:
    a="Hello World"
    b=a.upper()
    print(b)
    
### Modifying the string to lower case :
    a="Hello world"
    b=a.lower()
    print(b)

### Removing White space:
    It means removing the space infront of the words:
    a=" Hello World "
    b=a.strip()
    print(b)
  
### Replacing a string :
    a="Hello World"
    b=a.replace("H","T")
    print(b)
    
### Spliting a string:
    a="Hello World"
    b=a.split()
    print(b)
    
### Concatinating a String:
    a="Hello"
    b="World"
    c=a+b
    print(c)

### Format Strings:
    age=20
    b=("My name is Shashi and my age is "+age)
    prrint (b)
    
    eg2:
    age=21
    txt="My name is shashi and my age {}"
    b=txt.format(age)
    print(b)
    
    eg3:
    age=21
    name="Shashi"
    text="My age is {},and they call me {}"
    print(text)
    
## String Methods.

   ## Capitalize:
        It convert first character into Capital letter.
        eg:
        a="Hello world"
        b=a.capitalize()
        print(b)
        
   ## Casefold:
        Converts string into lowercase.
        a="Hello World"
        b=a.casefold()
        print(b)
        
   ## Center:
        which will place the text at the center.
        eg:
        x="shashi"
        b=x.center(20)
        print(b)
        
   ## count:
        It will return number of values present same one or same alphabets or words etc.
        eg:
        x="Hello world"
        a=x.count('0')
        print(a)
        
   ## ends with:
         what ever in the paranthesis it should match with last if that match it shows True otherwise False.
         a="Hello world."
         b=a.endswith(".")
         print(b)
   
   ## Finding a element in a String:
        It find where the element present in the list or in the string;
        eg:
        a="hello bro"
        b=a.find("o")
        print(b)
        
   ## To find a Format in String
   
        a="the cost of book is {price.2f} rupees"
        b=a.format(price=200)
        print(b)
        
       
   ### Reversing the function:
        A=[1,2,3,4,5,6]
        def reverse:
            a.reverse()
            return a 
        print(reverse(a))
       output: 6,5,4,3,2,1.
       
   ### Multiline strings:
        a="Hi,shashi how r u,
           im good how is your life ,
           what else your doing.
        print(a)
        
        
  ### Boolean Variable:
  
        It compares to other operators and gives the output in the form of True Of False.
        Examples:
        print(6>5)
        print(6==6)
        print(6<6)
        print("str"="str")
        Output:
        True
        False
        False
        True
        
        eg2:
        a=200
        b=300
        if (a>b):
        print("A is greater then b")
        else:
        print("B is greater then a")
        
  ### Using bool() keyword:
        print(bool(False))
        print(bool(None))
        print(bool(0))
        all will be false because None and 0 will be null so null things mentioned false in boolean .
        print(bool(1))
        ans:True .
        
  ### How to know methods of the list:
       1) help(list)
       2) print(dir(list))
       
 ## LIST AND ITS METHODS:
       A=[1,2,3,4,5]
       print(A)
       print(type(A))
       
 ### Converting list to Tuple:
        def convert(list):
            return tuple(list)
        list=["a","b","c","d","e"]
        print(convert(list))
        
 ### Another form of converting list to tuple:
        a=[1,2,3,4,5,6]
        print(tuple(a))
  
  ### Converting list to set:
         a=[1,2,3,4,5,6]
         print(set(a))
   
   ### Inserting into a list:
        list=['a','b','c','d','e','f']
        list.insert(1,"s")
        print(list)
   
   ### Reversing a list:
        list=[1,2,3,4,5,6,7]
        list.reverse()
        print(list)
        
   ### Indexing a list:
   
        list=[1,2,3,4,5,6,7]
        print(list.index(5))

   ### Appending the element to a list:
        list=[1,2,3,4,5,6,7]
        list.append(8)
        print(list)
        
   ### Counting elements in a list:
        list=[1,2,3,4,5,6,7,7]
        print(list.count(7))
        output: 7 displayed twice .
      
 ### Finding the index in the list:
        a=[1,2,3,4,5,6]
        b=a.index(4)
        print(b)
        
 ### Counting the element in list:
        a=[1,2,3,4,5,6]
        b=a.count(4)
        print(b)
       
  ## Operations in Tuple:
        a=(1,2,3,4,5,6,7)
        print(a)
        
  ### Adding Two Tuples:
        a=(1,2,3,4)
        b=("a","b","c","d")
        c=a+b
        print(c)
        
   ### Counting the elements in tuple:
        a=("a","b","c","d","a")
        b=a.count("a")
        print(b)
        
   ### Indexing in Tuple:
        k=(1,2,3,4,5,6,7,8)
        print(k.index(4))
        
   ## Operations on Sets:
  
   ### Poping an element using sets:
        x={"shashi","anand","kusuma vadina","someone"}
        print(x.pop())
       It will remove last element but sets are unordered so  It will delete random element in the set.
       
   ### Removing the element from the set:
        x = {1, 2, 3, 4, 5, 6, 7}
        x.remove(6)
        print(x)
   ### Discarding the element from the set:
        x = {1, 2, 3, 4, 5, 6, 7}
        x.discard(9)
        print(x)
        Difference is that compred to remove .discard wont be showing error even the elemnt not present in that set.
        
   ### To Union the elements:
        x = {1, 2, 3, 4, 5, 6, 7}
        y={8,9,0}
        print(x.union(y))
   ### Intersection of the element:
           a={"apple","banana","grape"}
           b={"peanut","microsoft","banana"}
           c=a.intersection(b)
           print(c)
           
   ### To Update the element 
        x={"apple","banna","orange"}
        y={"grapes"}
        x.update(y)
        print(x)
   ## Dictionary :
   ### printing the dictionary elements:
        Dict={
                "Name":"Shashi",
                "Regno":11902910,
                "Course":"B-Tech"
              }
        print(Dict) 
        
   ### Get() in Dictionary:
        Dict={
                "Name":"Shashi",
                "Regno":11902910,
                "Course":"B-Tech"
              }
        print(Dict.get("Name"))
        
   ### Keys() in Dictionary:
        Dict={
                "Name":"Shashi",
                "Regno":11902910,
                "Course":"B-Tech"
              }
        print(Dict.keys())
       Output: dict_keys(['Name', 'Regno', 'Course'])
       
   ### Values() in Dictionary:
         Dict={
                "Name":"Shashi",
                "Regno":11902910,
                "Course":"B-Tech"
              }
        print(Dict.values())
        output:dict_values(['Shashi', 11902910, 'B-Tech']) 
        
   ### fromkeys() in Dictionary:
         Dict={
                "Name":"Shashi",
                "Regno":11902910,
                "Course":"B-Tech"
              }
         print(Dict.fromkeys())
         output:{'C': None, 'o': None, 'u': None, 'r': None, 's': None, 'e': None}

   ### Items() in Dictionary:
   Which shows seperately key with values with in the paranthesis.
        Dict={
                 "Name":"Shashi",
                 "Regno":11902910,
                 "Course":"B-Tech"
             }
        print(Dict.items())
        output:dict_items([('Name', 'Shashi'), ('Regno', 11902910), ('Course', 'B-Tech')])
        
   ### Copy() in Dictionary:
        It takes or copies same dictionary twice.
                dict={
                 "name":"shashii",
                 "course":"Btech",
                 "Reg":119029010
                       }
                print(dict)
                print(dict.copy())
                Output:
                {'name': 'shashii', 'course': 'Btech', 'Reg': 119029010}
                {'name': 'shashii', 'course': 'Btech', 'Reg': 119029010}
   
   ### Pop() in Dictionary:
                dict={
                 "name":"shashii",
                 "course":"Btech",
                 "Reg":119029010
                       }
                print(dict)
                print(dict.pop("course"))
                print(dict)
                output:
                {'name': 'shashii', 'Reg': 119029010}
                
    
  ## OPERATORS:
        1) Arithmetic Operator.
        2) Assignment Operator.
        3) Comparision Opearator.
        4) Logical Operator.
        5) Identify Operator.
        6) Membership Operator.
        7) Bitwise Operator.
        
 ### Arithmetic Operator:
        +  Addition (x+y)
        -  Subtraction (x-y)
        *  Multiplication (x*y)
        /  Division (x/y)
        %  Modulus  (x%y)
        ** Exponentiation (x**y)
        // Floor Division (x//y)
        
### Assignment Operator:

        Assignment operator is used to assign values to variables.
        
        +=  x+=3    x=x+3
        
        -=  x-=3    x=x-3
        
        *=  x*=3    x=x*3
        
        %=  x%=3    x=x%3
        
        //= x//=3   x=x//3
        
        **= x**=3   x=x**3
        
### Comparison Operator:
    Comparision Operator is used to compare two values.
    
    ==  equal       x==y
    !=  not equal   x!=y
    >   greater than x>y
    <   less than   x<y
    >=  greater than x>=y
    <=  less than   x<=y
    
  Example:
    == 
    
    x=5
    y=6
    print(x==y)
    
    !=
    
    x=5
    y=6
    print(x!=y)
    
    >
    x=5
    y=6
    print(x>y)
    
    <
    x=10
    y=16
    print(x<y)
    
    <=
     x=10
    y=16
    print(x<=y)
    
    >=
     x=5
    y=6
    print(x>y)
    
  ## Logical Operators:
        Logical operators are used to combine conditional statement:
        The types of logical Operators are:
        1)And
        2)OR
        3)Not    
      
   ### And Operator.
        Both the conditions should be true mandatorily.
        
        x=10
        if x>7 and x<12:
           print("hi")
        else:
           print("hello")
        
   ### OR Operator:
   Any one condition should be True.
        x=10
        if x>7 or x<5:
           print("hi")
        else:
           print("hello")
     
   ### Not Operator:
        It prints opposite to the answer.
                x=10
                if not(x>7 and x<13):
                   print("hi")
                else:
                   print("hello")
       
   ## Identity Operators:
   ### is  
                x=10
                y=10
                print(x is y)                
  
  ### is not
                x=["apple","grapes"]
                y=["apple","grapes"]
                print(x is not y)
                if this both equal also x and y cant be same as it stored different locations and in different variables.
                
   ## Membership Operators:
   
   ### in
                x = ["apple", "grapes"]
                print("apple" in x)
                output:True
            
   ### not in
                x = ["apple", "grapes"]
                print("Orange" not in  x)
                Output:true
                
                
  ## LOOPS:
        1)While Loop
        2)For Loop
        
   ## While loop:
        eg1:
        
        i=0
        while i<=6:
          print(i)
          i=i+1
          
         eg2:
         i=1
        while i<=5:
           print("shashi",end="")
           j=1
           while j<=1:
             print("kumar",end="")
             j=j+1
           i=i+1
            print("")
        eg3:
        i=1
        while i<=5:
        print("shashi")
        i=i+1
        

            
       
        
        
        
   
        
   
