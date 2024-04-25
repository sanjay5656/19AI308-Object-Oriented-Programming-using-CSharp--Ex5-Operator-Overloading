# 19AI308-Object-Oriented-Programming-using-CSharp--Ex5-Operator-Overloading
# AIM:
To write a C# program to pass values through constructors(default and parameterized) and also overload equal operators by checking whether objects are equal using operator overloading. 
# ALGORITHM:

## step 1:

Initialize a default and a parameterized constructor.

## step 2:

Overload using equalto symbols.

## step 3:

Write the code to implement main function.

## step 4:

Create objects obj1,obj2 and obj3.

## step 5:

Check the equality.

# PROGRAM:
```
Developed by  : Sanjay S
Register no   : 212221243002
```

```c#
using System;

class MyClass
{
    private int value;
    public MyClass()
    {
        this.value = 0;
    }
    public MyClass(int value)
    {
        this.value = value;
    }
    public int GetValue()
    {
        return value;
    }
    public static bool operator ==(MyClass obj1, MyClass obj2)
    {
        if (obj1 is null || obj2 is null)
            return false;
        return obj1.value == obj2.value;
    }
    public static bool operator !=(MyClass obj1, MyClass obj2)
    {
        return !(obj1 == obj2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(); 
        MyClass obj3 = new MyClass(10);
        Console.WriteLine("Are obj1 and obj2 equal? " + (obj1 == obj2));
        Console.WriteLine("Are obj1 and obj3 equal? " + (obj1 == obj3));
    }
}
```

# OUTPUT:
![alt text](<Screenshot (34).png>)

# RESULT:

Thus,the program to illustrate operating overloading is successfully implemented.


