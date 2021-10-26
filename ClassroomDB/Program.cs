using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ClassContext context = new ClassContext())
            //    {
            //    Student student1 = new Student();
            //    student1.Name = "Yousif";
            //    student1.Food = "Deep Dish Pizza";
            //    student1.Hometown = "Oak Park, MI";

            //    context.students.Add(student1);

            //    Student student2 = new Student();
            //    student2.Name = "Justin";
            //    student2.Food = "Baja Blast";
            //    student2.Hometown = "Wyoming, MI";

            //    context.students.Add(student2);

            //    Student student3 = new Student();
            //    student3.Name = "Matt";
            //    student3.Food = "Hot Wings";
            //    student3.Hometown = "Flint, MI";

            //    context.students.Add(student3);

            //    Student student4 = new Student();
            //    student4.Name = "Logan";
            //    student4.Food = "Funions";
            //    student4.Hometown = "Plymouth, MI";

            //    context.students.Add(student4);

            //    Student student5 = new Student();
            //    student5.Name = "Raston";
            //    student5.Food = "Vanilla Instant Pudding";
            //    student5.Hometown = "Zeeland, MI";

            //    context.students.Add(student5);

            //    Student student6 = new Student();
            //    student6.Name = "Yash";
            //    student6.Food = "Hot Cheeto Puffs";
            //    student6.Hometown = "Detroit, MI";

            //    context.students.Add(student6);

            //    Student student7 = new Student();
            //    student7.Name = "Chris";
            //    student7.Food = "Tacos";
            //    student7.Hometown = "Novi, MI";

            //    context.students.Add(student7);

            //    Student student8 = new Student();
            //    student8.Name = "Radeen";
            //    student8.Food = "Mexican";
            //    student8.Hometown = "Warren, MI";

            //    context.students.Add(student8);

            //    Student student9 = new Student();
            //    student9.Name = "Josh";
            //    student9.Food = "Naleśniki";
            //    student9.Hometown = "Northville, MI";

            //    context.students.Add(student9);

            //    Student student10 = new Student();
            //    student10.Name = "Aron";
            //    student10.Food = "Sushi";
            //    student10.Hometown = "Berea, KY";

            //    context.students.Add(student10);

            //    Student student11 = new Student();
            //    student11.Name = "Kasean";
            //    student11.Food = "Steak";
            //    student11.Hometown = "Detroit, MI";

            //    context.students.Add(student11);

            //    Student student12 = new Student();
            //    student12.Name = "Scott";
            //    student12.Food = "Nashville Chicken";
            //    student12.Hometown = "Lansing, MI";

            //    context.students.Add(student12);

            //    Student student13 = new Student();
            //    student13.Name = "Brandon";
            //    student13.Food = "Sushi";
            //    student13.Hometown = "Novi, MI";

            //    context.students.Add(student13);

            //    context.SaveChanges();
            // }
            bool runProgram = true;
            while (runProgram)
            { 
                DisplayAllDB();
                DisplayStudentDB();
                runProgram = Validator.Validator.getContinue();
            }
        }
        static void DisplayAllDB()
        {
            ClassContext context = new ClassContext();

            foreach (Student s in context.students)
            {
                Console.WriteLine($"{s.StudentID}. {s.Name}");
            }
        }
        static void DisplayStudentDB()
        {
            ClassContext context = new ClassContext();
            Console.WriteLine("Pick a student ID");
            int input = (int)Validator.Validator.GetNumber(1, 13);

            Student s = context.students.Where(student => student.StudentID == input).First();

            Console.WriteLine($"{s.Food}, {s.Hometown}");
        }
    }
}
