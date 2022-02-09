using System;

class Employee{
    private string _firstName;
    private string _lastName;
    private double _monthlySalary;

    public Employee(string firstName,string lastName,double monthlySalary){
        this._firstName=firstName;
        this._lastName=lastName;
        this._monthlySalary=monthlySalary;
    }

    public string firstName
    {
        get => _firstName;
        set =>_firstName=value;
    }

    public string lastName
    {
        get => _lastName;
        set =>_lastName=value;
    }

    public double monthlySalary
    {
        get => _monthlySalary;
        // set => _monthlySalary=value;
        set{
            if(value<0){
                _monthlySalary=0.0;
            }else{
                _monthlySalary=value;
            }
        }
    }

    public double yearlySalary
    {
        get{
            return monthlySalary*12;
        }
    }

    public virtual void giveRaise(){
        monthlySalary+=0.1*monthlySalary;
    }

    public override string ToString()
    {
        return "\nFirst Name:"+firstName+" , Last Name:"+lastName+" , Yearly Salary:"+yearlySalary+"\n";
    }

}

class PermanentEmployee : Employee{
    private double _HRA;

    private double _DA;

    private double _providentFund;

    private double _totalMonthlySalary;

    private DateOnly _joiningDate;

    private DateOnly _expectedRetirementDate;

    public PermanentEmployee(string firstName,string lastName,double monthlySalary,double HRA,double DA,double providentFund,DateOnly joiningDate,DateOnly expectedRetirementDate):base(firstName,lastName,monthlySalary)
    {
        this._HRA=HRA;
        this._DA=DA;
        this._providentFund=providentFund;
        this._joiningDate=joiningDate;
        this._expectedRetirementDate=expectedRetirementDate;
        this._totalMonthlySalary=monthlySalary+HRA+DA+providentFund;
    }

    public double HRA => _HRA;

    public double DA => _DA;

    public double providentFund => _providentFund;

    public DateOnly joiningDate => _joiningDate;

    public DateOnly expectedRetirementDate => _expectedRetirementDate;

    public double totalYearlySalary
    {
        get{
            return _totalMonthlySalary*12;
        }
    }

    public override void giveRaise(){
        _totalMonthlySalary+=0.1*_totalMonthlySalary;
    }

    public override string ToString()
    {
        return "\nFirst Name:"+firstName+" , Last Name:"+lastName+" , Total Yearly Salary:"+totalYearlySalary+" , HRA:"+HRA+" , DA:"+DA+" , Provident Fund:"+providentFund+"\n";
    }

    public void displayJoiningDate(){
        Console.WriteLine("\n Name Of Employee:"+firstName+","+lastName+" Joining Date:"+joiningDate+"\n");
    }

    public void displayExpectedRetirementDate(){
        Console.WriteLine("\n Name Of Employee:"+firstName+","+lastName+" Expected Retirement Date:"+expectedRetirementDate+"\n");
    }

}

class EmployeeTest{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("\nName:Raj Sanjay Jadhav, PRN:2019033800129402\n");
        Console.WriteLine("--------------------------------------------------");
        //1
        // Employee emp1=new Employee("john","doe",10000);
        // Employee emp2=new Employee("raj","jadhav",20000);
        
        // Console.WriteLine(emp1);
        // Console.WriteLine(emp2);
        // emp1.giveRaise();
        // emp2.giveRaise();
        // Console.WriteLine("\nAfter Raise In Salary Employee Details:\n");
        // Console.WriteLine(emp1);
        // Console.WriteLine(emp2);

        //2
        PermanentEmployee emp1=new PermanentEmployee("john","doe",10000,1000,1000,1000,new DateOnly(2001,10,1),new DateOnly(2023,10,1));
        PermanentEmployee emp2=new PermanentEmployee("raj","jadhav",20000,2000,2000,2000,new DateOnly(2001,10,17),new DateOnly(2023,10,17));

        Console.WriteLine("Before Raising Salary:\n");
        Console.WriteLine(emp1);
        Console.WriteLine(emp2);

        emp1.giveRaise();
        emp2.giveRaise();

        Console.WriteLine("After Raising Salary:\n");
        Console.WriteLine(emp1);
        Console.WriteLine(emp2);

        emp1.displayJoiningDate();
        emp1.displayExpectedRetirementDate();

        emp2.displayJoiningDate();
        emp2.displayExpectedRetirementDate();
    }
}