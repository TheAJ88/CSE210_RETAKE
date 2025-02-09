using System;

public class Entry
{
    public string _prompt;
    public string _entryText;
    public string _date;
    
    public Entry()
    {
        PromptGenerator p = new PromptGenerator();
        _prompt = p.Prompt();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    
    public void journalEntry()
    {
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"[{_date}] Prompt : {_prompt}");
        Console.WriteLine($"> {_entryText}");
    }
}