// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter two numbers to divide: ");
Console.Write("First number: ");
var num1 = Console.ReadLine();
Console.Write("Second number: ");
var num2 = Console.ReadLine();

decimal num1Decimal, num2Decimal;

if (!decimal.TryParse(num1, out num1Decimal))
{
    Console.WriteLine("Invalid input");
    return;
}

if (!decimal.TryParse(num2, out num2Decimal))
{
    Console.WriteLine("Invalid input");
    return;
}

Console.WriteLine($"Value 1: {num1Decimal} | Value 2: {num2Decimal}");
Console.WriteLine($"Division: {num1Decimal / num2Decimal}");

/* Console.WriteLine($"My sum: {sum(num1Decimal, num2Decimal)}"); */
/* Console.WriteLine($"My subtract: {subtract(num1Decimal, num2Decimal)}"); */
/* Console.WriteLine($"My multiply: {multiply(num1Decimal, num2Decimal)}"); */
/* Console.WriteLine($"My divide: {divide(num1Decimal, num2Decimal)}"); */
Console.WriteLine($"My sinv: {mysinv(num1Decimal)}");

decimal sum(decimal num1, decimal num2)
{
    return num1 + num2;
}

decimal subtract(decimal num1, decimal num2)
{
    return sum(num1, multiply(num2, -1));
}

decimal mysinv(decimal num)
{
    if (num < 0)
        return multiply(-1, num);

}

decimal multiply(decimal num1, decimal num2)
{
    decimal result = 0;
    for (int i = 0; i < num2; i++)
    {
        result = sum(result, num1);
    }
    return result;
}

decimal divide(decimal num1, decimal num2)
{
    decimal result = 0;
    decimal temp = num1;
    while (temp >= num2)
    {
        temp = subtract(temp, num2);
        result++;
    }

    return result;
}
