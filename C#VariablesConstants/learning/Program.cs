using System.Reflection.Metadata;

int x; //declaration
x = 123; //initialization

int y = 321; //declaration + initialization

int z = x + y;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);



int age = 22; //int stores only whole integer values
double height = 1.79; //double can store decimal values
bool alive = true; //bool can store true or false values
char symbol = '#'; //char can store a single character, enclosed in single quotes
String name = "REV"; //string can store a sequence of characters, enclosed in double quotes

Console.WriteLine("Hello " + name);
Console.WriteLine("Your age is " + age);
Console.WriteLine("Your height is " + height + "m");
Console.WriteLine("Are you alive? " + alive);
Console.WriteLine("Your symbol is: " + symbol);



String userName = symbol + name; //concatenating the char symbol and the string name to create a new string userName

Console.WriteLine(userName);



// constants = immutable values which are known at compile time and do not change for the life of the program

const double pi = 3.14159; //const keyword is used to declare a constant variable, which cannot be changed after it is initialized

// pi = 420; = this line would cause a compile-time error because pi is a constant and cannot be assigned a new value



Console.ReadKey(); //waits for the user to press a key before closing the console window
