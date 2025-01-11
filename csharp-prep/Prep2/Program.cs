using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        int _percentage = int.Parse(Console.ReadLine());
        string _letterGrade = "F";
        Boolean _status = false;
        if(_percentage>=90)
        {
            _letterGrade = "A";
        }
        else if(_percentage>=80)
        {
            _letterGrade = "B";
        }
        else if(_percentage>=70)
        {
            _letterGrade = "C";
        }
        else if(_percentage<60)
        {
            _letterGrade = "D";
        }
        else
        {
            _letterGrade = "F";
        }
        if(_percentage>=70)
        {
            _status = true;
        }
        if(_status == true)
        {
            Console.WriteLine($"Congratulations! You have passed with a grade of {_letterGrade}");
        }
        else
        {
            Console.WriteLine($"Sorry, you have failed with a grade of {_letterGrade}. Better luck next time!");
        }
    }
}