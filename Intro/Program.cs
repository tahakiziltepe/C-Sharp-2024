// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message = "Loans";
int term = 0;
double amount =  100000.5;
bool isAuth = true;

Console.WriteLine(message);


// Condition
if (isAuth) // same as (isAuth == true) 
{
    Console.WriteLine("Welcome.");
}
else
{
    Console.WriteLine("Please login.");
}

// Arrays
string[] loans = { "Loan 1", "Loan 2", "Loan 3", "Loan 4", "Loan 5", "Loan 6" };

//string[] loans2 = new string[6]; // array that has space for 6 strings
//loans2[0] = "Loan 1";

// Loop - For
for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti.");


