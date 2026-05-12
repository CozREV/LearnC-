


// if statements = a basic form of decision making.


//Console.WriteLine("Please enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine()); 

//if (age >= 18)
//{
//    Console.WriteLine("You are signed up");
//}
//else if (age < 0){
//    Console.WriteLine("You haven't been born yet");
//}
//else
//{
//    Console.WriteLine("You must be 18+ to sign up");
//}

Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine("You have to enter your name");
//}
//else
//{
//    Console.WriteLine("Welcome " + name);
//}

if (name != "")
{
    Console.WriteLine("Welcome " + name);
}
else
{
    Console.WriteLine("You haven't entered your name");
}




Console.ReadKey();