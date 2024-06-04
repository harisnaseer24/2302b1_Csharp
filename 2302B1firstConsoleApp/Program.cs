
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

//using System.Collections;
////Dictionary(Generic collections)
//Dictionary<string, string> Mobiles = new Dictionary<string, string>();
//Mobiles.Add("Techno", "Spark 20 pro +");
//Mobiles.Add("Samsung", "Galaxy S24 Ultra");
//Mobiles.Add("Redmi", "Note 13");
//Mobiles.Add("Apple", "15 pro");

//Console.WriteLine(Mobiles["Techno"]);


//Mobiles.Remove("Redmi");
//foreach (var item in Mobiles)
//{

//    string[] test = (item.ToString()).Split(",");
//    string key = test[0].Trim('[');// [
//    string value = test[1].Trim(']');// ]


//Console.WriteLine(key);
//Console.WriteLine(value);
//Console.WriteLine($"We have mobile of brand: {key} model : {value}");
//Console.WriteLine(test[1]);

//}

//Hashtables (Non Generic collections)(no fixed datatype)
//Hashtable students = new Hashtable();
//students.Add(45, "Haris");
//students.Add("002", "Owais");
//students.Add(0.2, "Ebad");
//students.Add(true, "Afzal");

//students.Remove(true);
//Console.WriteLine(students.GetHashCode());

//Console.WriteLine(students["002"]);

//foreach (DictionaryEntry item in students)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}

//ArrayList (Non Generic collections)

//ArrayList SuperCars = new ArrayList();
//SuperCars.Add("Ferrari");
//SuperCars.Add(021454);
//SuperCars.Add("Toyota Supra");
//SuperCars.Add("Lamborghini");

//ArrayList Cars = new ArrayList();
//string name;
////Cars.Add("Honda Civic");

//Cars.Add("Honda BRV");
//Cars.Add(false);
//Cars.Add("Honda HRV");
//Cars.Add("Honda Insight");

//Cars.Remove("Honda HRV");
//Cars.RemoveAt(2);
//Console.WriteLine(Cars.Contains("Ford Raptor"));
//Console.WriteLine(Cars.Contains("Toyota Grande"));

//Cars.Insert(1, "Ford Raptor");

//Cars.AddRange(SuperCars);
//Cars.RemoveRange(2, 3);


////Console.WriteLine(Cars[5]);

//foreach (string car in Cars)
//{
//    Console.WriteLine(car);
//}
//Cars.Clear();
// String Methods

string test = "We ,are ,le,ar,ning, C#";
//Console.WriteLine(test.ToUpper());
//Console.WriteLine(test.ToLower());
//Console.WriteLine(test.Replace("learning", "mastering"));

//string abc = test.Trim('b');
//Console.WriteLine(abc);

//string[] xyz =test.Split(",");

//Console.WriteLine(xyz[1]);

//foreach (var item in xyz)
//{ 
//    Console.WriteLine(item);
//}




// Coding Best Practices:

//Indentation (Readable by using new lines and spaces)
//less Repeatation ( functions , class and objects)
//Comments
//Meaningful Variable Names
//No errors

//Objects and Classes


//Mobiles mobile = new Mobiles();//default constructor
//mobile.calling();
//Console.WriteLine(mobile.brand);

//mobile.brand = "Samsung";
//mobile.model = "S24";
//mobile.price = 450000;
//mobile.isApproved = true;

//mobile.calling();
//Console.WriteLine(mobile.brand);

//Mobiles iphone = new Mobiles("Apple", "15 promax",250000,false);
//iphone.calling();

//Mobiles redmi = new Mobiles("Redmi");
//iphone.calling();


//public class Mobiles
//{
//    public string? brand;
//    public string? model;
//    public int? price;
//    public bool isApproved;

//    //constructor
//    public Mobiles() {
//        this.brand = "unknown";
//        this.model = "unknown";
//        this.price = 0;
//        this.isApproved = true;

//    }  public Mobiles(string brand) {
//        this.brand = brand;
//        this.model = "unknown";
//        this.price = 0;
//        this.isApproved = true;

//    }

//parameterized constructor (overloading) 
//    public Mobiles(string brand, string model, int price , bool isApprove ) {
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//        this.isApproved = isApprove;

//    }
//    public void calling()
//    {
//        //Console.WriteLine(this.model + " is calling" );
//        Console.WriteLine($"{this.model} is calling" );
//    }
//}

//OOP (Object Oriented Programming)
//Readable
//Reusable
//optimized
//organized

//Main Pillars of OOP

//1. Inheritance

//Watch Casio = new Watch("Casio 457T", "titanium black", 15000);
//Casio.ShowTime();

//Watch.count++;

//SmartWatch AppleWatch = new SmartWatch("Series 9", "black", 150000, true, "Super Amoled", "500 Mah");
//AppleWatch.ShowTime();
//Watch.count++;

