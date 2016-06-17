using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hogwarts!");
            Console.WriteLine("Choose option below.");
           
            while(true)
            {
                // Print out the menu 
                Console.WriteLine("1. Enroll a student");
                Console.WriteLine("2. Unenroll a student");
                Console.WriteLine("3. Print out list of enrolled students");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent();
                }

            }
            
        }
        static void EnrollStudent()
        {
            Students[1] = "Tom";
            

        }

        static void UnEnrollStudents()
        {
        

        }

        static void PrintStudentList()
        {

        }

        static void Exit()
        {
            Console.ReadKey();
        }

    }
    
}
