using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Greeter
    {
        public string Hi (string word)
        {
            return "This is not right";
        }

        public string GreetByHour(int hour)
        {
            return "This is not right";
        }
    }

    public class Sorter
    {
        public int[] SortDesc (int[] numbers)
        {
            return numbers;
        }

            public int[] SortAsc (int[] numbers)
        {
            return numbers;
        }
    }

    public class Concater
    {
        public string Concat(string a, string b, string c, string d) 
        {

            return "This is not right";
        }
        public string ConcatFromArray(string[] words)
        {
            return "This is not right";
        }
    }
    public class Rounder
    {
        public double RoundUp (double number)
        {
            return 1;
        }

        public double RoundDown (double number)
        {
            return 1;
        }

        public double Round (double number)
        {
            return Math.Round(number);
        }
    }

    public class OddOrEvenNumbers
    {
        public int[] GetOddNumbers(int max)
        {
            return new int[0];
        }

        public int[] GetEvenNumbers(int max)
        {
            return new int[0];
        }
    }

    public class HyphenReplacer
    {
        public string usingFor(string message)
        {
            //use a for-loop
            return "This is not right";
        }

          public string usingWhile(string message)
        {
            //use a while-loop
            return "This is not right";
        }
    }

    public class TriangleCreator
    {
        public string create(int baseline)
        {
           
           return "This is not right";
            }
    }
    public class Numbers
    {
        public int A {get;set;}
        public int B {get;set;}
    }

    public class Team
    {
        public string Name {get; set;}
        public int Points {get; set;}
    }
}
