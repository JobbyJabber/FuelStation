namespace FuelStationFinal;

public class Receipe
{
    private int idReceipe;
    private CustomerSelect customer;
    private ProductLogic itemsList;
    private decimal finalValue;

    //Constructores
    public Receipe()
    {
    }
    public Receipe(int idReceipe, ProductLogic itemsList, decimal finalValue)
    {
        this.idReceipe = idReceipe;
        this.customer = customer;
        this.itemsList = itemsList;
        this.finalValue = finalValue;
    }

    //Getters and Setters
    public int IdReceipe
    {
        get { return idReceipe; }
    }
    public CustomerSelect Customer
    {
        get { return customer; }
        set { customer = value; }
    }
    public ProductLogic ListaItems
    {
        get { return itemsList; }
        set { itemsList = value; }
    }
    public decimal ValorInvoice
    {
        get { return finalValue; }
        set { finalValue = value; }
    }

    /*=========================================METHODS================================*/
    // Method to show the status of each invoice
    public void showInvoiceStatus()
    {
        Console.WriteLine("ID: {0}", idReceipe);
        Console.WriteLine("Customer Plate: {0}", customer.Customer.CustomerPlate);
        Console.WriteLine("Items List: ");
        itemsList.listProductByReceipe();
        Console.WriteLine("Total Invoice Value: {0}", itemsList.totalValue());
    }
}