
//DEMO DATA
string firstName = "Josh";
int age = 34;

switch (firstName.ToLower())
{
    case "josh":
        Console.WriteLine("Welcome back, Josh");
        break;
    case "tim":
        Console.WriteLine("Hello Tim");
        break;
    default:
        Console.WriteLine("I don't think I know you");
        break;
}