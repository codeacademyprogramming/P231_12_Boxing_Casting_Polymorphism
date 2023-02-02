using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numByte = 255;

            //Implicit  casting
            int numInt = numByte ;

            numInt = 1543;

            //Explicit casting
            //numByte = Convert.ToByte(numInt);
            numByte = (byte)numInt;


            Car car1 = new Car { Brand = "Mercedes",Model = "E200"};

            //upcasting
            Vehicle vehicle1 = car1;


            //Downcasting
            //Car car2 = (Car)vehicle1;
            Car car2 = vehicle1 as Car;
            Console.WriteLine(car2.Model);


            Vehicle vehicle2 = new Vehicle
            {
                Brand = "A",
                Model = "B"
            };


            
            object vehicleObj = vehicle2;
            object carObj = car2;

            Car car3 = carObj as Car;


            Console.WriteLine(carObj);

            int num = 50;

            //boxing
            object numObj = num;

            var result = (int)numObj + 10;

            //unboxing
            num = (int)numObj;

            object[] objectArr = { 34, "dffd", car2 };

            var item1 = objectArr[0];
            var item2 = objectArr[1];
            var item3 = objectArr[2];

            object[] objects = { vehicle2, "Fdf", 43, new Vehicle() { Model = "X6" } };

            foreach (var item in objects)
            {
                if (item is Vehicle)
                {
                    Vehicle vc = (Vehicle)item;
                    Console.WriteLine(vc.Model);
                }
            }

            



        }
    }
}
