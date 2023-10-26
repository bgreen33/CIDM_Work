using System;
using System.Collections.Generic;

class Student
{
    private int studentid;
    private string studentname;

    public Student(int id, string name)
    {
        studentid = id;
        studentname = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentid}, Student Name: {studentname}");
    }

    public static List<Student> studentList = new List<Student>();

}

class Program
{
    static void Main(string[] args)
    {
        // make student profiles
        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444,"David");

        // grade dictionary
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8},
        };

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // calculations for average gpa
        double totalgpa = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalgpa += gpa;
        }
        double averagegpa = totalgpa / gradebook.Count;

        // print averages
        Console.WriteLine($"Average GPA: {averagegpa:F2}");

        //print info for students above average
        Console.WriteLine("Students with GPA abover than average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey?(student.studentname) && gradebook[student.studentname] > averagegpa)
            {
                student.PrintInfo();
            }
        }
    }
}