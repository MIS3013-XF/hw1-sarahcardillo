// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string StudentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double Homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            double Participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double Quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double Midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double Final = Convert.ToDouble(Console.ReadLine());

            double finalGrade = (Homework * 0.20) + (Participation * 0.05) + (Quizzes * 0.20) + (Midterm * 0.25) + (Final * 0.30);

            Console.WriteLine(FirstName + " " + LastName + "(" + StudentID + "), your final grade is " + finalGrade);



            Console.ReadKey();
        }
    }
}
