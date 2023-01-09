// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
// This is a comment
Console.WriteLine("I am acitvie");

//example for string to number
Console.WriteLine("Please enter a radius");
//sring result = Console.ReadLine();
//double num = double.Parse(result); -- this lines are combined into one line below 
double num = double.Parse(Console.ReadLine());
double area = num * num * Math.PI;
Console.WriteLine(area);
//NULL example 
//NULL set a variable value as a placeholder
string myName = null;
Console.WriteLine(myName);
string friend = "Josh Carolin";

if (friend == "Family")
{
    myName = "Justin Jones";
}
else if (friend == "Josh Carolin")
{
    myName = "Jeo";
}
Console.WriteLine(myName);
// exercise 1
{
    Console.WriteLine("Lunch was not too long!  What do you think?  ");
    string practice_answer = Console.ReadLine();
    Console.WriteLine(practice_answer);
}
// exercise 2
{
    Console.WriteLine("Please enter a number:  ");
        double exercisenum_two = double.Parse(Console.ReadLine());
    Console.WriteLine(exercisenum_two); 
}
// exercise 3
{
    Console.WriteLine("Please enter a number:  ");
        double exercisenum_three = double.Parse(Console.ReadLine());
    double exercisenum_threehalf = (exercisenum_three + .5);
    Console.WriteLine(exercisenum_threehalf);
}
// exercise 4
{
    Console.WriteLine("Please enter a number:  ");
    double exercisenum_four = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter another number:  ");
    double exercisenum_fourplus = double.Parse(Console.ReadLine());
    double added_answer = (exercisenum_four + exercisenum_fourplus);
    Console.WriteLine("The numbers added together are: "); Console.WriteLine (added_answer);
  }
// exercise 5
{
    Console.WriteLine("Please enter a number:  ");
    double exercisenum_five = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter another number:  ");
    double exercisenum_fiveplus = double.Parse(Console.ReadLine());
    double multi_answer = (exercisenum_five * exercisenum_fiveplus);
    Console.WriteLine("The numbers multiplied together are: "); Console.WriteLine(multi_answer);
}
