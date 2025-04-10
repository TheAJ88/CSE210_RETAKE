using System;

class Practical_Pomodoro : Pomodoro
{
    private int _pomodoroSessions;
    public override void SetPomodoro(int _courseTime)
    {
        _pomodoroSessions = _courseTime+2;
    }
    public override void DiffPomodoro()
    {
        Console.WriteLine("Welcome to your Practical Pomodoro session! Please continue to practice your work!");
        presetPomodoro(_pomodoroSessions);
    }
}