//WristBand samsungBand = new WristBand("samsung band 4","black",45000, true, "S Amoled","415 MAH",false);
//samsungBand.sportsMode();
//Watch.count++;

//Console.WriteLine(Watch.count);

//Math a = new Math();
//a.Sqrt(49);
//Math.Sqrt(49);
//Math.Tan(49);
//String.Concat();


//Watch.ShowTime();


//////Parent Class / Super Class / Base Class (Grand Parent)
//public class Watch
//{
//    public static int count=0;
//    public string model;
//    public string color;
//    public int price;
//    public Watch(string model, string color, int price)
//    {
//        this.model = model;
//        this.color = color;
//        this.price = price;
//    }
//    public static void ShowTime()
//    {
//        Console.WriteLine($"Watch shows time in 24 hours format {DateTime.Now}.");

//    }
//}

////Child Class / Derived Class /sub Class /Inherited class
//public class SmartWatch : Watch  //(Parent)
//{
//    public bool canCall;
//    public string displayType;
//    public string battery;

//    public SmartWatch(string model, string color, int price, bool canCall, string display, string batt) : base(model, color, price)
//    {
//        this.canCall = canCall;
//        this.displayType = display;
//        this.battery = batt;
//    }

//    //method overriding
//    public void ShowTime()
//    {
//        Console.WriteLine($"{this.model} shows time in all format.Current date and time is:  {DateTime.Now}. It has {this.displayType} and {this.battery}.");
//    }

//    //method overloading
//    public void ShowTime(string region)
//    {
//        Console.WriteLine($"in {region} : {this.model} shows time in all format.Current date and time is:  {DateTime.Now}. It has {this.displayType} and {this.battery}.");

//    }

//}


// Child class (Grand Child)
//public class WristBand : SmartWatch
//{
//    public bool isWaterProof;
//    public WristBand(string model, string color, int price, bool canCall, string display, string batt, bool isWP) : base(model, color,price, canCall, display,batt)
//    {
//        this.isWaterProof = isWP;
//    }

//    public void sportsMode()
//    {
//        if (this.isWaterProof)
//        {
//            Console.WriteLine($"{this.model} has 99+ Sports Mode and it is Waterproof");
//        }
//        else
//        {
//            Console.WriteLine($"{this.model} has 99+ Sports Mode and it is not waterproof");
//        }

//    }
//}



//2. Polymorphism - Many forms
//methods overloading
//methods overriding

//3. Abstraction - to show only the necessary process to the user and hide irrelevant processes.
//example :  admin panel, facebook user

//4. Encapsulation - to bundle the properties and methods together in a class

// types of inheritance
//1 ) single inheritance        watch -> Smartwatch
//2 ) multiple                  watch ->smartwatch , itfeatures -> smartwatch
//3 ) multi level               watch -> Smartwatch -> wrist Band
//4 ) heirarchical                 watch -> Smartwatch,  watch -> digitalwatch
//5 ) hybrid                    any two or types existing at one place

// static and abstract


//Vehicle xyz = new Vehicle();
//xyz.speed = 100;
//xyz.regNo = "AAZ-384";
//xyz.Run();

//Car markX = new Car(220, "AD-4586", 5, "Toyota Mark X 2008");
//markX.Run();
//markX.stop("Drift");// 2nd function with string parameter
//markX.stop();// 1st function with no parameters

//Car corolla = new Car(180, "HD-7778", 5, "Toyota Corolla");
//Car fdf = new Car(180, "HD-7778", 5, "Toyota Corolla");
//Car df = new Car(180, "HD-7778", 5, "Toyota Corolla");
//Car gdf = new Car(180, "HD-7778", 5, "Toyota Corolla");
//Car d = new Car(180, "HD-7778", 5, "Toyota Corolla");
//Car s = new Car(180, "HD-7778", 5, "Toyota Corolla");
//Car ds = new Car(180, "HD-7778", 5, "Toyota Corolla");

//Math abc = new Math();
//abc.Sqrt(49);

//Static functions
//Math.Sqrt(49);
//Math.Sin(49);
//Math.Log(49);

//Console.WriteLine(Car.carCount);

//Car.beginRace();

//abstract public class Vehicle
//{
//    public int speed;
//    public string regNo;

//    public virtual void Run()
//    {
//        Console.WriteLine($"The Vehicle started running at {this.speed} Km/h");
//    }

//}

//public class Car : Vehicle
//{
//    public static int carCount = 0;
//    public int wheels;
//    public string model;

//    public Car(int speed, string no, int wheels, string model)
//    {
//        this.speed = speed;
//        this.regNo = no;
//        this.wheels = wheels;
//        this.model = model;
//        carCount++;

//    }

//    public static void beginRace(){
//        Console.WriteLine("Boom! the race has been started. May the best win..!");
//    }
//    //Override
//    public override void Run()
//    {
//        Console.WriteLine($"The {this.model} having reg number {this.regNo} started running at {this.speed} KM/HR");
//    }

