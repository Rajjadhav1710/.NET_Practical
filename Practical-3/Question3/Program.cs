[Flags]//what is this?

public enum Days

{

    None = 0b_0000_0000, // 0

    Monday = 0b_0000_0001, // 1

    Tuesday = 0b_0000_0010, // 2

    Wednesday = 0b_0000_0100, // 4

    Thursday = 0b_0000_1000, // 8

    Friday = 0b_0001_0000, // 16

    Saturday = 0b_0010_0000, // 32

    Sunday = 0b_0100_0000, // 64

    Weekend = Saturday | Sunday

}

public class FlagsEnumExample

{

    public static void Main()

    {

        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;

        Console.WriteLine("\n"+meetingDays);

        // Output:

        // Monday, Wednesday, Friday

        Days workingFromHomeDays = Days.Thursday | Days.Friday;

        Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

        // Output:

        // Join a meeting by phone on Friday

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;

        Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

        // Output:

        // Is there a meeting on Tuesday: False

        var a = (Days)37;//change 37 to see output change

        Console.WriteLine(a);
        Console.WriteLine();
        // Output:

        // Monday, Wednesday, Saturday

    }

}