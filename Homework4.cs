namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt16(Console.ReadLine());
        int largNum = FindLarg(a, b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largNum}");

        //Q2
        Console.WriteLine("Enter number N:");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter shape (right or left):");
        string shape = Console.ReadLine();
        if (shape == "left")
        {
            PrintLT(N);
        }
        else if (shape == "right")
        {
            PrintRT(N);
        }
        else
        {
            Console.WriteLine("wrong shape given, choose either right or left");
        }
    }

    static int FindLarg(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    //Q2
    static void PrintLT(int N)
    {
        Console.WriteLine($"N is: {N}, Shape is: Left");
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void PrintRT(int N)
    {
        Console.WriteLine($"N is: {N}, Shape is: Right");
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N - i; j++)
            {
                Console.Write(" ");
            }
            for (int z = 1; z <= i; z++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }



}
