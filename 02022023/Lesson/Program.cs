using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human hm = new Human
            {
                Age = 34,
                FullName = "Abbas Memmedov"
            };

            Student std = new Student
            {
                Age = 14,
                FullName = "Hikmet Abbasov",
                GroupNo = "P123"
            };

            hm.ShowInfo();
            std.ShowInfo();

            Human human1 = new Human { FullName = "Eli", Age = 15 };
            Student student1 = new Student { FullName = "Nermin", Age = 20, GroupNo = "P222" };

            Human human2 = student1;

            Student student3 = (Student)human2;

            human1.ShowInfo();
            student1.ShowInfo();
            human2.ShowInfo();

            Human[] humans = { human1, std, human2 };
            ShowHumans(humans);

            Human human3 = new Employee();
            human3 = new Teacher();

            Employee emp = new Teacher();


            Human[] humans1 = { emp, student1, student3, new Teacher() };
            foreach (var item in humans1)
            {
                //if(item is Student)
                //{
                //    Student std1 = (Student)item;
                //    Console.WriteLine(std1.GroupNo);
                //}

                Student std1 = item as Student;

                if (std1 != null)
                {
                    Console.WriteLine(std1.GroupNo);
                }
            }
        }

        static void ShowHumans(Human[] humans)
        {
            foreach (Human item in humans)
            {
                item.ShowInfo();
            }
        }
    }
}
