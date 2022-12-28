# CodeVU-Part2-Week-10.2

Exercise - Grade Book using Lists and Dictionaries
You are tasked with designing a grade book for a class of student where you will need to keep track of each student's scores as well as implement some useful operations that can be performed on the grade book. 

Requirements:
For this assignment, be sure to declare dictionaries using the IDictionary interface and initialize them using the Dictionary implementation (e.g. IDictionary<string, List<decimal>> = new Dictionary<string, List<decimal>>()). For lists, be sure to use List<T> instead of ArrayList.
Create three dictionaries: Morty, Charlie, Opie.
Each dictionary should have the keys name, homework, quizzes, and tests. The name key should be the name of the student and the other keys should be an empty List of type decimal (e.g. new List<decimal>()).
Assign multiple random scores for each assignment for each student. Scores should be of type decimal.
Create a list students that contains each student dictionary you previously created.

Required Functionality:
Write a function PrintStudentInfo(IDictionary<string, List<decimal> student) for displaying the following information about a student: name, homework, quizzes, and tests (scores).
Write a function CalculateAssignmentAverage(string name, string assignment) that calculates the average for a student's assignments (e.g. the average score for Morty's quizzes).
Write a function CalculateClassAverage(List<IDictionary<string, List<decimal>> students) that takes in the list of students and calculates the average of each assignment per student and then calculates the average student score.
 Write a function GetLetterGrade(decimal score) that takes in a student's score and converts it to a letter grade. 
(A): score >=90; (B): score >=80; (C): score >=70; (D): score >=60; (F): score <60
You should catch and display a user-friendly error message for any exceptions that are thrown when performing operations using Dictionaries and Lists (e.g. adding a key that already exists).
You should be displaying a user-friendly message for each operation (e.g. "Morty's average score for quizzes was 80.7 (B)").
