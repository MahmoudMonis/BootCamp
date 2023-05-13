public class Mahmoudlap
{
    string GetName()
    {
        Console.Write("What's your name?: ");
        string? name = Console.ReadLine ();
        return name;
    }

    int GetAge()
    {
        Console.Write("How old are you?: ");

        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            Console.Write("How old are you?: ");
        }

        return age;
    }

    string GreetUser(string name, int age)
    {
        string greeting;

        if (age < 12)
        {
            greeting = $"Hello, {name}! You're young .";
        }
        else

        {
            greeting = $"Hello, {name}! Pleasure to meet you.";
        }

        return greeting;
    }

    int CalculateAgeInMonths(int age)
    {
        int ageInMonths = age * 12;
        return ageInMonths;
    }

    static void Main(string[] args)
    {
        Mahmoudlap program = new Mahmoudlap();

        string? name = program.GetName();
        int age = program.GetAge();

        string greeting = program.GreetUser(name, age);
        int ageInMonths = program.CalculateAgeInMonths(age);

        Console.WriteLine(greeting);
        Console.WriteLine($"Your {ageInMonths} old in months ");
    }
}