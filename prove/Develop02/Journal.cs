using System;
using System.Collections.Generic; 

public class Journal 
{ 
    public string date = DateTime.Now.Date.ToString("dd/MM/yyyy");

    
	List<userEntry> _entries = new List<userEntry>();
    List<userEntry> _newEntries = new List<userEntry>(); 
	
    public PromptGenerator question = new PromptGenerator();
    public void Write() 
    { 

        var answer = question.GetRandomPrompt();
        //Console.WriteLine(answer);
        string userInput = Console.ReadLine();
        userEntry entry = new userEntry();
        entry._dateTime = date;
        entry._prompt = answer;
        entry._response = userInput;
        _entries.Add(entry);
        _newEntries.Add(entry);
    } 
	public void Display() 
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._dateTime} - Prompt: {entry._prompt}");
            Console.WriteLine($"Answer: {entry._response}");
        }
    } 
	public void Load() 
    {
        Console.WriteLine("What is the filename?");
        string document = Console.ReadLine();
        if (document == "journal.csv")
        {
            string filename = "journal.csv";
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        } else
        {
            Console.WriteLine("This document doesn't exist, try again");
        } 
    }
	public void Save() 
    {
        Console.WriteLine("What is the filename?");
        string document = Console.ReadLine();
        if (document == "journal.csv")
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("journal.csv", true);
            foreach (var row in _newEntries)
            {            
                var rowString = $"{row._dateTime}, {row._prompt}, {row._response}";
                outputFile.WriteLine(rowString);
            }
            outputFile.Close();
            _newEntries = new List<userEntry>();
            Console.WriteLine("Your information is saved");
        } else
        {
            Console.WriteLine("This document doesn't exist, try again.");
        }
    }
           
}