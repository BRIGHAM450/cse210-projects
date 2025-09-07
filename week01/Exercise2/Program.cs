using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent?: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput); // Convierte el string a int

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // adding + or -
        string sign = "";

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Handle the A+ grades
        if (grade >= 93)
        {
            sign = "";
        }

        // Handle the F+ and F- grades
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }

    }
}
