


String fullName = "Kristian";

// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();
// Console.WriteLine(fullName);

String phoneNumber = "123-456-7890";

//  phoneNumber = phoneNumber.Replace("-", "/");
//  phoneNumber = phoneNumber.Replace("-", "");
//  Console.WriteLine(phoneNumber);

//  String userName = fullName.Insert(0, "#");
//  Console.WriteLine(userName);

// Console.WriteLine(fullName.Length);

String firstHalfName = fullName.Substring(0, 4);
String secondHalfName = fullName.Substring(4, 4);

Console.WriteLine(firstHalfName);
Console.WriteLine(secondHalfName);


Console.ReadKey();