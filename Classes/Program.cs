namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.Id = 1;
        customer.FirstName = "Abdulhakim";
        customer.LastName = "KAYA";
        customer.City = "Diyarbakır";

        Customer customer2 = new Customer { Id = 2, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

        Console.WriteLine(customer.FirstName);
        Console.WriteLine(customer2.FirstName);
    }
}