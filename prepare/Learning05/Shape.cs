using System;
using System.Drawing;

public class Shape
{
    private string _color;
    public Shape(string color) 
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string c)
    {
        _color = c;
    }
    public virtual double GetArea()
    {
        return 0.0;
    }
    public virtual string GetShape()
    {
        return "Shape";
    }
}