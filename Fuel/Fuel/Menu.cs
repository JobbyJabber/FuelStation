namespace Fuel;

public class Menu
{
    private bool exit = true;
    public Run run = new Run();
    public void DrawMenu()
    {
        Console.WriteLine("________PETROL STATION________");
        Console.WriteLine("1 - Sell Items");
        Console.WriteLine("2 - Show History");
        Console.WriteLine("3 - Show Prices");
        Console.WriteLine("4 - Exit");
        Console.WriteLine("______________________________");
    }

    public void UseMenu(){
        
        run.SetPrices();

        while (exit)
        {
            Console.Write("Choose option number: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                SubMenu();

            }
            else if (option == 2)
            {
                run.SellItems();
            
            }
            else if (option == 3)
            {
                run.ShowPrices();
            }
            else if (option == 4)
            {
                exit = false;
            }
            else
            {
                Console.WriteLine("Entered wrong number.");
            }
        }


    }
    public void SubMenu()
    {


        Console.WriteLine("Choose product: ");
        Console.WriteLine("1 - gas95 ");
        Console.WriteLine("2 - gas98 ");
        Console.WriteLine("3 - diesel ");
        Console.WriteLine("4 - big coffee");
        // Console.WriteLine("5 - gas98 ");
        // Console.WriteLine("6 - gas98 ");
        
    }
}