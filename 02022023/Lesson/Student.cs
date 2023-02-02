using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public string GroupNo;
        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age} - GroupNo: {GroupNo}");
        }
    }
}
