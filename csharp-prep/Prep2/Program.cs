using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.Write("What is the grade percentage?: ");
        string grade = Console.ReadLine();
        float gradePercentage = float.Parse(grade);

        string letter = "";
        string sign = "";
        
        if (gradePercentage >= 90)
        {
            letter = "A";
            if (gradePercentage <=93)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            if (gradePercentage >=87)
            {
                sign = "+";
            }
            else if (gradePercentage <=83)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
            if (gradePercentage >=77)
            {
                sign = "+";
            }
            else if (gradePercentage <=73)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            if (gradePercentage >=67)
            {
                sign = "+";
            }
            else if (gradePercentage <=63)
            {
                sign = "-";
            }
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage > 70)
        {
            Console.WriteLine("You have passed!");
        }
        else 
        {
            Console.WriteLine("Try it again, good luck next time!");
        }
    }
}