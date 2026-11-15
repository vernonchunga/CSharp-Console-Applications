using System;

namespace GradeTracker
{
    public class GradeManager
    {
        private string[] studentNames = Array.Empty<string>();
        private double[] scores = Array.Empty<double>();

        // Method to enter student information
        public void EnterStudentScores()
        {
            Console.Write("\nEnter the number of students: ");

            if (!int.TryParse(Console.ReadLine(), out int numberOfStudents) ||
                numberOfStudents <= 0)
            {
                Console.WriteLine("Please enter a valid number of students.");
                return;
            }

            // Create arrays based on the number of students
            studentNames = new string[numberOfStudents];
            scores = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"\nEnter name of student {i + 1}: ");

                string name = Console.ReadLine() ?? "";

                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.Write("Name cannot be empty. Enter student name: ");
                    name = Console.ReadLine() ?? "";
                }

                studentNames[i] = name.Trim();

                Console.Write($"Enter score for {studentNames[i]}: ");

                while (!double.TryParse(Console.ReadLine(), out scores[i]) ||
                       scores[i] < 0 || scores[i] > 100)
                {
                    Console.Write("Invalid score. Enter a score between 0 and 100: ");
                }
            }

            Console.WriteLine("\nStudent records successfully saved!");
        }

        // Method to calculate a student's grade
        public string GetGrade(double score)
        {
            if (score >= 80)
                return "A";
            else if (score >= 70)
                return "B";
            else if (score >= 60)
                return "C";
            else if (score >= 50)
                return "D";
            else
                return "F";
        }

        public static double CalculateAverageFor(double[] scores)
        {
            if (scores == null || scores.Length == 0)
                throw new ArgumentException("Scores cannot be empty.");

            double total = 0;

            foreach (double score in scores)
            {
                total += score;
            }

            return total / scores.Length;
        }

        public static double GetHighestScoreFrom(double[] scores)
        {
            if (scores == null || scores.Length == 0)
                throw new ArgumentException("Scores cannot be empty.");

            double highest = scores[0];

            foreach (double score in scores)
            {
                if (score > highest)
                    highest = score;
            }

            return highest;
        }

        public static double GetLowestScoreFrom(double[] scores)
        {
            if (scores == null || scores.Length == 0)
                throw new ArgumentException("Scores cannot be empty.");

            double lowest = scores[0];

            foreach (double score in scores)
            {
                if (score < lowest)
                    lowest = score;
            }

            return lowest;
        }

        public double CalculateAverage()
        {
            if (scores.Length == 0)
                return 0;

            return CalculateAverageFor(scores);
        }

        public double GetHighestScore()
        {
            if (scores.Length == 0)
                return 0;

            return GetHighestScoreFrom(scores);
        }

        public double GetLowestScore()
        {
            if (scores.Length == 0)
                return 0;

            return GetLowestScoreFrom(scores);
        }

        // Method to display individual student results
        public void DisplayStudentResults()
        {
            if (scores.Length == 0)
            {
                Console.WriteLine("\nNo student records available. Enter scores first.");
                return;
            }

            Console.WriteLine("\n========== STUDENT RESULTS ==========");

            Console.WriteLine("{0,-20} {1,-15} {2,-10}",
                "Student Name", "Score", "Grade");

            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine("{0,-20} {1,-15:F2} {2,-10}",
                    studentNames[i],
                    scores[i],
                    GetGrade(scores[i]));
            }
        }

        // Method to display class statistics
        public void DisplayStatistics()
        {
            if (scores.Length == 0)
            {
                Console.WriteLine("\nNo student records available. Enter scores first.");
                return;
            }

            Console.WriteLine("\n========== CLASS STATISTICS ==========");

            Console.WriteLine($"Number of students: {scores.Length}");

            Console.WriteLine($"Average score: {CalculateAverage():F2}");

            Console.WriteLine($"Highest score: {GetHighestScore():F2}");

            Console.WriteLine($"Lowest score: {GetLowestScore():F2}");
        }
    }
}