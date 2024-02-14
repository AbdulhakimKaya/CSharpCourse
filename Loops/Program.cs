namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        // ForLoop();
        //
        // WhileLoop();
        //
        // DoWhileLoop();
        
        string[] students = { "Engin", "Abdulhakim", "Furkan" };

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 0);

        Console.WriteLine("number is {0}", number);
    }

    private static void WhileLoop()
    {
        int number = 10;

        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }

        Console.WriteLine("number is {0}", number);
    }

    private static void ForLoop()
    {
        //   start   condition  increment
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}