namespace Fuel;

public class Product
{
    public string ItemName { get; set; }
    public decimal Price { get; set; }

    public Product()
    {
  
    }
    public Product(string item, decimal price)
    {
        this.ItemName = item;
        this.Price = price;
    }
}