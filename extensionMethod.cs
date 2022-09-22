// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
namespace ExtensionMethods
{
    public class ExtClass{
        public void test1()
        {
            Console.WriteLine("Test1 Method");
        }
        public void test2()
        {
            Console.WriteLine("Test2 Method");
        }
    }
    public class child:ExtClass{
      int i=10;
        
    }
    
    static class ExtensionClass
    {
        public static void test3(this ExtClass e)
        {
            Console.WriteLine("this is extension method");
        }
        
        public static int fact(this Int32 i)
        {
            if (i<=1)
            return 1;
            else
            return i*(i-1);
            
        }
    }
    

    public class HelloWorld
    {
        
        
        public static void Main(string[] args)
        {
            ExtClass e= new ExtClass();
            e.test1();
            e.test2();
            e.test3();
            child c = new child();
            c.test3();
            
            int i =10;
            Console.WriteLine(i.fact());
            
        }
    }
}

/*
Test1 MethodTest2 Method
this is extension method
this is extension method
90
*/
