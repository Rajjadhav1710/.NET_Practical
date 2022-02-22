using System;

class Account{
    public double balance;
    public delegate void Del();

    public Del checkBalance;

    public Account(double balance){
        this.balance=balance;

        this.checkBalance=()=>{
            if(this.balance<0){
                Console.WriteLine($"\nBalance:{this.balance} you are overdrawn");            
            }else if(this.balance<10){
                Console.WriteLine($"\nBalance:{this.balance} your account is very low");
            }else if(this.balance<100){
                Console.WriteLine($"\nBalance:{this.balance} watch your spending carefully");
            }else{
                Console.WriteLine($"\nBalance:{this.balance} you have over $100 in your account");
            }
        };
    }
}

class Driver{
    public static void Main(){
        Account ac=new Account(200);
        ac.checkBalance();

        ac.balance=50;
        ac.checkBalance();

        ac.balance=5;
        ac.checkBalance();

        ac.balance=-5;
        ac.checkBalance();
    }
}