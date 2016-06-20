using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        //static string[] Students = new string[15];

        static int MenuGetInput()
        {

            //Console.Clear();
           // while (menuChoice != 4)
            

            Console.WriteLine("Welcome to Hogwarts!");
            Console.WriteLine();
            Console.WriteLine("Choose option below.");
            Console.WriteLine();
            Console.WriteLine("1. Enroll a student");
            Console.WriteLine("2. Unenroll a student");
            Console.WriteLine("3. Print out list of enrolled students");
            Console.WriteLine("4. Exit");
            
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            return menuChoice;

            
        }

        static string[] students = new string[15];
            

        static void Main(string[] args)
        {
           while(true)
            {
                
                int menuChoice = MenuGetInput();
                if (menuChoice == 1)                    
                {
                   EnrollStudent();                   
                }

               else if (menuChoice == 2)
                {
                    UnEnrollStudent();
                }

              else  if (menuChoice == 3)
                {
                    PrintStudentList();
                }

               else if (menuChoice == 4)
                {
                    //quit
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter number 1-4");
                }
                

            }
        }

        static int GetAvalibleSpot()
        {

        for(int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    return i;
                }
                
            }
            return -1;
        }



        static void EnrollStudent()
        {
 
            Console.WriteLine("Enter a student then press enter.");
            string student = Console.ReadLine();
            int spot = GetAvalibleSpot();
            students[spot] = student;
        }

        static void UnEnrollStudent()
        {
            string[] students = new string[15];

            for (int i = 0; i < 15; i--)
            {
                Console.WriteLine("Enter a student then press enter.");
                students[i] = Console.ReadLine();

            }

            Console.WriteLine();
            Console.WriteLine("You just enrolled: ");
            for (int i = 0; i < 15; i--)
            {
                Console.WriteLine(students[i]);
            }

        }

        static void PrintStudentList()
        {
           
            for (int i = 0; i < students.Length; i++)
            {
                // EnrollStudent()
                Console.WriteLine(students[i]);
            }
        }

        static void Exit()
        {
            
            Console.ReadKey();
       
        }
       
        
    

    }
    
}
