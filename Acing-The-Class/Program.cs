using System;
using System.Collections.Generic;

namespace Acing_The_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> exam = new SortedList<string, int>();

            exam.Add("Tom", 59);
            exam.Add("Robert", 95);
            exam.Add("Sophie", 72);
            exam.Add("Maria", 68);
            exam.Add("Nick", 84);

            //your code goes here
            foreach(string s in exam.Keys)
            {
                string passOrNot = (exam[s] < 70) ? "Failed" : "Passed";
                Console.WriteLine(s +": "+ passOrNot);  // Learn: 72  Solo: 59
            }
        }
    }
}
