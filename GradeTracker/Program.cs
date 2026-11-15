using System;

namespace GradeTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeManager manager = new GradeManager();

            bool running = true;

            while (running)
            {
                DisplayMenu();

                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        manager.EnterStudentScores();
                        break;

                    case "2":
                        manager.DisplayStudentResults();
                        break;

                    case "3":
                        manager.DisplayStatistics();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("\nThank you for using the Grade Tracker!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please select 1, 2, 3 or 4.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("       STUDENT GRADE TRACKER");
            Console.WriteLine("================================");
            Console.WriteLine("1. Enter Student Scores");
            Console.WriteLine("2. View Student Results");
            Console.WriteLine("3. View Class Statistics");
            Console.WriteLine("4. Exit");
            Console.WriteLine("================================");
        }
    }
}