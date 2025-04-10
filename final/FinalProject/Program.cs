using System;

class Program
{

    static public void MAIN_MENU(List<COURSE> courses)
    {
        Animation anim = new Animation();
        List<COURSE> _courses = courses;
        Menu _menu = new Menu(_courses);
        Console.WriteLine(@"Please choose between the menu options:
1> COURSE menu
2> POMODORO menu
3> SAVE SESSION
4> QUIT");
            int menuChoice = int.Parse(Console.ReadLine());
            switch(menuChoice)
            {
                case 1:
                string pomChoice = _menu.CourseMenu();
                if(pomChoice=="quit")
                {
                    break;
                }
                else
                {
                    if(pomChoice=="theoretical")
                    {
                        Theoretical_Pomodoro tp = new Theoretical_Pomodoro();
                        tp.SetPomodoro(_menu.GetTime());
                        tp.DiffPomodoro();
                    }
                    if(pomChoice=="practical")
                    {
                        Practical_Pomodoro prp = new Practical_Pomodoro();
                        prp.SetPomodoro(_menu.GetTime());
                        prp.DiffPomodoro();
                    }
                    if(pomChoice=="mixed")
                    {
                        Mixed_Pomodoro mp = new Mixed_Pomodoro();
                        mp.SetPomodoro(_menu.GetTime());
                        mp.DiffPomodoro();
                    }
                }
                break;

                case 2:
                int option = _menu.PomodoroMenu();
                switch(option)
                {
                    case 1:
                    Practical_Pomodoro prp = new Practical_Pomodoro();
                    prp.SetPomodoro(1);
                    break;
                    case 2:
                    Theoretical_Pomodoro tp = new Theoretical_Pomodoro();
                    tp.SetPomodoro(1);
                    break;
                    case 3:
                    Mixed_Pomodoro mp = new Mixed_Pomodoro();
                    mp.SetPomodoro(1);
                    break;
                    case 4:
                    Pomodoro pom = new Pomodoro();
                    pom.presetPomodoro(1);
                    break;
                    case 5:
                    break;
                }
                break;

                case 3:
                SaveLoad sL = new SaveLoad();
                sL.SaveSession(courses);
                break;

                case 4:
                Console.Clear();
                Console.WriteLine("Returning to main menu...");
                anim.LoadingAnimation(2);
                break;
            }
    }
    static void Main(string[] args)
    {
        List<COURSE> courses = new List<COURSE>();
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("WELCOME TO POMODORO PINCHES!!");
        Console.WriteLine("Please make a choice! ");
        Console.WriteLine(@"
1> New Session
2> Old Session
3> Quit");
        Console.Write("ENTER: ");
        int userInput = int.Parse(Console.ReadLine());
        Menu menu = new Menu(courses);
        switch(userInput)
        {
            case 1:
            menu.NewSession();
            courses = menu.GetCourseList();
            MAIN_MENU(courses);
            break;

            case 2:
            courses = menu.OldSession();
            MAIN_MENU(courses);
            break;

            case 3:
            Console.WriteLine("Thank you for your effort! Have a nice day!");
            break;
        }
    }
}