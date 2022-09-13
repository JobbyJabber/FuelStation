namespace Fuel;

public class Customer
{
    public string CarPlate { get; set; }
    public string ReceipeID { get; set; }

    public List<string> ShoppingList;
    
    public Customer(string plate, string receipeID)
    {
        this.CarPlate = plate;
        this.ReceipeID = receipeID;
    }

    public void Bagno()
    {
    }
}