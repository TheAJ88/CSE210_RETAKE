using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World! Welcome to the Magic Number game!");
        bool _trueStatus = false;
        while(_trueStatus==false)
        {
            Random randomGenerator = new Random();
            int _number = randomGenerator.Next(1, 100);
            bool _status = false;
            int _attempts = 0;
            while(_status==false)
            {
                Console.WriteLine("Enter a number: ");
                int _input = int.Parse(Console.ReadLine());
                if(_input<_number)
                {
                    Console.WriteLine("Higher");
                    _attempts++;
                    continue;
                }
                if(_input>_number)
                {
                    Console.WriteLine("Lower");
                    _attempts++;
                    continue;
                }
                if(_input==_number)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed it in only {_attempts} tries!");
                    _status = true;
                }
            }
            Console.WriteLine("Would you like to play the game again? Enter [Y/N] : ");
            string _choice = Console.ReadLine();
            if(_choice=="Y")
            {
                _status = true;
                continue;
            }
            if(_choice=="N")
            {
                _trueStatus = true;
            }
            else
            { 
                Console.WriteLine("WRONG INPUT. Goodbye"); 
                break;
            }
        }
    }
}