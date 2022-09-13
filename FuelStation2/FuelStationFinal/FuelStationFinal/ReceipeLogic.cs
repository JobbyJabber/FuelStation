namespace FuelStationFinal;

public class ReceipeLogic
{
    public ReceipeSelect finalReceipe;

    //Constructors
    public ReceipeLogic()
    {
        finalReceipe = null;
    }

    public ReceipeLogic(ReceipeSelect finalReceipe)
    {
        this.finalReceipe = finalReceipe;
    }

    //Getters and Setters
    public ReceipeSelect FinalReceipe
    {
        get { return finalReceipe; }
        set { finalReceipe = value; }
    }

    public void listInvoices()
    {
        if (!(finalReceipe == null))
        {
            ReceipeSelect tmp = finalReceipe;
            while (tmp != null)
            {
                tmp.Receipe.showInvoiceStatus();
                tmp = tmp.Next;
                Console.WriteLine("================================================================================");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("The invoices list is empty");
        }
    }

    public bool AddReceipe(Receipe productData)
    {
        if (productData == null)
        {
            return false;
        }

        if (finalReceipe == null)
        {
            finalReceipe = new ReceipeSelect();
            finalReceipe.Receipe = productData;
        }
        return false;
    }
}
        
    
