namespace Delegates_Demo
{
    public delegate void MyDelegate(string msg); //declaring a delegate


    public delegate T Add<T>(T param1, T param2); // generic delegate


    internal class Program
    {
        static void Main(string[] args)
        {

            Add<int> add = ClassA.Sum;
            Console.WriteLine(add.Invoke(100, 500));

            Add<string> addConcat = ClassA.Concat;
            Console.WriteLine(addConcat("Walidad", "Brohi"));


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


            //MyDelegate del = ClassA.MethodA;
            //InvokeDelegate(del);

            //del = ClassB.MethodB;
            //InvokeDelegate(del);

            //del = (string msg) =>
            //{
            //    Console.WriteLine($"Inside lambda expression: {msg}");
            //};

            //InvokeDelegate(del);

            //static void InvokeDelegate(MyDelegate del)
            //{
            //    del.Invoke("Hello world");
            //}


            // MyDelegate del1 = ClassA.MethodA;
            // MyDelegate del2 = ClassB.MethodB;

            // // combines del1 + del2 and assigned into del
            // MyDelegate del = del1 + del2;
            // // del("Hello World");

            // MyDelegate del3 = (string msg) => Console.WriteLine($"Called lambda expression: {msg}");
            // del += del3;

            //// del("Hello world");

            // del -= del1 - del2;

            //// del("Hello world");

            //del -= del1;
            //del("Hello world");

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

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return $"{str1} - {str2}";
        }

        public static void MethodA(string message)
        {
            Console.WriteLine($"Called ClassA.MethodA() with parameter: {message}");
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine($"Called ClassB.MethodB() with parameter: {message}");
        }
    }
}
