using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> _numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Boolean _listEnder = false;
        while(_listEnder==false)
        {
            Console.Write("Enter number: ");
            int _number = int.Parse(Console.ReadLine());
            if(_number==0)
            {
                _listEnder = true;
            }
            else _numberList.Add(_number);
        }
        int _sum = 0;
        float _average = 0;
        int _highest = 0;
        Console.WriteLine(_numberList.Count);
        for(int i = 0; i< _numberList.Count; i++)
        {
            _sum = _sum + _numberList[i];
            if(_numberList[i]>_highest)
            {
                _highest = _numberList[i];
            }
        }
        _average = (float)_sum/(float)_numberList.Count;
        Console.WriteLine($"The sum is: {_sum}");
        Console.WriteLine($"The average is: {_average}");
        Console.WriteLine($"The largest number is: {_highest}");
    }
}