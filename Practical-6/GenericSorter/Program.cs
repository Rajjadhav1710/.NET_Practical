using System;

class Sorter{
    public static void selectionSort<T>(T []arr,Func<T,T,bool> compare)
    {
        int n = arr.Length;
  
        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (compare(arr[j],arr[min_idx]))//arr[j] < arr[min_idx]
                    min_idx = j;

            T temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
}

class Employee{
    string empName;
    int empId;
    double empSalary;
    int age;

    public Employee(int empId,string empName,double empSalary,int age){
        this.empId=empId;
        this.empName=empName;
        this.empSalary=empSalary;
        this.age=age;
    }

    public static bool compareEmpsById(Employee x,Employee y){
        if(x.empId<y.empId)
            return true;
        else 
            return false;
    }

    public static bool compareEmpsBySalary(Employee x,Employee y){
        if(x.empSalary<y.empSalary)
            return true;
        else 
            return false;
    }

    public static bool compareEmpsByAge(Employee x,Employee y){
        if(x.age<y.age)
            return true;
        else 
            return false;
    }

    public override string ToString()
    {
        return $"Employee Id:{this.empId} Name:{this.empName} Salary:{this.empSalary} Age:{this.age}";
    }
}

class Driver{

    // Prints the array
    static void printArray<T>(T []arr)
    {
        int n = arr.Length;
        for (int i=0; i<n; ++i)
            Console.WriteLine(arr[i]);
        Console.WriteLine();
    }

    static bool compareInts(int x,int y){
        if(x<y)
            return true;
        else 
            return false;
    }

    public static void Main(){
        Console.WriteLine("Sorting Int Array...");
        int []arr = {64,25,12,22,11};
        Sorter.selectionSort<int>(arr,compareInts);
        Console.WriteLine("Sorted array:");
        printArray<int>(arr);

        Employee []Emps=new Employee[5];

        Emps[0]=new Employee(7,"Joe",10000,23);
        Emps[1]=new Employee(2,"Mark",2000,25);
        Emps[2]=new Employee(5,"Sam",20000,32);
        Emps[3]=new Employee(1,"Virat",5000,22);
        Emps[4]=new Employee(10,"Karan",55000,35);

        Console.WriteLine("Sorting Employees By Age:\n");
        Sorter.selectionSort<Employee>(Emps,Employee.compareEmpsByAge);
        Console.WriteLine("Sorted array:");
        printArray<Employee>(Emps);

        Console.WriteLine("Sorting Employees By Id:\n");
        Sorter.selectionSort<Employee>(Emps,Employee.compareEmpsById);
        Console.WriteLine("Sorted array:");
        printArray<Employee>(Emps);

        Console.WriteLine("Sorting Employees By Salary:\n");
        Sorter.selectionSort<Employee>(Emps,Employee.compareEmpsBySalary);
        Console.WriteLine("Sorted array:");
        printArray<Employee>(Emps);
    }
}