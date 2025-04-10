using System;

class Menu
{
    private List<COURSE> _courses = new List<COURSE>();
    private string _choice;
    private int _time;
    Animation anim = new Animation();

    public Menu(List<COURSE> courses)
    {
        _courses = courses;
    }

    public void AddClass()
    {
        COURSE cs = new COURSE();
        cs.CourseInitialize();
        _courses.Add(cs);
    }
    public void NewSession()
    {
        Console.WriteLine("Welcome to your new Pomodoro session!");
        
        
        Boolean _stopEntry=false;
        while(_stopEntry!=true)
        {
            AddClass();
            Console.WriteLine("Is that all the courses you'd like to enter? Enter 'y' or 'n' ");
            string answer = Console.ReadLine();
            if(answer.ToLower()=="y") _stopEntry=true;
            else Console.WriteLine("Understood. Continuing entry.");
        }
        anim.LoadingAnimation(2);
        Console.WriteLine("Initializing Course Pomodoro menu");
        Console.WriteLine();
    }
    public List<COURSE> OldSession()
    {
        Console.WriteLine("Welcome back to your Pomodoro session!");
        SaveLoad loadSesh = new SaveLoad();
        _courses = loadSesh.LoadSession();
        return _courses;
    }
    public int PomodoroMenu()
    {
        Console.WriteLine("Pick your poison! Er, I mean your Pomodoro session! (ENTER ONLY DIGITS)");
        Console.WriteLine("1) Practical Pomodoro");
        Console.WriteLine("2) Theoretical Pomodoro");
        Console.WriteLine("3) Mixed Pomodoro");
        Console.WriteLine("4) QUICKDORO!! <3");
        Console.WriteLine("5) quit");
        int option = int.Parse(Console.ReadLine());
        return option;
    }

    public List<COURSE> GetCourseList()
    {
        return _courses;
    }

    public int GetTime()
    {
        return _time;
    }

    public string CourseMenu()
    {
        int length = _courses.Count;
        if (length == 0)
        {
            Console.WriteLine("No courses available.");
            return "quit";
        }
        for(int i=0; i<length; i++)
        {
            Console.Write($"{i+1}) ");
            _courses[i].DisplayCourse();
        }
        Console.WriteLine("What class would you like to study for?");
        Console.WriteLine("NOTE: Type '42' to exit this menu");
        int answer = int.Parse(Console.ReadLine());
        if (answer < 1 || answer > length)
        {
            Console.WriteLine("Invalid course selection.");
            return "quit"; 
        }

        if(answer==42)
        {
            return "quit";
        }
        else
        {
            for(int i=0; i<length; i++)
            {
                if(answer==i+1) _choice = _courses[i].GetCourseType();
                _time = _courses[i].GetCourseTime();
                break;
            }
        }
        return _choice;
    }
}