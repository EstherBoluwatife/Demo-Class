Console.Title = "My C3 Calculator";
Console.ForegroundColor = ConsoleColor.Green;
static void calculator()
{
    try
    {
        //3 int and 1 string
        int num1;
        int num2;
        int num3;
        int result;
        string operation; //Addition, Subtraction, Multiplication, Division

        Console.Write("Enter the firt number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the operation(+, -, *, /): ");
        operation = Console.ReadLine();

        switch (operation)
        {
            case ("+"):
                result = num1 + num2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n");
                Console.WriteLine("The answer is " + result);
                break;

            case ("-"):
                result = num1 - num2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n");
                Console.WriteLine("The answer is " + result);
                break;

            case ("/"):
                result = num1 / num2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n");
                Console.WriteLine("The answer is " + result);
                break;

            case ("*"):
                result = num1 * num2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n");
                Console.WriteLine("The answer is " + result);
                break;

            default:
                Console.WriteLine("Invalid operation");
                break;

        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid format");
    }
}
//calculator();

static void testingForeachLoop()
{
    String[] cars = { "bmw", "toyota", "volvo" };
    foreach (String car in cars)
    {
        Console.WriteLine(car);

    }
}
testingForeachLoop();

static void newFunction()
{
    string name = "dola";
    Console.WriteLine($"My name is {name}");
}
newFunction();

static void conditionalOperator()
{
    int age = 30;
    if (age < 30) ;
    Console.WriteLine("Age can register");
}

//public - can be access by anyone anywhere.
//private - can only be accessed from with in the class it is a part of.
//protected - can only be accessed from with in the class or any object that inherits off of the class.

//Multidimentional Array
string[,,] fruits = { { { "banana", "apple", "mango" }, { "kiwi", "strawberry", "prunes" }, { "oranges", "watermelon", "pineapples" } } };
Console.WriteLine(fruits[0, 1, 0]);



Console.ReadKey();