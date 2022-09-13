namespace FuelStationFinal;

public class Customer
{
    private int customerPlate;

    //Constructors
    public Customer()
    {
    }
    public Customer(int customerPlate)
    {
        this.customerPlate = customerPlate;
    }
    
    public int CustomerPlate
    {
        get { return customerPlate; }
    }

    public void showCustomerStatus()
    {
        Console.WriteLine($"ID: {customerPlate}");
    }
}