namespace Classes;

public class Customer
{
    public int Id { get; set; }

    // encapsulation
    
    // private string _firstName;
    //
    // public string FirstName
    // {
    //     get
    //     {
    //         return "Mr. " + _firstName;
    //     }
    //     set
    //     {
    //         _firstName = value;
    //     }
    // }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}