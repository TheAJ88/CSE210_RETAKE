using System;

class SaveLoad
{
    private string _fileName;
    public void SaveSession(List<COURSE> courses)
    {
        Console.WriteLine("What is your filename? : ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (COURSE entry in courses)
            {
                outputFile.WriteLine(entry.GetStringRepresentation());
            }
        }
    }
    public List<COURSE> LoadSession()
    {
        List<COURSE> _courses = new List<COURSE>();
        Console.WriteLine("Enter filename : ");
        _fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(_fileName);
        for(int i = 0; i< lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("~~");
            string courseName = parts[0];
            string courseType = parts[1];
            int courseTime = int.Parse(parts[2]);
            COURSE cs = new COURSE();
            cs.SetCourse(courseName, courseType, courseTime);
            _courses.Add(cs);
        }
        return _courses;
    }
}