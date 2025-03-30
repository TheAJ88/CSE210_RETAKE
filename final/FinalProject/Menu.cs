using System;

class Menu
{
    private List<COURSE> classes = new List<COURSE>();
    private string _name;
    public void NewSession()
    {
        Console.WriteLine("Welcome to your new Pomodoro session!");
    }
    public void OldSession()
    {
        Console.WriteLine("Welcome back to your Pomodoro sesion!");
    }
    public void PomodoroMenu()
    {
        Console.WriteLine("Pick your poison! Er, I mean your Pomodoro session!");
        Console.WriteLine("1) Practical Pomodoro");
        Console.WriteLine("2) Theoretical Pomodoro");
        Console.WriteLine("3) Mixed Pomodoro");
        Console.WriteLine("4) QUICKDORO!! <3");
    }
}