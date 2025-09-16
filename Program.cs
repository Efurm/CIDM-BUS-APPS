namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Q1

        Console.WriteLine("Input an integer: ");
        string inputN = Console.ReadLine();
        int numberN = Convert.ToInt16(inputN);

        for (int i = 2; i * i <= numberN; i += 2)
        {
            if (numberN % 2 == 0)
            {
                Console.WriteLine(inputN + "is non-prime");
                break;

            }
            if (numberN % i == 0)
            {
                Console.WriteLine(inputN + "is non-prime");

            }
            else
            {
                Console.WriteLine(inputN + "is Prime");
            }
        } 
        
        
        
    

        //Q2

        Console.WriteLine("Assign an int value to N:");
        string N = Console.ReadLine();
        int numN = Convert.ToInt16(N);
        for (int i = 0; i < numN; i++)
        {
            for (int z = 0; z < numN - 1; z++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        } 



        //Q3
         Console.WriteLine("Enter an integer N: ");
        string strN = Console.ReadLine();
        int intN = Convert.ToInt16(strN);
        
            for (int x = 0; x < intN; x++)
        {
            for (int y = 0; y < x; y++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
            }


    
}
