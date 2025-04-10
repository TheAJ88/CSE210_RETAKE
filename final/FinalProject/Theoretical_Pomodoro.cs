using System;

class Theoretical_Pomodoro : Pomodoro
{
    private int _pomodoroSessions;
    public override void SetPomodoro(int _courseTime)
    {
        _pomodoroSessions = _courseTime*2+1;
    }
    public override void DiffPomodoro()
    {
        Console.WriteLine("Welcome to your Practical Pomodoro session! Please continue to study your material and ensure your last session is maintained for review!");
        presetPomodoro(_pomodoroSessions);
    }
}