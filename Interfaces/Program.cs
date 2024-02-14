namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // InterfacesIntro();

        // InterfacesDemo();

        ICustomerDal[] customerDals = new ICustomerDal[2] { new SqlServerCustomerDal(), new OracleCustomerDal() };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    private static void InterfacesDemo()
    {
        // Interface'ler new'lenemez

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());
        customerManager.Add(new SqlServerCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
            { Id = 1, FirstName = "Abdulhakim", LastName = "Kaya", Address = "Malatya/Battalgazi" };

        Student student = new Student
            { Id = 1, FirstName = "Ömer", LastName = "Doğan", Department = "Bilgisayar Mühendisliği" };

        manager.Add(customer);
        manager.Add(student);
    }
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}