namespace Delegates_Demo
{
    public delegate void MyDelegate(string msg); //declaring a delegate

    internal class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate d1 = new MyDelegate(A.M1);
            //d1.Invoke("I am void method M1()"); // invoke

            //MyDelegate d1 = A.M1;
            //d1("I am void method M1()"); // invoke

            // following lambda expression is assigned to delegate.
            //MyDelegate d1 = (string param) =>
            //{
            //    Console.WriteLine($"This one :{param}");
            //};

            //d1("I am param using lambda => expression syntax");


            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);

            del = (string msg) =>
            {
                Console.WriteLine($"Inside lambda expression: {msg}");
            };

            InvokeDelegate(del);

            static void InvokeDelegate(MyDelegate del)
            {
                del.Invoke("Hello world");
            }

        }
    }

    //public class A
    //{
    //    public static void M1(string msg)
    //    {
    //        Console.WriteLine(msg);
    //    }
    //}



    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
