

// logical operators = Can be used to check if more than 1 condition is true/false

// && = AND
// || = OR


Console.WriteLine("Whats the temperature outside: (C)");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 15 && temp <= 25)
{
    Console.WriteLine("Its warm outside");
}
else if (temp <= -10 || temp >= 30)
{
    Console.WriteLine("Staying inside is recommended");
}

Console.ReadKey();
