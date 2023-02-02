using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Car:Vehicle
    {

        public override string ToString()
        {
            return $"Brand: {Brand} - Model: {Model}";
        }
    }

}
