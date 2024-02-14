namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        Intro();

        StringMethods();
    }

    private static void StringMethods()
    {
        string sentence = "My name is Abdulhakim KAYA";

        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is Erdem KAYA"; // Clone ile alınan result2'yi etkilemez

        bool result3 = sentence.EndsWith("A"); // True
        bool result4 = sentence.StartsWith("m"); // False çünkü büyük M harfi ile başlar

        var result5 = sentence.IndexOf("name"); // 3 çünkü name kelimesi 3. index'den başlar
        var result6 = sentence.IndexOf("namee"); // -1 çünkü böyle bir kelime yoktur
        var result7 = sentence.IndexOf(" "); // 2 çünkü bulunan ilk boşluk karakterinin index'ini yazdırır
        var result8 = sentence.LastIndexOf(" "); // 16 çünkü sondan başlayarak bulunan ilk boşluk karakterinin index'ini yazdırır

        var result9 = sentence.Insert(0, "Hello, "); // belirlenen index'den sonrasına istenilen string eklenir.
        // sentence değişkenine atama yapılmadığı için değişim sadece result9 değişkeninde olur

        var result10 = sentence.Substring(3); // 3.index'den başlayarak sona kadar alır
        var result11 = sentence.Substring(3, 4); // 3.index'den başlayarak 4 karakter alır

        var result12 = sentence.ToLower(); // bütün karakterler küçük harfle yazılır
        var result13 = sentence.ToUpper(); // bütün karakterler büyük harfle yazılır
        // sentence değişkenine atama yapılmadığı için değişim sadece result12 ve result13 değişkenlerinde olur

        var result14 = sentence.Replace(" ", "*"); // string'deki boşluk karakterlerinin yerine * karakteri yazılır
        var result15 = sentence.Remove(2, 5); // 2.index'den sonra 5 karakter sildi (2.index dahil değil)
        // sentence değişkenine atama yapılmadığı için değişim sadece result14 ve result15 değişkenlerinde olur


        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);
        Console.WriteLine(result7);
        Console.WriteLine(result8);
        Console.WriteLine(result9);
        Console.WriteLine(result10);
        Console.WriteLine(result11);
        Console.WriteLine(result12);
        Console.WriteLine(result13);
        Console.WriteLine(result14);
        Console.WriteLine(result15);
    }

    private static void Intro()
    {
        // string is a reference type

        string city = "Ankara";
        Console.WriteLine(city);

        // string is a char array
        Console.WriteLine(city[0]);

        foreach (var letter in city)
        {
            Console.WriteLine(letter);
        }

        string city2 = "İstanbul";
        string result = city + city2;

        Console.WriteLine(result);
        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}