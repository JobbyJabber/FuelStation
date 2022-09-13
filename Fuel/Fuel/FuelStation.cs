namespace Fuel;

public class Run
{
    private decimal g95Price;
    private decimal g98Price;
    private decimal dieselPrice;
    private decimal bigCoffeePrice;
    private decimal smallCoffeePrice;
    private decimal cookiePrice;

    public void SetPrices()
    {
        Console.WriteLine("Please provide price for Gasoline95: ");
        g95Price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please provide price for Gasoline98: ");
        g98Price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please provide price for Diesel: ");
        dieselPrice = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please provide price for Big Coffee: ");
        bigCoffeePrice = decimal.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please provide price for Small Coffee: ");
        // decimal smallCoffeePrice = decimal.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please provide price for Cookie: ");
        // decimal cookiePrice = decimal.Parse(Console.ReadLine());
    }

    public void ShowPrices()
    {
        var g95 = new Product { ItemName = "Gasoline95", Price = g95Price };
        var g98 = new Product { ItemName = "Gasoline98", Price = g98Price };
        var diesel = new Product { ItemName = "Diesel", Price = dieselPrice };
        var bigCoffee = new Product { ItemName = "Big Coffee", Price = bigCoffeePrice };
        // Products smallCoffee = new Products { ItemName = "Small Coffee", Price = smallCoffeePrice };
        // Products cookie = new Products { ItemName = "Cookie", Price = cookiePrice};
        //
        Console.WriteLine($"{g95.ItemName}: {g95.Price}zł");
        Console.WriteLine($"{g98.ItemName}: {g98.Price}zł");
        Console.WriteLine($"{diesel.ItemName}: {diesel.Price}zł");
        Console.WriteLine($"{bigCoffee.ItemName}, {bigCoffee.Price}");
        Console.WriteLine($"Chuj{g95Price}");
        // Console.WriteLine($"{smallCoffee.ItemName}, {smallCoffee.Price}");
        // Console.WriteLine($"{cookie.ItemName}, {cookie.Price}");
    }



    public void SellItems()
    {
        Menu sub = new Menu();
        bool exit = true;
        decimal finalPrice = 0;
        decimal quantity = 0;
        // string plate;
        // string receipeID;
        //
        // plate = Console.ReadLine();
        // receipeID = Console.ReadLine();
        

        
        
        while(exit)
        {
            Console.WriteLine("Please Provide drivers plate: ");
            string plate = Console.ReadLine();
            Console.WriteLine("Please Provide Receipe ID: ");
            string receipeID = Console.ReadLine();

            sub.SubMenu();

            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                {
                    
                    Console.WriteLine("How much?");
                    quantity = decimal.Parse(Console.ReadLine());
                    
                    var prc = quantity * g95Price;
                    finalPrice = finalPrice + prc;

                    Console.WriteLine("Anything else?");
                    var more = Console.ReadLine();

                     // c.ShoppingList[0] = $"Gasoline 95 for {g95Price} per liter.";
                     //
                     // Console.WriteLine($" lista zakupów: {c.ShoppingList[0]}");

                    if (more == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Your total price: {finalPrice}");
                        goto default;
                    }

                }
                case 2:
                {
                    Console.WriteLine("How much?");
                    quantity = decimal.Parse(Console.ReadLine());
                    
                    var prc = quantity * g98Price;
                    finalPrice = finalPrice + prc;
                    Console.WriteLine("Anything else?");
                    var more = Console.ReadLine();

                    if (more == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Your total price: {finalPrice}");
                        goto default;
                    }
                }
                case 0:
                    Console.WriteLine("Mózg dead");
                    sub.SubMenu();
                    break;
                default:
                    sub.DrawMenu();
                    exit = false;
                    break;
            }
        }
    }
}




// if (more == "y")
// {
//     Console.Write("What else?");
//     Console.WriteLine("1. BigCofee");
//     Console.WriteLine("2 - SmallCoffee");
//     Console.WriteLine("3 - Cookie");
//
//     var subOption = int.Parse(Console.ReadLine());
//     quanity = int.Parse(Console.ReadLine());
//
//     if (subOption == 1)
//     {
//         prc = quanity * bigCoffeePrice;
//         finalPrice = finalPrice + prc;
//         Console.WriteLine($"Total Order Price: {finalPrice}");
//     }