using System;

class COURSE
{
    private string _courseName;
    private string _courseType;
    private string  _courseTime;
    private string _pomodoroType;

    public void CourseInitialize()
    {
        Console.Write("What is the name of your course : ");
        _courseName = Console.ReadLine();
        Console.Write("What is the course type : ");
        _courseType = Console.ReadLine();
        Console.Write("How many hours a week must you attend class for this course : ");
        _courseTime = Console.ReadLine();
    }
    public string GetCourseType()
    {
        return _courseType;
    }
    public int GetCourseTime()
    {
        return _courseTime;
    }

}