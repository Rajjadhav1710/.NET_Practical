using System;

class DoTheMath {
    static void Main(){
        Console.WriteLine("\nGive Me A String To Find Length:");
        string? userString=Console.ReadLine();

        Console.WriteLine("\nLength Of The String:"+userString?.Length);

        Console.WriteLine("\nGive Me A Sentence To Identify It's Type:");
        string userSentence=""+Console.ReadLine();

        if(userSentence[userSentence.Length-1]=='.'){
            Console.WriteLine("\nDeclarative Sentence.");
        }else if(userSentence[userSentence.Length-1]=='?'){
            Console.WriteLine("\nInterrogatory Sentence.");
        }else if(userSentence[userSentence.Length-1]=='!'){
            Console.WriteLine("\nExclamatory Sentence.");
        }else{
            Console.WriteLine("\nNot A Sentence.");
        }

        Console.WriteLine("\nGive Me Your Full Name:");
        string fullName=""+Console.ReadLine();

        string[] splittedName=fullName.Split(' ');
        
        if(splittedName.Length==1)
            Console.WriteLine("\nYour Name: "+splittedName[0]);
        else
            Console.WriteLine("\nYour Name: "+splittedName[1]+", "+splittedName[0]);
    }
}