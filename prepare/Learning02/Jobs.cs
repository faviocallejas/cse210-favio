using System;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
      Console.WriteLine($"{_jobTitle} - {_company} \n{_startYear}-{_endYear}");
    }
}