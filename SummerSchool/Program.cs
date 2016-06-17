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

        static int MenuGetInput()
        {

            //int menuChoice = 1;
           // while (menuChoice != 4)
            

            Console.WriteLine("Welcome to Hogwarts!");
            Console.WriteLine("Choose option below.");

            Console.WriteLine("1. Enroll a student");
            Console.WriteLine("2. Unenroll a student");
            Console.WriteLine("3. Print out list of enrolled students");
            Console.WriteLine("4. Exit");

            int mainChoice = Convert.ToInt32(Console.ReadLine());
            return mainChoice;

            
        }
        

        static void Main(string[] args)
        {
            int menuChoice = MenuGetInput();
            if (menuChoice == 1) 
            {
                EnrollStudent();
            }

            if (menuChoice == 2)
            {
                UnEnrollStudent();
            }

            if (menuChoice == 3)
            {
                PrintStudentList();
            }


            Console.ReadKey();  
        }


         

        static void EnrollStudent()
        {
            //Students[1] = "Tom";
            Console.WriteLine("Enroll");
            

        }

        static void UnEnrollStudent()
        {

            Console.WriteLine("Unenroll");
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
