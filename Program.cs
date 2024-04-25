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
