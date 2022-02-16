using System;

class Vehicle{
    string rentType;//'/km'OR'/day'
    double rentPerUnit;
    int age;//in years
    public string vehicleNumber;
    DateTime lastMaintenanceDate;

    public Vehicle(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate){
        this.rentType=rentType;
        this.rentPerUnit=rentPerUnit;
        this.age=age;
        this.vehicleNumber=vehicleNumber;
        this.lastMaintenanceDate=lastMaintenanceDate;
    }

    public string getRentType(){
        return this.rentType;
    }

    public double getRentPerUnit(){
        return this.rentPerUnit;
    }

    public override string ToString(){
        return "Rent Type:"+this.rentType+"\nRent Per Unit:"+this.rentPerUnit+"\nAge:"+this.age+"\nyears Vehicle Number:"+this.vehicleNumber+"\nLast Maintenance Date:"+this.lastMaintenanceDate.ToString("dd/MM/yyyy")+"\n";
    }

    public void printVehicleData(){
        Console.WriteLine("Rent Type:"+this.rentType+"\nRent Per Unit:"+this.rentPerUnit+"\nAge:"+this.age+"years \nVehicle Number:"+this.vehicleNumber+"\nLast Maintenance Date:"+this.lastMaintenanceDate.ToString("dd/MM/yyyy")+"\n");
    }
}

class Indica : Vehicle {
    string fuelType;
    int seater;

    public Indica(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate,int seater,string fuelType):base(rentType,rentPerUnit,age,vehicleNumber,lastMaintenanceDate){
        this.fuelType=fuelType;
        this.seater=seater;
    }
}

class Qualis : Vehicle {
    string fuelType;
    int seater;

    public Qualis(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate,int seater,string fuelType):base(rentType,rentPerUnit,age,vehicleNumber,lastMaintenanceDate){
        this.fuelType=fuelType;
        this.seater=seater;
    }
}

class Davidharley : Vehicle {

    public Davidharley(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate,int seater=1,string fuelType=""):base(rentType,rentPerUnit,age,vehicleNumber,lastMaintenanceDate){

    }
}

class MBenzEclass : Vehicle {
    int seater;

    public MBenzEclass(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate,int seater,string fuelType=""):base(rentType,rentPerUnit,age,vehicleNumber,lastMaintenanceDate){
        this.seater=seater;
    }
}

// class RentedIndica{
//     DateTime startDateOfRent;
//     DateTime endDateOfRent;
//     double noOfKmsTravelled;//approximately
//     double advancePayment;
//     bool isBooked;
//     Indica myIndica;

//     public RentedIndica(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate,int seater,string fuelType){

//         this.myIndica=new Indica(rentType,rentPerUnit,age,vehicleNumber,lastMaintenanceDate,seater,fuelType);
//         this.isBooked=false;
//     }

//     public void giveForRent(DateTime startDateOfRent,DateTime endDateOfRent,double noOfKmsTravelled,double advancePayment){
//         this.startDateOfRent=startDateOfRent;
//         this.endDateOfRent=endDateOfRent;
//         this.noOfKmsTravelled=noOfKmsTravelled;
//         this.advancePayment=advancePayment;
//         this.isBooked=true;
//     }

//     public double calculateRent(){
//         if(this.myIndica.getRentType()=="/km"){
//             return (this.noOfKmsTravelled*myIndica.getRentPerUnit())-this.advancePayment;
//         }else if(this.myIndica.getRentType()=="/day"){
//             return (((this.endDateOfRent-this.startDateOfRent).TotalDays)*myIndica.getRentPerUnit())-this.advancePayment;
//         }
//         return 0;
//     }
// }

// Cannot create an instance of the variable type 'T' because it does not have the new() constraint

// T in RentedVehicle<T> where T : new()
// 'T': cannot provide arguments when creating an instance of a variable type [GenericsTutorial]csharp

class RentedVehicle<T> where T : Vehicle{
    public DateTime startDateOfRent;
    public DateTime endDateOfRent;
    double noOfKmsTravelled;//approximately
    double advancePayment;
    public bool isBooked;
    public T myVehicle;

    public RentedVehicle(string rentType,double rentPerUnit,int age,string vehicleNumber,DateTime lastMaintenanceDate,int seater=1,string fuelType=""){

        this.myVehicle = (T)Activator.CreateInstance(typeof(T), new object[] { rentType,rentPerUnit,age,vehicleNumber,lastMaintenanceDate,seater,fuelType });

        this.isBooked=false;
    }

