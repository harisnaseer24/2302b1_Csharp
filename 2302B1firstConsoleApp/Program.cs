
/*
Console.Write("Hello, Haris");// to print on same line

Console.WriteLine("Hello, World");// to print on next line

//Datatypes

byte age = 45;
short num = 32000;

long num2 = 47745454545l;


float percentage = 80.787f;
double pi = 3.142222432323;
decimal speedofLight = 3.8000000000000000000000000m;



char favCharacter = '@';
string name = "Haris";



Console.WriteLine("What is your Name..?");
string name = Console.ReadLine();//string "8"

Console.WriteLine("Welcome "+ name + " , to our console.");

//Operators
int num1 = 6;
int num2 = 2;

// Arithmetic operators
Console.WriteLine(num1 + num2);
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 * num2);
Console.WriteLine(num1 / num2);
Console.WriteLine(num1 % num2);// remainder

//Assignment Operators
int number = 3;
number += 2; // number = number + 2
Console.WriteLine(number);

number -= 2; // number = number - 2
Console.WriteLine(number);

number *= 2; // number = number * 2
Console.WriteLine(number);

number /= 2; // number = number / 2
Console.WriteLine(number);

//Comparison Operators( true / false)

int num1 = 6;
int num2 = 2;

Console.WriteLine(num1 == num2);//F
Console.WriteLine(num1 != num2);//T
Console.WriteLine(num1 > num2);// 6 > 2 //T

Console.WriteLine(num2 < num1); // 2 < 6 //t

Console.WriteLine(num1 <= num2);  //f

Console.WriteLine(num2 >= num1); // 2 >= 6 // false

int i = 5;
//Post Increment/Decrement (use first then increment/decrement)
//i+1;
//Console.WriteLine(i++);
//Console.WriteLine(i);
//Console.WriteLine(i--);//i-1;
//Console.WriteLine(i);

//Pre  Increment/Decrement (increment/decrement first then use)
Console.WriteLine(++i);

Console.WriteLine(--i);

//Logical Operators
//1. AND

Console.WriteLine(65 >= 60 && 9 == 8);//true false = False
Console.WriteLine(65 <= 60 && 8 == 8);// False true = False
Console.WriteLine(65 != 60 && 8 <= 8);// t t = true

//2. OR
Console.WriteLine(65 <= 60 || 8 == 8);// f t = true
Console.WriteLine(655 <= 650 || 788 != 788);// f f = false 

//3. Not

Console.WriteLine(655 <= 650 || !(788 != 788));//f t = True



//Conditional Statements
//1. if else

Console.WriteLine("Enter your age :");
int age = Convert.ToInt32(Console.ReadLine());//string

//int age = Int32.Parse(Console.ReadLine());

if (age >18 && age <= 90)
{
    Console.WriteLine("You can vote.");
}else if (age == 18)
{
    Console.WriteLine("Do you have CNIC?");
    string ans = Console.ReadLine();
    ans = ans.ToLower();//yes

    if(ans == "yes")
    {
        Console.WriteLine("You can vote. ");
    }
    else if (ans == "no")
    {
        Console.WriteLine("You can't vote. Get Cnic first.");
    }
    else 
    {
        Console.WriteLine("Invalid Answer. Please answer yes or no?");
    }
}

else if (age <= 0)
{
    Console.WriteLine("Invalid Age.");
}

else
{
    Console.WriteLine("You can't vote.");
}
*/


//2. Switch

Console.WriteLine("Enter day number from 1 to 7 :");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday.");
        break;
    case 2:
        Console.WriteLine("Tuesday.");
        break;
    case 3:
        Console.WriteLine("Wednesday.");
        break;
    case 4:
        Console.WriteLine("Thursday.");
        break;
    case 5:
        Console.WriteLine("Friday.");
        break;
    case 6:
        Console.WriteLine("Saturday.");
        break;
    case 7:
        Console.WriteLine("Sunday.");
        break;

    default:
        Console.WriteLine("Please give number from 1 to 7.");
        break;
}
