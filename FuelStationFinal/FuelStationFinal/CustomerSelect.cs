namespace FuelStationFinal;

public class CustomerSelect
{
    private Customer customer;
    private CustomerSelect next;

    public CustomerSelect()
    {
        customer = new Customer();
        next = null;
    }
    public CustomerSelect(Customer customer)
    {
        this.customer = customer;
    }
    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }
    public CustomerSelect Next
    {
        get { return next; }
        set { next = value; }
    }
}
