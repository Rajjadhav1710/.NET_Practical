//1
// public static void CallAnonymousMethod()

// {

// bool positive = new Func<int, bool>(delegate (int int32) { return int32 > 0; })(1);

// new Action<bool>(delegate (bool value) { Trace.WriteLine(value); })(positive);

// }

// public static void CallLambda()

// {

// bool positive = new Func<int, bool>(int32 => int32 > 0)(1);

// new Action<bool>(value => Trace.WriteLine(value))(positive);

// }

//2
using System;
class Driver{
    public static void Main(){
        //1
        Console.WriteLine("\n1st Code Snippet:-\n");
        double x,y;
        Console.Write("\nEnter Value For x:");
        x=Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter Value For y:");
        y=Convert.ToDouble(Console.ReadLine());

        var parse = (double x, double y) => (x > y ? x : y);
        Console.WriteLine("\nGreater Value:"+parse(x,y));


        //2
        Console.WriteLine("\n2nd Code Snippet:-\n");
        Func<double, double, double> f =(x, y) => {
            if (x > y)
                return x;
            return y;

        };

        double z = f(10, 20);
        Console.WriteLine("\nGreater Value Between 10 And 20:"+z+"\n");

        //3
        // double z;
        // Func<double, double, double> f;
        Console.WriteLine("\n3rd Code Snippet:-\n");
        f = (x, y) => {
            if (x > y)
                return x;
            return y;
        };

        z = f(10, 20);
        Console.WriteLine("\nGreater Value Between 10 And 20:"+z+"\n");

        // z holds 20.

        f = (x, y) => {
            if (x < y)
                return x;
            return y;
        };

        z = f(10, 20);
        Console.WriteLine("\nSmaller Value Between 10 And 20:"+z+"\n");
    }
}