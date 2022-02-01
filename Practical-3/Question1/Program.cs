using System;

class DoTheMath {
    static void Main(){

        int numerator,denominator;

        Console.WriteLine("\nPlease enter the numerator?");
        numerator=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the denominator");
        denominator=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInteger division result = "+numerator/denominator+" with a remainder "+numerator%denominator);

        Console.WriteLine("\nFloating point division result = "+((double)numerator)/denominator);
        
        Console.WriteLine("\nThe result as a mixed fraction is "+numerator/denominator+" "+numerator%denominator+"/"+denominator+".\n");
    }
}