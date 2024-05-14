
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



//2. Switch
Console.WriteLine("Enter day number from 1 to 7 :");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter time:");
int time = Convert.ToInt32(Console.ReadLine());

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

switch (time)
{
    case 10:
        Console.WriteLine("Its 10:00 am...");
        break;
    case 11:
        Console.WriteLine("Its 11:00 am...");
        break;
    case 12:
        Console.WriteLine("Its 12:00 am..");
        break;
    case 1:
        Console.WriteLine("Its 1:00 pm..");
        break;
    case 2:
        Console.WriteLine("Its 2:00 pm.");
        break;
    case 3:
        Console.WriteLine("Its 3:00 pm..");
        break;
    case 4:
        Console.WriteLine("Its 4:00 pm..");
        break;

    default:
        Console.WriteLine("Please enter values between 1-12");
        break;
}


//Loops
//for when we are aware about starting and ending point.


for(int i=1; i <=100; i++) 
{
    Console.WriteLine(i);
}


//reverse order
for (int i = 100; i >= 1; i--)
{
	Console.WriteLine(i);
}

//even
       //init   //test  //inc/dc
for (int i = 1; i <= 10; i++)
{
    if( i % 2 == 0)
    {
		Console.WriteLine(i);
	}
	
}

//odd
for (int i = 1; i <= 10; i++)
{
	if (i % 2 != 0)
	{
		Console.WriteLine(i);
	}

}




//while when we dont know about the exact number of iterations.
int j = 1;// initialization

while (j < 1 )//test condition
{     
    Console.WriteLine(j);
	// increment/dec
	j++;
}






//do while

int j = 1;// initialization

//test condition
do
{
    Console.WriteLine(j);
    // increment/dec
    j++;
}
while (j < 1);

//even odd program
char user;
int num;
do
{
    Console.WriteLine("Enter a number to check even / odd");

    num = Convert.ToInt32(Console.ReadLine());
    if(num %2 == 0)
    {
		Console.WriteLine("Even Number");
	}
    else if(num % 2 != 0)
    {
		Console.WriteLine("Odd Number");
	}
    else
    {
		Console.WriteLine("Invalid Number");
	}
	Console.WriteLine("Do you want to check again ? Press Y for yes and N for no");
	user = Convert.ToChar(Console.ReadLine());

} while (user== 'Y' || user == 'y');






//Arrays
int[] marks = { 47,78,52,45,98 };   //5 length 0-4 indexes

int[] numbers = new int[5];// declare and define

numbers[0] = 2;
numbers[4] = 25;
//Console.WriteLine(numbers[4]);  //C# sets default value to 0

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}
    //          i < 5
for (int i = 0; i < marks.Length; i++ )
{
    Console.WriteLine(marks[i]);
}


int[] marks = { 47, 78, 52, 78, 98 };


Array.Sort(marks);//ascending order
//Array.Reverse(marks);// reverses an array

//Console.WriteLine(Array.IndexOf(marks, 78));
//Console.WriteLine(Array.LastIndexOf(marks, 78));
Console.WriteLine(Array.BinarySearch(marks, 92));

//foreach (int mark in marks)
//{
//    Console.WriteLine(mark);
//}

//Multidimensional Arrays (Array inside an array) 2D,3D etc..;

string[,] batchRecord =
{

    {"mohsin","ahsan"},
    {"Adeel","Murtaza" },
    {"Adnan","Abdullah" },
    { "Waleed", "Bilal"}
};

//Console.WriteLine(batchRecord);

for (int i = 0; i < batchRecord.GetLength(0); i++)
{

    // Console.WriteLine("batch no : "+(i+1)+ ""); Concatenation
    //Console.WriteLine($"batch no : {i}");
    Console.WriteLine($"batch no : {i+1} ");
    for (int j = 0;  j < batchRecord.GetLength(1); j++)
    {
      
        Console.WriteLine(batchRecord[i,j]);
    }
    Console.WriteLine();
    //Console.Write("\n\n\n\n");

};


