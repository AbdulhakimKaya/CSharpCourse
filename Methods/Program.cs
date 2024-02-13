namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        Add();
        Add();

        var result = Add2(3, 5);
        var result2 = Add2(3);
        var result3 = Add2();

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);


        int number1 = 10;
        int number2 = 20;
        var result4 = Add3(number1, number2);

        Console.WriteLine(result4); // 50
        Console.WriteLine(number1); // 10


        int number3 = 10;
        int number4 = 20;
        var result5 = Add4(ref number3, number4);

        Console.WriteLine(result5); // 50
        Console.WriteLine(number3); // 30


        int number5;
        int number6 = 20;
        var result6 = Add5(out number5, number6);

        Console.WriteLine(result5); // 50
        Console.WriteLine(number3); // 30


        Console.WriteLine(Multiply(2, 3));
        Console.WriteLine(Multiply(2, 3, 4));

        Console.WriteLine(Add5(2,3,4,5,6,7));
        
    }
    static void Add()
    {
        Console.WriteLine("added");
    }

    static int Add2(int number1 = 5, int number2 = 10)
    {
        var result = number1 + number2;
        return result;
    }

    static int Add3(int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    // ref, number3 referansı olarak method'daki number3 alınıyor yani method'da yapılan değişiklikler number3'e etki ediyor
    static int Add4(ref int number3, int number4)
    {
        number3 = 30;
        return number3 + number4;
    }

    // out, ref ile mantığı aynıdır ama method'a gönderilen number5 yukarıda kullanılırken değer girilmezse de hata vermez
    // bunun için method içinde en az bir kere set edilmesi lazım
    static int Add5(out int number5, int number6)
    {
        number5 = 30;
        return number5 + number6;
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    static int Add5(params int[] numbers)
    {
        return numbers.Sum();
    }
}