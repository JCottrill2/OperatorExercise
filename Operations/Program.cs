using Operations;

int num1 = 15;
int num2 = 5;

Console.WriteLine($"Add: {num1+num2}");
Console.WriteLine($"Subtract: {num1+num2}");
Console.WriteLine($"Multiply: {num1+num2}");

int a = 17;
int b = 4;

int quotient = a / b;
int remainder = a % b;

if (a == 17 && b == 4)
{
Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder} ");
}




Console.WriteLine("Please put in the radius of circle");
var userInput = double.Parse(Console.ReadLine());

double area = Methods.AreaofCircle(userInput);

Console.WriteLine(area);