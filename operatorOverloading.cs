// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


namespace calculator{
    



public class calculator{
    public int num1,num2;
    public calculator(int n1,int n2)
    {
        num1=n1;
        num2=n2;
    }
    public static calculator operator +(calculator c1,calculator c2){
        c1.num1=c1.num1+c2.num1;
        // c1.num2=-c1.num2;
        c1.num2=c1.num2+c2.num2;
        return c1;
    }
    public static calculator operator -(calculator c1,calculator c2){
        c1.num1=c1.num1-c2.num1;
        // c1.num2=-c1.num2;
        c1.num2=c1.num2-c2.num2;
        return c1;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Console.WriteLine ("Hello Mono World");
        calculator c1 = new calculator(12,43);
        calculator c2 = new calculator(10,20);
        c1=c1+c2-c2;
        Console.WriteLine("num1 {0}, num2 {1}",c1.num1,c1.num2);
        
        // Ap a = new Ap();
        // int b = a.hello(10,20);
        // Console.WriteLine(b);
    }
}

    
}

