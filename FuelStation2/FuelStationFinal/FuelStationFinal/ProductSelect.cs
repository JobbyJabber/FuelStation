namespace FuelStationFinal;

public class ProductSelect
{
    private Product product;
    private ProductSelect next;
    private ProductSelect previous;

    public ProductSelect()
    {
        product = new Product();
        next = previous = null;
    }

    public ProductSelect(Product product)
    {
        this.product = product;
    }
    public Product Product
    {
        get { return this.product; }
        set { product = value; }
    }
    public ProductSelect Next
    {
        get { return this.next; }
        set { next = value; }
    }
    public ProductSelect Previous
    {
        get { return this.previous; }
        set { previous = value; }
    }
}