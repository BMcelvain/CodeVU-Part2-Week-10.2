using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Week10Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, List<decimal>> Morty = new Dictionary<string, List<decimal>>();
            IDictionary<string, List<decimal>> Charlie = new Dictionary<string, List<decimal>>();
            IDictionary<string, List<decimal>> Opie = new Dictionary<string, List<decimal>>();

            List<IDictionary<string, List<decimal>>> students = new List<IDictionary<string, List<decimal>>>();

            students.Add(Morty);
            students.Add(Charlie);
            students.Add(Opie);

            var rand = new Random();
            string name;

            foreach (IDictionary<string, List<decimal>> student in students)
            {
                if (student == students[0])
                {
                    name = "Morty";
                }
                else if (student == students[1])
                {
                    name = "Charlie";
                }
                else
                {
                    name = "Opie";
                }

                student.Add(new KeyValuePair<string, List<decimal>>(name, new List<decimal>()));
                student.Add(new KeyValuePair<string, List<decimal>>("homework", new List<decimal> {(decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100}));
                student.Add(new KeyValuePair<string, List<decimal>>("quizzes", new List<decimal> { (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100}));
                student.Add(new KeyValuePair<string, List<decimal>>("tests", new List<decimal> { (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100, (decimal)rand.NextDouble() * 100}));
            }

            foreach (IDictionary<string, List<decimal>> student in students)
            {
                PrintStudentInfo(student);
            }

            decimal assignmentAvg = CalculateAssignmentAverage("Opie", "tests", students);
            Console.WriteLine("\nOpie's average test grade: {0} ({1})", assignmentAvg, GetLetterGrade(assignmentAvg));

            CalculateClassAverage(students);
        }

        static void PrintStudentInfo(IDictionary<string,List<decimal>> student)
        {
            foreach (string key in student.Keys)
            {
                Console.WriteLine("\n{0}", key);

                foreach (decimal grade in student[key])
                {
                    Console.WriteLine("{0}", grade);
                }
            }
        }

        static decimal CalculateAssignmentAverage(string name, string assignment, List<IDictionary<string, List<decimal>>> students)
        {
            bool correctStudent = false;

            foreach (IDictionary<string, List<decimal>> student in students)
            {
                foreach (KeyValuePair<string, List<decimal>> kvp in student)
                {
                    if (kvp.Key == name)
                    {
                        correctStudent = true;
                    }

                    if (correctStudent == true && kvp.Key == assignment)
                    {
                        decimal gradeTotal = kvp.Value.Sum();
                        int gradeCount = kvp.Value.Count();
                        return gradeTotal / gradeCount;
                    }
                }
            }

            return -1;
        }

        static void CalculateClassAverage(List<IDictionary<string,List<decimal>>> students)
        {
            decimal gradeTotal = 0;
            decimal gradeCount = 0;

            foreach (IDictionary<string, List<decimal>> student in students)
            {
                foreach (List<decimal> value in student.Values)
                {
                    gradeCount += value.Count();
                    gradeTotal += value.Sum();
                }
            }

            Console.WriteLine("\nClass average: {0} ({1})", gradeTotal/gradeCount, GetLetterGrade(gradeTotal/gradeCount));
        }

        static string GetLetterGrade(decimal score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
