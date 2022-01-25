using System;

// ExploreIf();
namespace MyApplication
{
    class WorkingWithBranchesAndLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------ Explore If..Else -------\n");
            ExploreIf();
            Console.WriteLine("\n------ Explore Loops -------\n");
            ExploreLoops();
            Console.WriteLine("\n------ find the sum of all integers 1 through 20 that are divisible by 3 -------\n");
            findSum(1,20);
        }

        static void ExploreIf()
        {
            // Make decisions using the if statement
            Console.WriteLine("\n*If Statement With One Condition\n");
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            Console.WriteLine("\n*If Statement With Two Conditions Combined Using AND\n");
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            // The == symbol tests for equality

            Console.WriteLine("\n*If Statement With Two Conditions Combined Using OR\n");
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        static void ExploreLoops()
        {
            Console.WriteLine("\n*While Loop\n");
            // Use loops to repeat operations
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            // The while loop tests the condition before executing the code following the while.

            Console.WriteLine("\n*Do...While Loop\n");
            // The do ... while loop executes the code first, and then checks the condition.
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);

            Console.WriteLine("\n*For Loop\n");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            Console.WriteLine("\n*Matrix Using Nested Loops\n");
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        static void findSum(int i, int j)
        {
            int sum = 0;
            for (int val = i; val <= j; val++)
            {
                if (val % 3 == 0)
                    sum += val;
            }

            Console.WriteLine(sum);
        }

    }
}


// findSum(1, 20);