//Jagged Array (sizes of sub arrays are not fixed)2D:

string[][] skillSet =
{
    new string[4]{"Php","Laravel","Html","C#"},
    new string[3]{"Css","Jquery","Java"},
    new string[2]{"MySql","SQL Server"},
    new string[1]{"Batain banana"},
};


//float[] number = { 0.1f, 25.4f, 0.253f };

//Console.WriteLine(skillSet[2][1]);

//var decides the datatype on runtime

foreach (var skills in skillSet)
{
    foreach (var skill in skills)
    {
        
    Console.Write( skill+ " || " );

    }
    Console.WriteLine();
}


//Functions

//1.  User Defined // add(), login() etc.. 
//2.  Pre Defined // Math.Sqrt()//Console.WriteLine()

//1. User Defined

//1. No Return with no Parameters

void Greet()
{

    Console.WriteLine( "Hi Haris, Welcome to our Console Application. ");
}

//Greet();

//2. No Return with Parameters

void GreetWithName(string name)//Parameters
{
    Console.WriteLine($"Hi {name}, Welcome to our Console Application. ");
}

//GreetWithName("Mr. Abc");//Arguements
//GreetWithName("Mr. Haris Naseer");//Arguements

//3. Return with no Parameters


string GreetWithReturn()
{
   return ($"Hi User, Welcome to our Console Application. ");
}

//Console.WriteLine(GreetWithReturn());

string msg = GreetWithReturn();
Console.WriteLine(  msg );

*/
//4. Return with  Parameters
//
//string Info(string name, byte age)//Parameters
//{
//  return($"Name is : {name}. \nAge is : {age} ");
//}

//string detail=Info("Zeeshan", 45);
//Console.WriteLine( detail);

//Exception Handling (try catch)

//try
//{
//    Console.WriteLine("Enter a number from 1 to 7");
//    int day = Convert.ToInt32(Console.ReadLine());
//    switch (day)
//    {
//        case 1:
//            Console.WriteLine("Monday");
//            break;
//        case 2:
//            Console.WriteLine("Tues");
//            break;
//        case 3:
//            Console.WriteLine("Wed");
//            break;
//        case 4:
//            Console.WriteLine("Thurs");
//            break;
//        case 5:
//            Console.WriteLine("fri");
//            break;
//        case 6:
//            Console.WriteLine("sat");
//            break;
//        case 7:
//            Console.WriteLine("sun");
//            break;
//        default:
//            Console.WriteLine("invalid");
//            break;

//    }



//}
//catch (Exception e)
//{
//    Console.WriteLine("Something went wrong. Please try again..!"+ e);
//}
//finally
//{
//    Console.WriteLine("Thanks for using our application.");
//}






//Collections and types
//Generic collections
//datatype fixed
//size dynamic
// list, hashtables, dictionaries, stack, queues


//Non Generic collections
//array, ArrayList
//fixed size


//(Generics)
//List 

//using System.Collections;
//List<string> SuperCars = new List<string>();
//SuperCars.Add("Ferrari");
//SuperCars.Add("Buggati Chiron");
//SuperCars.Add("Toyota Supra");
//SuperCars.Add("Lamborghini");


//List<string> Cars = new List<string>();
//string name;
////Cars.Add("Honda Civic");
// name = Console.ReadLine();
//if(name != "ok")
//{

//Cars.Add(name);
//}
//Cars.Add("Honda BRV");
//Cars.Add("Honda Accord");
//Cars.Add("Honda HRV");
//Cars.Add("Honda Insight");

////Cars.Remove("Honda HRV");
////Cars.RemoveAt(2);
////Console.WriteLine(Cars.Contains("Ford Raptor"));
////Console.WriteLine(Cars.Contains("Toyota Grande"));

//Cars.Insert(1,"Ford Raptor");

