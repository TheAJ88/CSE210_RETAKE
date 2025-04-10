using System;

class COURSE
{
    private string _courseName;
    private string _courseType;
    private int  _courseTime;

    public void CourseInitialize()
    {
        Console.Write("What is the name of your course : ");
        _courseName = Console.ReadLine();
        Console.WriteLine(@"What is the course type (Enter a number) : 
1) THEORETICAL - Your class involves a lot of theory-based reading and evaluation
2) PRACTICAL - Your class involves a lot hands-on work
3) MIXED - Your class involves both theoretical and practical effort");
        string courseTypenum = Console.ReadLine();
        if(courseTypenum=="1") _courseType = "theoretical";
        if(courseTypenum=="2") _courseType = "practical";
        if(courseTypenum=="3") _courseType = "mixed";
        Console.Write("How many hours a week must you attend class for this course : ");
        _courseTime = int.Parse(Console.ReadLine());
    }
    public string GetCourseType()
    {
        return _courseType;
    }
    public int GetCourseTime()
    {
        return _courseTime;
    }
    public string GetStringRepresentation()
    {
        return ($"{_courseName}~~{_courseType}~~{_courseTime}");
    }
    public void DisplayCourse()
    {
        Console.WriteLine($"COURSE NAME : {_courseName} | COURSE TYPE : {_courseType} | COURSE TIME : {_courseTime}");
    }
    public void SetCourse(string name, string type, int time)
    {
        _courseName = name;
        _courseType = type;
        _courseTime = time;
    }

}