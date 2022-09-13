namespace FuelStationFinal;

public class ReceipeSelect
{
    private Receipe receipe;
    private ReceipeSelect next;

    //Constructores
    public ReceipeSelect()
    {
        receipe = new Receipe();
        next = null;
    }
    public ReceipeSelect(Receipe receipe)
    {
        this.receipe = receipe;
    }

    //Getters and Setters
    public Receipe Receipe
    {
        get { return receipe; }
        set { receipe = value; }
    }
    public ReceipeSelect Next
    {
        get { return next; }
        set { next = value; }
    }
}