//Cars.AddRange(SuperCars);
//Cars.RemoveRange(2, 3);


////Console.WriteLine(Cars[5]);

//foreach (string car in Cars)
//{
//    Console.WriteLine(car);
//}
//Cars.Clear();

//Queues (FIFO: First in first out)


//Queue<string> Mobiles = new Queue<string>();
//Mobiles.Enqueue("Google Pixel 7");
//Mobiles.Enqueue("Samsung S24");
//Mobiles.Enqueue("Apple 15 pro max");
//Mobiles.Enqueue("Motorolla one 5g");
//Mobiles.Enqueue("Oneplus 10r");

//Mobiles.Dequeue();
//Mobiles.Dequeue();
//Mobiles.Dequeue();


//Mobiles.Clear();
//Console.WriteLine(Mobiles[0]); Cannot apply indexing on queues


//foreach (var item in Mobiles)
//{
//    Console.WriteLine(item);
//}



//Stacks (LIFO: Last in first out)

//Stack<string> Skills = new Stack<string>();
//Skills.Push("Html");
//Skills.Push("CSS");
//Skills.Push("Javascript");
//Skills.Push("Java");
//Skills.Push("C#");
//Skills.Push("C++");
//Skills.Push("C");
//Skills.Push("PHP");

//Skills.Pop();
//Skills.Pop();
//Skills.Pop();


//Skills.Clear();
//Console.WriteLine(Mobiles[0]); Cannot apply indexing on queues


//foreach (var item in Skills)
//{
//    Console.WriteLine(item);
//}

//create a List. Take user input and add items in list.
// when user types "ok" , you have to print all the given items

using System.Collections;
//Dictionary(Generic collections)
Dictionary<string, string> Mobiles = new Dictionary<string, string>();
Mobiles.Add("Techno", "Spark 20 pro +");
Mobiles.Add("Samsung", "Galaxy S24 Ultra");
Mobiles.Add("Redmi", "Note 13");
Mobiles.Add("Apple", "15 pro");

Console.WriteLine(Mobiles["Techno"]);


Mobiles.Remove("Redmi");
foreach (var item in Mobiles)
{

    string[] test = (item.ToString()).Split(",");
    string key = test[0].Trim('[');// [
    string value = test[1].Trim(']');// ]


    //Console.WriteLine(key);
    //Console.WriteLine(value);
    Console.WriteLine($"We have mobile of brand: {key} model : {value}");
    //Console.WriteLine(test[1]);

}

//Hashtables (Non Generic collections)(no fixed datatype)
Hashtable students = new Hashtable();
students.Add(45, "Haris");
students.Add("002", "Owais");
students.Add(0.2, "Ebad");
students.Add(true, "Afzal");

students.Remove(true);
Console.WriteLine(students.GetHashCode());

Console.WriteLine(students["002"]);

foreach (DictionaryEntry item in students)
{
    Console.WriteLine(item.Key + " : " + item.Value);
}

//ArrayList (Non Generic collections)

ArrayList SuperCars = new ArrayList();
SuperCars.Add("Ferrari");
SuperCars.Add(021454);
SuperCars.Add("Toyota Supra");
SuperCars.Add("Lamborghini");

ArrayList Cars = new ArrayList();
string name;
//Cars.Add("Honda Civic");

Cars.Add("Honda BRV");
Cars.Add(false);
Cars.Add("Honda HRV");
Cars.Add("Honda Insight");

Cars.Remove("Honda HRV");
Cars.RemoveAt(2);
Console.WriteLine(Cars.Contains("Ford Raptor"));
Console.WriteLine(Cars.Contains("Toyota Grande"));

Cars.Insert(1, "Ford Raptor");

Cars.AddRange(SuperCars);
Cars.RemoveRange(2, 3);


//Console.WriteLine(Cars[5]);

foreach (string car in Cars)
{
    Console.WriteLine(car);
}
//Cars.Clear();