    public void giveForRent(DateTime startDateOfRent,DateTime endDateOfRent,double noOfKmsTravelled,double advancePayment){
        this.startDateOfRent=startDateOfRent;
        this.endDateOfRent=endDateOfRent;
        this.noOfKmsTravelled=noOfKmsTravelled;
        this.advancePayment=advancePayment;
        this.isBooked=true;
    }

    public double calculateRent(){
        if(this.myVehicle.getRentType()=="/km"){
            return (this.noOfKmsTravelled*myVehicle.getRentPerUnit())-this.advancePayment;
        }else if(this.myVehicle.getRentType()=="/day"){
            return (((this.endDateOfRent-this.startDateOfRent).TotalDays)*myVehicle.getRentPerUnit())-this.advancePayment;
        }
        return 0;
    }
}

class Owner{
    List<RentedVehicle<Indica>> indicaList = new List<RentedVehicle<Indica>>();
    List<RentedVehicle<Qualis>> qualisList = new List<RentedVehicle<Qualis>>();
    List<RentedVehicle<Davidharley>> davidharleyList = new List<RentedVehicle<Davidharley>>();
    List<RentedVehicle<MBenzEclass>> mbenzEclassList = new List<RentedVehicle<MBenzEclass>>();

    public Owner(){
        //4 indica
        this.indicaList.Add(new RentedVehicle<Indica>("/day",500,1,"GJ1",new DateTime(2021,1,1),6,"diesel"));
        this.indicaList.Add(new RentedVehicle<Indica>("/day",400,2,"GJ2",new DateTime(2020,1,1),6,"petrol"));
        this.indicaList.Add(new RentedVehicle<Indica>("/day",300,3,"GJ3",new DateTime(2019,1,1),6,"diesel"));
        this.indicaList.Add(new RentedVehicle<Indica>("/day",200,4,"GJ4",new DateTime(2018,1,1),6,"petrol"));
        //5 qualis
        this.qualisList.Add(new RentedVehicle<Qualis>("/day",800,1,"GJ5",new DateTime(2021,1,2),8,"diesel"));
        this.qualisList.Add(new RentedVehicle<Qualis>("/day",600,2,"GJ6",new DateTime(2020,1,2),8,"diesel"));
        this.qualisList.Add(new RentedVehicle<Qualis>("/day",500,3,"GJ7",new DateTime(2019,1,2),8,"diesel"));
        this.qualisList.Add(new RentedVehicle<Qualis>("/day",400,4,"GJ8",new DateTime(2018,1,2),8,"diesel"));
        this.qualisList.Add(new RentedVehicle<Qualis>("/day",350,5,"GJ9",new DateTime(2017,1,2),8,"diesel"));
        //2 davidharley
        this.davidharleyList.Add(new RentedVehicle<Davidharley>("/km",1000,1,"GJ10",new DateTime(2021,1,3)));
        this.davidharleyList.Add(new RentedVehicle<Davidharley>("/km",800,2,"GJ11",new DateTime(2021,1,3)));
        //2 mbenzEclass
        this.mbenzEclassList.Add(new RentedVehicle<MBenzEclass>("/km",2000,1,"GJ12",new DateTime(2021,1,4),4));
        this.mbenzEclassList.Add(new RentedVehicle<MBenzEclass>("/km",800,1,"GJ13",new DateTime(2021,1,4),4));
    }

