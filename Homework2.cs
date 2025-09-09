namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        
        Console.WriteLine("Please input a letter grade: ");
        string grade = Console.ReadLine();
        string gradeA = "A";
        string gradeB = "B";
        string gradeC = "C";
        string gradeD = "D";
        string gradeF = "F";
        if (grade == gradeA)
        {
            Console.WriteLine("GPA POINT: 4");
        }
        else if (grade == gradeB)
        {
            Console.WriteLine("GPA POINT: 3");
        }
        else if (grade == gradeC)
        {
            Console.WriteLine("GPA POINT: 2");
        }
        else if (grade == gradeD)
        {
            Console.WriteLine("GPA POINT: 1");
        }
        else if (grade == gradeF)
        {
            Console.WriteLine("GPA POINT: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        
        //Question 2
        Console.WriteLine("Please input the first num: ");
        string num1 = Console.ReadLine();
        Console.WriteLine("Please input the second num: ");
        string num2 = Console.ReadLine();
        Console.WriteLine("Please input the third num: ");
        string num3 = Console.ReadLine();
        int number1 = Convert.ToInt16(num1);
        int number2 = Convert.ToInt16(num2);
        int number3 = Convert.ToInt16(num3);
        if (number1 < number2)
        {
            if (number1 < number3)
            {
                Console.WriteLine($"The smallest value is: {number1} ");
            }
        }
        else if (number2 < number1)
        {
            if (number2 < number3)
            {
                Console.WriteLine($"The smallest value is: {number2} ");
            }
        }
         Console.WriteLine($"The smallest value is: {number3} "); 

    }

}
