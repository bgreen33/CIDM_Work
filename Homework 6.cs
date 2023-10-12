using System;
class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string className, double initialSalary)
    {
        profName name;
        classTeach = className;
        salary = initialSalary;
    }
    public void setSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }
    public double getSalary()
    {
        return salary;
    }
    public string getName()
    {
        return profName;
    }

    public string getClassTeach()
    {
        return classTeach;
    }
}
class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string className, double initialgrade)
    {
        studentName = name;
        classEnroll = className;
        studentGrade = initialgrade;
    }

    public void setgrade(double newgrade)
    {
        studentGrade = newgrade;
    }
    
    public double getgrade()
    {
        return studentGrade;
    }

    public string getName()
    {
        return studentName;
    }

    public string getClassEnroll()
    {
        return classEnroll;
    }
}

class Program
{
    static void Main()
    {
        // profs
        Professor professorAlice = new Professor("Alice", "Java", 9000);
        Professor professorBob = new Professor("Bob", "Math", 8000);

        // stu
        Student studentLisa = new Student("Lisa", "Java", 90);
        Student studentTom = new Student("Tom", "Math", 80);

        //prof info
        Console.WriteLine("Professor 1 Info:");
        Console.WriteLine("Name:" + professorAlice.getName());
        Console.WriteLine("Class taught: " + professorAlice.getClassTeach());
        Console.WriteLine("Salary:" + professorAlice.getSalary());

        Console.WriteLine("Professor 2 Info:");
        Console.WriteLine("Name: "+ professorBob.getName());
        Console.WriteLine("Class taught:" + professorBob.getClassTeach());
        Console.WriteLine("Salary:" + professorBob.getSalary());

        //stu info
        Console.WriteLine("Student 1 Info:");
        Console.WriteLine("Name: " + studentLisa.getName());
        Console.WriteLine("Class enrolled in: " + studentLisa.getClassEnroll());
        Console.WriteLine("Grade: " + studentLisa.getgrade());

        Console.WriteLine("Student 2 Info: ");
        Console.WriteLine("Name: " + studentTom.getName());
        Console.WriteLine("Class enrolled in: " +studentTom.getClassEnroll());
        Console.WriteLine("Grade: "+ studentTom.getgrade());

        //professor salary  calcs
        double salaryDifference = professorAlice.getSalary() - professorBob.getSalary();
        Console.WriteLine("Difference in salary: " +salaryDifference);

        //stu grade calcs
        double totalgradejavacourse = studentLisa.getgrade();
        double totalgrademathcourse = studentTom.getgrade();
        Console.WriteLine("Java course grade: " + totalgradejavacourse);
        Console.WriteLine("Math course grade: "+ totalgrademathcourse);
    }
}