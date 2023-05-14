using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        string a = "Who was the most interesting person I interacted with today?: ";
        string b = "What was the best part of my day?: ";
        string c = "How did I see the hand of the Lord in my life today?: ";
        string d = "What was the strongest emotion I felt today?: ";
        string e = "If I had one thing I could do over today, what would it be?: ";

        int option;
        string answer;
        string filename = "journal.csv";

        Console.WriteLine("Welcome to the Journal Program!");
        do {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: 
                    Random rnd = new Random();
                    int question = rnd.Next(1, 6);
            
                    if (question == 1) {
                        Console.Write(a);
                    } else if (question == 2) {
                        Console.Write(b);
                    } else if (question == 3) {
                        Console.Write(c);
                    } else if (question == 4) {
                        Console.Write(d);
                    } else if (question == 5) {
                        Console.Write(e);
                    } answer = Console.ReadLine();
                    
                    
                    using (StreamWriter outputFile = new StreamWriter (filename, append: true))
                    {
                        if (question == 1) {
                            outputFile.WriteLine($"{dateText},{a},{answer}");
                        } else if (question == 2) {
                            outputFile.WriteLine($"{dateText},{b},{answer}");
                        } else if (question == 3) {
                            outputFile.WriteLine($"{dateText},{c},{answer}");
                        } else if (question == 4) {
                            outputFile.WriteLine($"{dateText},{d},{answer}");
                        } else if (question == 5) {
                            outputFile.WriteLine($"{dateText},{e},{answer}");
                        }
                    }
                    break;
                case 2:
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    break;
                
                case 4:
                    using (StreamWriter ouputFile = new StreamWriter (filename, append: true))
                    break;

            case 5: Console.WriteLine("Good bye");
                break;

            default: Console.WriteLine("Incorrect number");
                break;
            }

        } while (option != 5);
        
    }   
}