    public void getCheckListRentedAndAvailableVehicle(){
        Console.WriteLine("\n--------------------Available Vehicle--------------------\n");
        Console.WriteLine("\n--------------------Indica--------------------\n");
        foreach(var vehicle in indicaList){
            if(!vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------Qualis--------------------\n");
        foreach(var vehicle in qualisList){
            if(!vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------Davidharley--------------------\n");
        foreach(var vehicle in davidharleyList){
            if(!vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------MBenzEclass--------------------\n");
        foreach(var vehicle in mbenzEclassList){
            if(!vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------Rented Vehicle--------------------\n");
        Console.WriteLine("\n--------------------Indica--------------------\n");
        foreach(var vehicle in indicaList){
            if(vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------Qualis--------------------\n");
        foreach(var vehicle in qualisList){
            if(vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------Davidharley--------------------\n");
        foreach(var vehicle in davidharleyList){
            if(vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
        Console.WriteLine("\n--------------------MBenzEclass--------------------\n");
        foreach(var vehicle in mbenzEclassList){
            if(vehicle.isBooked){
                Console.WriteLine(vehicle.myVehicle.ToString());
            }
        }
    }
// DateTime startDateOfRent,DateTime endDateOfRent,double noOfKmsTravelled,double advancePayment
    public void giveVehicleForRent(){
        DateTime startDateOfRent;
        DateTime endDateOfRent;
        double noOfKmsTravelled;
        double advancePayment;
        int year,month,day;

        Console.Write("\nEnter Start Date:");
        Console.Write("\nEnter Year:");
        year=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month:");
        month=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Day:");
        day=Convert.ToInt32(Console.ReadLine());
        startDateOfRent=new DateTime(year,month,day);

        Console.Write("\nEnter End Date:");
        Console.Write("\nEnter Year:");
        year=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month:");
        month=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Day:");
        day=Convert.ToInt32(Console.ReadLine());
        endDateOfRent=new DateTime(year,month,day);

        Console.Write("\nEnter No Of KMs:");
        noOfKmsTravelled=Convert.ToDouble(Console.ReadLine());

        Console.Write("\nEnter Advance Amount:");
        advancePayment=Convert.ToDouble(Console.ReadLine());

        Console.Write("\nEnter Vehicle Number For Booking:");
        string vehicleNumber=""+Console.ReadLine();

        foreach(var vehicle in indicaList){
            if(!vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("\nYour Ride Booked,Enjoy...\n");
                Console.WriteLine("Details Of Your Indica:\n");
                Console.WriteLine(vehicle.myVehicle.ToString());
                vehicle.isBooked=true;
                vehicle.giveForRent(startDateOfRent,endDateOfRent,noOfKmsTravelled,advancePayment);
                return;
            }
        }
        
        foreach(var vehicle in qualisList){
          if(!vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("\nYour Ride Booked,Enjoy...\n");
                Console.WriteLine("Details Of Your Qualis:\n");
                Console.WriteLine(vehicle.myVehicle.ToString());
                vehicle.isBooked=true;
                vehicle.giveForRent(startDateOfRent,endDateOfRent,noOfKmsTravelled,advancePayment);
                return;
            }
        }
        
        foreach(var vehicle in davidharleyList){
           if(!vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("\nYour Ride Booked,Enjoy...\n");
                Console.WriteLine("Details Of Your Davidharley:\n");
                Console.WriteLine(vehicle.myVehicle.ToString());
                vehicle.isBooked=true;
                vehicle.giveForRent(startDateOfRent,endDateOfRent,noOfKmsTravelled,advancePayment);
                return;
            }
        }
        
        foreach(var vehicle in mbenzEclassList){
            if(!vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("\nYour Ride Booked,Enjoy...\n");
                Console.WriteLine("Details Of Your MBenzEclass:\n");
                Console.WriteLine(vehicle.myVehicle.ToString());
                vehicle.isBooked=true;
                vehicle.giveForRent(startDateOfRent,endDateOfRent,noOfKmsTravelled,advancePayment);
                return;
            }
        }

        Console.WriteLine("\nPlease Enter Valid Vehicle Number\n");
    }

    public void showAvailabilityForBookingForGivenDate(){
        int year,month,day;
        Console.Write("\nEnter Year:");
        year=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month:");
        month=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Day:");
        day=Convert.ToInt32(Console.ReadLine());

        DateTime givenDate=new DateTime(year,month,day);

        Console.WriteLine("\n--------------------Available Vehicles--------------------\n");
        Console.WriteLine("\n--------------------Indica--------------------\n");
        foreach(var vehicle in indicaList){
            if(!vehicle.isBooked||!(givenDate>=vehicle.startDateOfRent&&givenDate<=vehicle.endDateOfRent)){
                Console.WriteLine(vehicle.myVehicle.ToString());

            }
        }
        Console.WriteLine("\n--------------------Qualis--------------------\n");
        foreach(var vehicle in qualisList){
            if(!vehicle.isBooked||!(givenDate>=vehicle.startDateOfRent&&givenDate<=vehicle.endDateOfRent)){
                Console.WriteLine(vehicle.myVehicle.ToString());
              
            }
        }
        Console.WriteLine("\n--------------------Davidharley--------------------\n");
        foreach(var vehicle in davidharleyList){
             if(!vehicle.isBooked||!(givenDate>=vehicle.startDateOfRent&&givenDate<=vehicle.endDateOfRent)){
                Console.WriteLine(vehicle.myVehicle.ToString());
           
            }
        }
        Console.WriteLine("\n--------------------MBenzEclass--------------------\n");
        foreach(var vehicle in mbenzEclassList){
            if(!vehicle.isBooked||!(givenDate>=vehicle.startDateOfRent&&givenDate<=vehicle.endDateOfRent)){
                Console.WriteLine(vehicle.myVehicle.ToString());
               
            }
        }

        
    }

    public void calculateRent(){
        string vehicleNumber;

        Console.WriteLine("\nEnter Vehicle Number To Calculate Rent:");
        vehicleNumber=Console.ReadLine();

        foreach(var vehicle in indicaList){
            if(vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("Vehicle Details:");
                Console.WriteLine(vehicle.myVehicle.ToString());
                Console.WriteLine("\nRent:"+vehicle.calculateRent()+"\n");
                return;
            }
        }
        
        foreach(var vehicle in qualisList){
            if(vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("Vehicle Details:");
                Console.WriteLine(vehicle.myVehicle.ToString());
                Console.WriteLine("\nRent:"+vehicle.calculateRent()+"\n");
                return;
            }
        }
        
        foreach(var vehicle in davidharleyList){
            if(vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("Vehicle Details:");
                Console.WriteLine(vehicle.myVehicle.ToString());
                Console.WriteLine("\nRent:"+vehicle.calculateRent()+"\n");
                return;
            }
        }
        
        foreach(var vehicle in mbenzEclassList){
            if(vehicle.isBooked&&vehicle.myVehicle.vehicleNumber==vehicleNumber){
                Console.WriteLine("Vehicle Details:");
                Console.WriteLine(vehicle.myVehicle.ToString());
                Console.WriteLine("\nRent:"+vehicle.calculateRent()+"\n");
                return;
            }
        }

         Console.WriteLine("\nEnter Valid Vehicle Number");
    }
}
public class Driver
{
    public static void Main(string[] args)
    {
        Owner o1=new Owner();
        int choice;
        while(true){
            Console.WriteLine("\n\nEnter 1:List Of Available And Rented Vehicles.");
            Console.WriteLine("Enter 2:Get Vehicle On Rent.");
            Console.WriteLine("Enter 3:Show Availability For Booking For Given Date.");
            Console.WriteLine("Enter 4:Calculate Rent For A Given Car.");
            Console.WriteLine("Enter 5:To Exit");
    
            choice=Convert.ToInt32(Console.ReadLine());

            switch(choice){
                case 1:
                o1.getCheckListRentedAndAvailableVehicle();
                break;
                case 2:
                o1.giveVehicleForRent();
                break;
                case 3:
                o1.showAvailabilityForBookingForGivenDate();
                break;
                case 4:
                o1.calculateRent();
                break;
                case 5:
                Environment.Exit(0);
                break;
            }

        }


        // DateTime start=new DateTime(2022,1,1);
        // DateTime end=new DateTime(2022,1,31);
        // DateTime temp=new DateTime(2021,1,3);
        // if(temp>=start&&temp<=end){
        //     Console.WriteLine("between");
        // }else{
        //     Console.WriteLine("not between");
        // }
        // // Console.WriteLine((end-start).TotalDays);

        // RentedIndica i1=new RentedIndica("/day",200,2,"gj1",new DateTime(2021,1,1),4,"petrol");
        // i1.giveForRent(new DateTime(2022,1,1),new DateTime(2022,1,15),200,0);
        // Console.WriteLine(i1.calculateRent());

        // RentedVehicle<Qualis> q1=new RentedVehicle<Qualis>("/day",100,1,"11",new DateTime(2021,1,1),6,"d");
        // q1.giveForRent(new DateTime(2022,2,17),new DateTime(2022,3,4),200,1000);
        // Console.WriteLine(q1.calculateRent());

        // Console.WriteLine(new DateTime(2022,2,1).ToString("dd/MM/yyyy"));
        // Vehicle v=new Vehicle("/km",100,1,"111",new DateTime(2020,10,17));
        // Console.WriteLine(v);

        // Owner o1=new Owner();
        // // o1.getCheckListRentedAndAvailableVehicle();
        // o1.giveVehicleForRent();
        // o1.calculateRent();
        // o1.getCheckListRentedAndAvailableVehicle();
        // o1.giveVehicleForRent();
        // o1.showAvailabilityForBookingForGivenDate();


    }
}