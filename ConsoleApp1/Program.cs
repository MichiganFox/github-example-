// See https://aka.ms/new-console-template for more information
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
