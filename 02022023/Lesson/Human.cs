using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public string FullName;
        public byte Age;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age}");
        }
    }
}
