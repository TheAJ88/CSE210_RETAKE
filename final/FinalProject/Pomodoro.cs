using System;
using System.Threading;


class Pomodoro
{
    public virtual void SetPomodoro(int _courseTime)
    {
        Console.WriteLine("POOOOOOOMOOOOOOOODDDDDDDDDDOOOOOORRRRRRROOOOOOOOOO!!!");
    }
    
    public void presetPomodoro(int _pomodoroSessions)
    {
        bool _stopSession = false;
        int _pomodoroCounter = 0;
        Animation a = new Animation();

        Console.WriteLine("Welcome to your Pomodoro session!");

        while (!_stopSession)
        {
            Console.WriteLine($"\nYou've completed {_pomodoroCounter} session(s)!");
            _pomodoroCounter++;
            Console.WriteLine("INITIALIZING POMODORO!");
            a.LoadingAnimation(2);

            
            RunTimer(25, "FOCUS!!");

            Console.WriteLine("\nTime's up! Take a break.");

            
            RunTimer(5, "Break");

            
            if (_pomodoroCounter >= _pomodoroSessions)
            {
                Console.WriteLine("You've completed all planned sessions!");
                break;
            }

            Console.Write("Do you want to quit this session? Type [Y/N]: ");
            string answer = Console.ReadLine()?.Trim().ToUpper();
            if (answer == "Y") _stopSession = true;
        }
    }

    public void RunTimer(int minutes, string label)
    {
        int totalSeconds = minutes * 60;

        while (totalSeconds >= 0)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"{label} Time Left: {totalSeconds / 60:D2}:{totalSeconds % 60:D2} ");
            Thread.Sleep(1000);
            totalSeconds--;
        }
        Console.WriteLine(); 
    }

    public virtual void DiffPomodoro()
    {}
}