using System;

class Mixed_Pomodoro : Pomodoro
{
    private int _pomodoroSessions;
    public override void SetPomodoro(int _courseTime)
    {
        _pomodoroSessions = _courseTime*2+2;
    }
    public override void DiffPomodoro()
    {
        Console.WriteLine("Welcome to your Mixed Pomodoro session! Please ensure to finish with one session each to review your practical and theoretical!");
        presetPomodoro(_pomodoroSessions);
    }
}