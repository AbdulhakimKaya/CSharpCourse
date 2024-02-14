namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer
            {
                FirstName = "Engin"
            },
            new Student
            {
                FirstName = "Abdulhakim"
            },
            new Person
            {
                FirstName = "Furkan"
            }
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

// class'ların tek başına bir anlamı vardır fakat interface'lerin tek başına bir anlamı yoktur
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// bir class birden fazla class'ı inherit edemez ama birden fazla interface'i implement edebilir
class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}