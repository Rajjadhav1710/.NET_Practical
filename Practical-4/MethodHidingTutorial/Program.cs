using System;

public class My_Family {

	public void member()
	{
		Console.WriteLine("Total number of family members: 3");
	}
}

// Derived Class
public class My_Member : My_Family {

	public new void member()
	{
		Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, "+"Age: 39 \nName: Rohan, Age: 20 ");
	}
}


class MyClass {

	static public void Main()
	{
		Console.WriteLine("--------------------------------------------------");
      	Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
      	Console.WriteLine("--------------------------------------------------");

		My_Member obj = new My_Member();

		obj.member();
	}
}
