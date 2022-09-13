namespace FuelStationFinal;

public class Product
{
    private string nameItem;
    private decimal price;
    public decimal quantity;
    private decimal totalPrice;
    
    public Product(){ }

    public Product(string nameItem, decimal price)
    {
        this.nameItem = nameItem;
        this.price = price;
        this.quantity = 0;
        this.totalPrice = 0;
    }

    public string NameItem
    {
        get { return this.nameItem;}
        set { this.nameItem = value; }
    }

    public decimal Quantity
    {
        get { return this.Quantity; }
        set { quantity = value; }
    }

    public decimal Price
    {
        get { return this.price; }
        set { price = value; }
    }

    public decimal TotalPrice
    {
        get { return this.price; }
        set { totalPrice = value; }
    }

    public void ShowProductStatus()
    {
        Console.WriteLine($"Name: {nameItem}, Price: {price}");
    }
    
    public void itemStatusByInvoice()
    {
        Console.WriteLine($"Name: {nameItem}, Price: {price}, Quantity: {quantity}, Total Price: {totalPrice}");
    }
    
}