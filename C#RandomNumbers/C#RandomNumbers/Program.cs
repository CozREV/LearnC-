

Random random = new Random();

// Random number between 1 and 6 (7 is exclusive)
int num1 = random.Next(1, 7); 
int num2 = random.Next(1, 7);
int num3 = random.Next(1, 7);

// double num = random.NextDouble(); // Random number between 0.0 and 1.0

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

Console.ReadKey();