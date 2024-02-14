namespace Interfaces;

public interface ICustomerDal
{
    void Add();
    void Update();
    void Delete();
}

class SqlServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Sql Server added");
    }

    public void Update()
    {
        Console.WriteLine("Sql Server updated");
    }

    public void Delete()
    {
        Console.WriteLine("Sql Server deleted");
    }
}

class OracleCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Oracle added");
    }

    public void Update()
    {
        Console.WriteLine("Oracle updated");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle deleted");
    }
}

class CustomerManager
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}