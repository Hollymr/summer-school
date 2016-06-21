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
            int menuChoice = 0;

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
            
            while (menuChoice < 1 || menuChoice > 4)
            {
                try
                {
                    string userChoice = Console.ReadLine();
                    menuChoice = Convert.ToInt32(userChoice);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please enter number 1-4");
                }
            }

            
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
            Console.WriteLine("Enter first and last name of a student then press enter.");
            string student = Console.ReadLine();
            var names = student.Split(' ');
            string firstName = names[0];
            string lastName = names[1];
            int spot = GetAvalibleSpot();
            // special case malfoy
            if (student.ToLower() == "malfoy")
            {
                Console.WriteLine("Student cannot be enrolled!");
            }
            // special case harry potter 
            else if (student.ToLower() == "potter")
            {
                students[spot] = student;
                studentsCost[spot] = cost/2;               
                Console.WriteLine(students[spot] + " is now enrolled at Hogwarts and owes £" + cost/2);
            }
            // special case longbottom
            else if (student.ToLower() == "longbottom")
            {                
                if (CountStudent() < 10)
                {
                    students[spot] = student;
                    studentsCost[spot] = cost * 0;
                    Console.WriteLine(students[spot] + " is now enrolled at Hogwarts and owes £" + cost * 0);
                }
                else
                {
                    students[spot] = student;
                    studentsCost[spot] = cost;
                    Console.WriteLine(students[spot] + " is now enrolled at Hogwarts and owes £" + cost);                    
                }
            }

            // first initial same as last initial
            else if (firstName.First() == lastName.First())
            {
                students[spot] = student;
                studentsCost[spot] = cost * .9;
                Console.WriteLine(students[spot] + " is now enrolled at Hogwarts and owes £" + cost * .9);
            }

            // special case tom
            else if (student.ToLower() == "tom")
            {
                Console.WriteLine("RED ALERT!!!HE WHO MUST NOT BE NAMED!!!");
            }
            // special case riddle
            else if (student.ToLower() == "riddle")
            {
                Console.WriteLine("RED ALERT!!!HE WHO MUST NOT BE NAMED!!!");
            }
            //speical case voldemort
            else if (student.ToLower() == "voldemort")
            {
                Console.WriteLine("RED ALERT!!!HE WHO MUST NOT BE NAMED!!!");
            }
            else
            {
                students[spot] = student;
                studentsCost[spot] = cost;
                Console.WriteLine(students[spot] + " is now enrolled at Hogwarts and owes £" + cost);
            }
        }

        static int CountStudent()
        {
            int count = 0;
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    count ++;
                }                
            }
            return count;


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
