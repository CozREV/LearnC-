

/* Type Casting = Converting a value to a different data type
 *                Useful when we accept user input (string)
 *                Different data types can do different things
*/



// Turns a to b, but it will round the number to the nearest integer
double a = 3.14; // "double a" is a number with a decimal point
int b = Convert.ToInt32(a); // "int b" rounds "double a" to the nearest integer with Convert.ToInt32()

// Turns c to d, but it will keep the decimal point and add 0.1 to it
int c = 123; // "int c" is a whole number without a decimal point
double d = Convert.ToDouble(c) + 0.1; // "double d" converts "int c" to a number with a decimal point and adds 0.1 to it

// Turns e to f, but it will convert the number to a string
int e = 321; // "int e" is a whole number without a decimal point
String f = Convert.ToString(e); // "String f" converts "int e" to a sequence of characters (text) that represents the number

// Turns g to h, but it will convert the string to a single character
String g = "#"; // "String g" is a sequence of characters (text) that represents the symbol "#"
char h = Convert.ToChar(g); // "char h" converts "String g" to a single character that represents the symbol "#"

// Turns i to j, but it will convert the string to a boolean value
String i = "false"; // "String i" is a sequence of characters (text) that represents the word "false"
bool j = Convert.ToBoolean(i); // "bool j" converts "String i" to a boolean value that represents the concept of "false" (not true)


Console.WriteLine(b.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(h.GetType());
Console.WriteLine(j.GetType());


Console.ReadKey();