using System;
class MyClass {

	public int multiply2(int a, int b)
	{
		return a*b;
	}

	public int multiply3(int a, int b, int c)
	{
        return a*b*c;
	}

	public static void Main(String[] args)
	{
		Console.WriteLine("--------------------------------------------------");
      	Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
      	Console.WriteLine("--------------------------------------------------");
		MyClass obj = new MyClass();

		int mul1 = obj.multiply2(5, 2);
		Console.WriteLine("Multiplication of the two "
						+ "integer value : " + mul1);

		int mul2 = obj.multiply3(5, 2, 3);
		Console.WriteLine("Multiplication of the three "
						+ "integer value : " + mul2);
	}
}
