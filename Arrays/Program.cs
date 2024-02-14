namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] students1 = new string[3];
        students1[0] = "Engin";
        students1[1] = "Abdulhakim";
        students1[2] = "Furkan";
        // students1[3] = "Ömer";  // System.IndexOutOfRangeException: Index was outside the bounds of the array.

        foreach (string student in students1)
        {
            Console.WriteLine(student);
        }


        string[] students2 = { "Engin", "Abdulhakim", "Furkan" };

        foreach (string student in students2)
        {
            Console.WriteLine(student);
        }


        string[,] regions = new string[5, 3]
        {
            { "İstanbul", "İzmit", "Balıkesir" },
            { "Ankara", "Konya", "Kırıkkale" },
            { "Antalya", "Adana", "Mersin" },
            { "Rize", "Trabzon", "Samsun" },
            { "İzmir", "Muğla", "Manisa" },
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }

            Console.WriteLine("====================");
        }
    }
}