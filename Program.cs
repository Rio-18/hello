//namespace HelloWorld
//{
//class program
//{


//public static void Main(string[] args)
//{
//int num = 7;

//double num1 = 10.9;
//bool val = false;
//char singleCharacter = 'r';
//string name = "BridgeLabz";
//Console.WriteLine("Hii,Hello how are you?");
//Console.WriteLine("This is an Integer value = " + num);
//Console.WriteLine("This is an double value = " + num1);
//Console.WriteLine("This is an boolean value = " + val);
//Console.WriteLine("This is an Charcter = " + singleCharacter);
//Console.WriteLine("This is an string value = " + name);

//string nameofperson = Console.ReadLine();

//Console.WriteLine("This is the " + nameofperson);
//Console.WriteLine("The name is {0} {1} {2} {3}" ,nameofperson,num,num1,val);

/*Console.WriteLine("Print the username");
string username = Console.ReadLine();

int val = username.Length;

Console.WriteLine("The number of characters is = " + val);

if(username.Length>3  && username.Length<5)
{
    Console.WriteLine("Hello " + username + " , How are you? ");
    Console.WriteLine("Hello {0},How are you?", username);

}
else if(username.Length<5)
{
    Console.WriteLine("The name is not having more than 5 characters");
}
else
{
    Console.WriteLine("This name is having min 3 characters");
}

Console.WriteLine("Print the username");
string username = Console.ReadLine();

int val = username.Length;

Console.WriteLine("The number of characters is = " + val);

if(username.Length>3)
{
    Console.WriteLine("Hello " + username + " , How are you? ");
    Console.WriteLine("Hello {0},How are you?", username);

}
else
{
    Console.WriteLine("The name is not having max 3 characters");
}*/

/* Console.WriteLine("Enter the first number: ");
 int num1 = Convert.ToInt32(Console.ReadLine());




 Console.WriteLine("Enter the second number:");
 int num2 = Convert.ToInt32(Console.ReadLine());

 int num3 = num1 + num2;
 Console.WriteLine("The addition of two numbers = " + num3);*/

int year;
Console.Write("Enter an year :  ");
year = Convert.ToInt32(Console.ReadLine());

if ((year % 400) == 0)
    Console.WriteLine("{0} is a leap year.", year);
else if ((year % 100) == 0)
    Console.WriteLine("{0} is not a leap year.", year);
else if ((year % 4) == 0)
    Console.WriteLine("{0} is a leap year.", year);
else
    Console.WriteLine("{0} is not a leap year.", year);







/*}
}   

}*/





























