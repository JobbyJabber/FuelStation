namespace FuelStationFinal;

public class CustomerLogic
{
    public CustomerSelect finalCustomer;
        
    public CustomerLogic()
    {
        finalCustomer = null;
    }
    public CustomerLogic(CustomerSelect finalCustomer)
    {
        this.finalCustomer = finalCustomer;
    }

    //Getters and Setters
    public CustomerSelect FinalCustomer
    {
        get { return finalCustomer; }
        set { finalCustomer = value; }
    }
    public bool addCustomer(Customer customerData)
    {
        if (customerData == null)
        {
            return false;
        }
        if (finalCustomer == null)
        {
            finalCustomer = new CustomerSelect();
            finalCustomer.Customer = customerData;
        }
        return false;
    }
    
    // public CustomerFork returnCustomerByPlate (int customerPlate)
    // {
    //     CustomerFork tmp = null;
    //     int count = 0;
    //     if (!(finalCustomer == null))
    //     {
    //         if (searchCustomerById(idCustomerToReturn) == true)
    //         {
    //             tmp = this.HeadCustomer;
    //             while (count < getSize() && !(tmp.Customer.IdCustomer == idCustomerToReturn))
    //             {
    //                 tmp = tmp.Next;
    //             }
    //         }
    //     }
    //     return tmp;
    // }
}