

Console.WriteLine("What is your name?");
String name = Console.ReadLine();

//             BroCode
Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());


//             My own attempt
// Console.WriteLine("What is your age?"); 
// String age = Console.ReadLine();
// int yourAge = Convert.ToInt32(age);


Console.WriteLine("Hello " + name);
Console.WriteLine("You are " + age + " years old");

Console.ReadKey();