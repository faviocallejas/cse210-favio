using System.
Collections.Generic; 
public class userEntry 
{ 
	public string _dateTime; 
	public string _prompt; 
	public string _response; 
	
    public void Display() 
	{ 
		Console.WriteLine(_dateTime); 
		Console.WriteLine(_prompt); 
		Console.WriteLine(_response); 
	} 
} 