//    // self method
//    public void stop()
//    {
//        Console.WriteLine($"The {this.model} has stopped.");
//    }

//    public void stop(string stunt)
//    {
//        Console.WriteLine($"The {this.model} has stopped with {stunt}.");
//    }

//}


//Interfaces

//FrontEndDeveloper muslim = new FrontEndDeveloper();
//muslim.AnimatedDesign("Muslim");

//FullStackDeveloper Haris = new FullStackDeveloper();
//Haris.SimpleCRUD();

//interface FrontEndDev
//{
//  public  void SimpleDesign();
//  public void AnimatedDesign(string name);

//}

//interface BackEndDev
//{
//  public  void SimpleCRUD();
//    public void Authentication();
//    public void ComplexAPIs();
//}

//public class FrontEndDeveloper: FrontEndDev
//{
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you basic responsive design with html,CSS and Js.");
//    }
//    public void AnimatedDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you an animated responsive design with react,Jquery, Next.js");
//    }

//}
////Multiple Inheritance

//public class FullStackDeveloper: FrontEndDev, BackEndDev
//{
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you basic responsive design with html,CSS and Js.");
//    }
//    public void AnimatedDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you an animated responsive design with react,Jquery, Next.js");
//    }
//    public void SimpleCRUD()
//    {
//        Console.WriteLine("We will provide you basic CRUD  with any stack you want.");
//    }
//    public void Authentication()
//    {
//        Console.WriteLine("We will provide you authentication and authorization");
//    }
//    public void ComplexAPIs()
//    {
//        Console.WriteLine("We will provide you Complex APIs.");
//    }


//}

//Access Modifiers

//1. public  || can be access anywhere in the program by any one.
//2. private || can be access owner class only . 
//3. protected ||  can be access owner and child class only .


//Products neckBand = new Products(4565, "Lenovo neckband", 1500);
//neckBand.Name = "Lenove Neckband 2";

//Console.WriteLine(neckBand.Name);
////Console.WriteLine(neckBand.ProId);

//neckBand.SetPrice(800);
//neckBand.ShowPrice();
//Household Bowls = new Household(45, "Bowl Set", 999, "Household");

//Bowls.ShowProduct();


//public class Products
//{
//    private int ProId;
//    public string? Name;
//    protected int Price;
//    public Products(int id, string name, int price)
//    {
//        this.ProId = id;
//        this.Name = name;
//        this.Price = price;

//    }
//    public void SetPrice(int price)
//    {
//        this.Price = price;
//    }
//    public void ShowPrice()
//    {
//        Console.WriteLine(this.Price); 
//    }
//    public void ShowId()
//    {
//        Console.WriteLine(this.ProId); 
//    }

//}


//public class Household : Products
//{
//    public string category;
//    public Household(int id, string name, int price, string cat): base(id, name, price)
//    {
//        this.category = cat;
//    }

//    public void ShowProduct()
//    {
//        Console.WriteLine(this.Name);
//        Console.WriteLine(this.Price);
//        Console.WriteLine(this.category);
//        this.ShowId();
//    }
//}


// DELEGATEs
//Normal Delegate

//MyMaths.Calculate eval=new MyMaths.Calculate(MyMaths.Mul);

//eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);eval(45, 10);


//Multicast Delegate

//MyMaths.Calculate Evaluate;
//Evaluate = MyMaths.Add;

//Evaluate(4, 4);


//Evaluate = MyMaths.Sub;

//Evaluate(4, 4);

//Evaluate = MyMaths.Mul;

//Evaluate(4, 4);

////Evaluate = MyMaths.Div;

////Evaluate(4, 4);

//MyMaths.Div(4, 4);

//public class MyMaths
//{
//    public delegate void Calculate(double num1, double num2); //

//    public static void Add(double num1, double num2)
//    {
//        Console.WriteLine(num1+num2);
//    }

//    public static void Sub(double num1, double num2)
//    {
//        Console.WriteLine(num1-num2);
//    } 

//    public static void Mul(double num1, double num2)
//    {
//        Console.WriteLine(num1*num2);
//    }

//    public static double Div(double num1, double num2)
//    {
//        return(num1/num2);
//    }

//}


//Shopping.GetItem shop;
//shop = Shopping.GetEatables;
//shop("Choco powder", 250, "good and rich texture");

//public class Shopping
//{
//    public delegate void GetItem(string item, int price, string description);

//    public static void GetEatables(string item, int price, string description)
//    {
//        Console.WriteLine("we have bought {0} in Rs. {1}. It has {2}", item, price, description);
//    }


//}

//Unary operator  a++;

//Binary operator  a + b;

//Ternary operator (condition) ? "hi": "bye";

var greet = (10 < 9)  ? "hi" : "bye"; Console.WriteLine(greet);