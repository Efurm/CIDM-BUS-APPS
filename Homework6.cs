namespace Homework6;

public class Program
{
    public static void Main(string[] args)
    {
        Professor prof1 = new Professor { ProfName = "Alice", ClassTeach = "Java", Salary = 9000 };
        Professor prof2 = new Professor { ProfName = "Bob", ClassTeach = "Math", Salary = 8000 };
        Student student1 = new Student { StudentName = "Lisa", ClassEnroll = "Java", StudentGrade = 90 };
        Student student2 = new Student { StudentName = "Tom", ClassEnroll = "Math", StudentGrade = 80 };
         Console.WriteLine($"Professor {prof1.ProfName} teaches {prof1.ClassTeach} and the salary is: {prof1.Salary}");
        Console.WriteLine($"Professor {prof2.ProfName} teaches {prof2.ClassTeach} and the salary is: {prof2.Salary}");
        Console.WriteLine($"Student {student1.StudentName} enrolls {student1.ClassEnroll} and the grade is: {student1.StudentGrade}");
        Console.WriteLine($"Student {student2.StudentName} enrolls {student2.ClassEnroll} and the grade is: {student2.StudentGrade}"); 
        double salaryDifference = prof1.Salary - prof2.Salary;
        Console.WriteLine($"The salary difference between {prof1.ProfName} and {prof2.ProfName} is: {salaryDifference}");
        double totalGrade = student1.StudentGrade + student2.StudentGrade;
        Console.WriteLine($"The total grade of {student1.StudentName} and {student2.StudentName} is: {totalGrade}");
    }
}
public class Professor
{
    public string ProfName { get; set; }
    public string ClassTeach { get; set; }
    public double Salary { get; set; }
}

public class Student
{
    public string StudentName { get; set; }
    public string ClassEnroll { get; set; }
    public double StudentGrade { get; set; }
}

