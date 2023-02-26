
//DEMO DATA
// firstName = "Josh";
//int age = 34;

Console.Write("What is your first name?: ");
string? firstName = Console.ReadLine();

Console.Write("What is your age?: ");
string? ageStr = Console.ReadLine();

int age = int.Parse(ageStr);

switch (firstName.ToLower())
{
    case "josh":
        Console.WriteLine("Welcome back, Josh");
        break;
    case "tim" or "tom":
        Console.WriteLine("Hello Sir");
        break;
    default:
        Console.WriteLine("I don't think I know you");
        break;
}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job");
        break;
    case >= 66:
        Console.WriteLine("Hopefully you are retired or retiring soon");
        break;
    default:
        Console.WriteLine("Age was not in an expected range");
        break;
}