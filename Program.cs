using System.Drawing;

internal class Program
{
    private static void Main(string[] args){ //starting point or entry point of the program
        // Console.Write("Hello");
        // Console.WriteLine("Hello, World!");

        // SINGLE LINE
        
        /*
            MULTI LINE
        */


        // int firstNum = 2;
        // int secondNum = 4;

        // int sum = firstNum+secondNum;

        // Console.WriteLine(firstNum+secondNum);

        // string name = "LeBron";
        // Console.WriteLine(name);

        // Console.WriteLine($"Hello my name is {name} and I got {sum} bitches");


        // Console.WriteLine("Enter your age");
        // int age = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine(age);

        float marks = 45.45f;
        Console.WriteLine(marks);

        double marks2 = 44.44444d;
        Console.WriteLine(marks2);

        decimal marks3 = 44.44M;
        Console.WriteLine(marks3);

        string name = "LeBron";
        Console.WriteLine(name);

        char grade = 'A';
        Console.WriteLine(grade);

        bool getMoney = true;
        Console.WriteLine($"Get Money? = {getMoney}");

        string[] colors = ["red", "blue", "green"];

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }        


        List<string> fruits = new List<string> {"apple", "orange" , "mango"};
        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<string,int> people= new Dictionary<string, int>
        {
            ["Flagg"] = 18,
            ["LeBron"] = 42
        };

        foreach(var(key,value) in people)
        {
            Console.WriteLine($"{key} is {value} years old");
        }

        Console.Write("What is your name? = ");
        string? readName = Console.ReadLine();

        Console.Write("What is your age? = ");
        int readAge = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("What is your Phone Number? = ");
        long readPh = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"Hello {readName} who is {readAge} years old and phone number is {readPh}");

    }

}

