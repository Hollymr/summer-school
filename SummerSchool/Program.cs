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


            // while (menuChoice != 4)

            Console.WriteLine(" ");
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
        static double[] studentsCost = new double[15];

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
            double cost = 200;
            Console.WriteLine("Enter a student then press enter.");
            string student = Console.ReadLine();
            int spot = GetAvalibleSpot();
            if (student.ToLower() == "malfoy")
            {
                Console.WriteLine("Student cannot be enrolled!");
            }
            else
            {
                students[spot] = student;
                studentsCost[spot] = cost;
                Console.WriteLine(students[spot] + " is now enrolled at Hogwarts and owes £200.");
            }
        }

        static void UnEnrollStudent()
        {            
            Console.WriteLine("Enter the number of the student you want to unenroll then press enter.");
            PrintStudentList();
                      
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            int number = studentNumber - 1;
            Console.WriteLine(students[number] + " has been unenrolled.");
            students[number] = null;
            Console.WriteLine();
                                  
        }

        static void PrintStudentList()
        {

            for (int i = 0; i < students.Length; i++)
            {
                // EnrollStudent()
                Console.WriteLine(i + 1 + ". " + students[i] + " £" + studentsCost[i]);
            }

        }

        

        static void Exit()
        {
            
            Console.ReadKey();
       
        }
       
        
    

    }
    
}
