

// while loops = repeats some code while some condition remains true


//while (1 == 1)
//{
//    Console.Write("HELP IM STUCK IN AN INFINITE LOOP!");
//}

String name = "";

while (name == "")
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
}

Console.WriteLine("Hello " + name);


Console.ReadKey();
