//1
// using System;

// class TimePeriod
// {
//    private double _seconds;

//    public double Hours
//    {
//        get { return _seconds / 3600; }
//        set {
//           if (value < 0 || value > 24)
//              throw new ArgumentOutOfRangeException(
//                    $"{nameof(value)} must be between 0 and 24.");

//           _seconds = value * 3600;
//        }
//    }
// }

// class Program
// {
//    static void Main()
//    {
//       Console.WriteLine("--------------------------------------------------");
//       Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
//       Console.WriteLine("--------------------------------------------------");
//        TimePeriod t = new TimePeriod();
//        // The property assignment causes the 'set' accessor to be called.
//        t.Hours = 24;

//        // Retrieving the property causes the 'get' accessor to be called.
//        Console.WriteLine($"Time in hours: {t.Hours}");
//    }
// }
// // The example displays the following output:
// //    Time in hours: 24

//2
// using System;

// public class Person
// {
//    private string _firstName;
//    private string _lastName;

//    public Person(string first, string last)
//    {
//       _firstName = first;
//       _lastName = last;
//    }

//    public string Name => $"{_firstName} {_lastName}";
// }

// public class Example
// {
//    public static void Main()
//    {
//       Console.WriteLine("--------------------------------------------------");
//       Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
//       Console.WriteLine("--------------------------------------------------");
//       var person = new Person("Raj", "Jadhav");
//       Console.WriteLine(person.Name);
//    }
// }
// // The example displays the following output:
// //      Magnus Hedlund

//3
// using System;

// public class SaleItem
// {
//    string _name;
//    decimal _cost;

//    public SaleItem(string name, decimal cost)
//    {
//       _name = name;
//       _cost = cost;
//    }

//    public string Name
//    {
//       get => _name;
//       set => _name = value;
//    }

//    public decimal Price
//    {
//       get => _cost;
//       set => _cost = value;
//    }
// }

// class Program
// {
//    static void Main(string[] args)
//    {
//       Console.WriteLine("--------------------------------------------------");
//       Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
//       Console.WriteLine("--------------------------------------------------");
//       var item = new SaleItem("Shoes", 19.95m);
//       Console.WriteLine($"{item.Name}: sells for ${item.Price}");
//    }
// }
// // The example displays output like the following:
// //       Shoes: sells for $19.95

//4
// using System;

// public class SaleItem
// {
//    public string Name
//    { get; set; }

//    public decimal Price
//    { get; set; }
// }

// class Program
// {
//    static void Main(string[] args)
//    {
//       Console.WriteLine("--------------------------------------------------");
//       Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
//       Console.WriteLine("--------------------------------------------------");
//       var item = new SaleItem{ Name = "Shoes", Price = 19.95m };
//       Console.WriteLine($"{item.Name}: sells for ${item.Price}");
//    }
// }
// // The example displays output like the following:
// //       Shoes: sells for $19.95