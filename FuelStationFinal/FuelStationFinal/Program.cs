using FuelStationFinal;

CustomerLogic customerList = new CustomerLogic();
// ProductLogic articleList = new ProductLogic();
// ReceipeLogic receipeList = new ReceipeLogic();

Console.WriteLine("Set todays price for Gasoline 95: ");
decimal g95Price = Decimal.Parse(Console.ReadLine()); 
Product g95 = new Product("Gasoline 95", g95Price);

Console.WriteLine("Set todays price for Gasoline 98: ");
decimal g98Price = Decimal.Parse(Console.ReadLine());
Product g98 = new Product("Gasoline 98", g98Price);

Console.WriteLine("Set todays price for Diesel: ");
decimal dieselPrice = Decimal.Parse(Console.ReadLine());
Product diesel = new Product("Diesel", dieselPrice);

ProductLogic p = new ProductLogic();
p.addProduct(g95);
p.addProduct(g98);

int value = -1;

while (value != 0)
{
    Console.WriteLine("1 - List products.");
    Console.WriteLine("2 - List receipes.");
    Console.WriteLine("3 - Add new receipe ");
    Console.WriteLine("0 - EXIT");
    Console.WriteLine("Please select an option:");
    value = Convert.ToInt32(Console.ReadLine());
    switch (value)
    {
        case 1:
            Console.WriteLine($"Test1: {g95.Price}, {g95.NameItem}" +
                              $"Test2: {g98.Price}, {g98.NameItem}" +
                              $"Test3: {diesel.Price}, {diesel.NameItem}");
            break;
        case 2:
            ReceipeLogic r = new ReceipeLogic();
            r.listInvoices();
            break;
        case 3: 
            Receipe receipe = LoadReceipe();
            ReceipeLogic rl = new ReceipeLogic();
            rl.AddReceipe(receipe);
            break;
    }

    Console.Write("Press any key to continue . . .");
    Console.ReadKey();
    Console.Clear();
}

Receipe LoadReceipe()
{
    Console.WriteLine("Enter the details of the new Receipe");
    Console.WriteLine("Receipe ID:");
    int id = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Customer Plates:");
    int plate = Int32.Parse(Console.ReadLine());
    
    Customer customer = new Customer(plate);
    customerList.addCustomer(customer);
    Console.WriteLine($"Customer with plate number: {customer.CustomerPlate} receipe!");
    ProductLogic listItems = new ProductLogic();
    int num = 1;
    int i = -1;
    while (i != 0)
    {
        Console.WriteLine("Enter the ID of the article you want to add:");
        Console.WriteLine("1 - gasoline");
        Console.WriteLine("2 - gasoline98");
        Console.WriteLine("3 - diesel");
        int choice = Int32.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("How much do you want?");
            g95.quantity = Decimal.Parse(Console.ReadLine());
            g95.TotalPrice = g95.quantity * g95.Price;
            listItems.addProduct(g95);
        }
        else if (choice == 2)
        {
            Console.WriteLine("How much do you want?");
            g98.quantity = Decimal.Parse(Console.ReadLine());
            g98.TotalPrice = g98.quantity * g98.Price;
            listItems.addProduct(g98);
        }
        else if (choice == 3)
        {
            Console.WriteLine("How much do you want?");
            diesel.quantity = Decimal.Parse(Console.ReadLine());
            diesel.TotalPrice = diesel.quantity * diesel.Price;
            listItems.addProduct(diesel);
        }
        
        Console.WriteLine("You want to add another item to the receipe:");
        Console.WriteLine("1- yes");
        Console.WriteLine("0- no");
        Console.WriteLine("Please select an option:");
        i = Int32.Parse(Console.ReadLine());
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    decimal receipeValue = listItems.totalValue();
    Receipe receipe = new Receipe(id, listItems, receipeValue);
    
    Console.WriteLine($"{receipe.IdReceipe}, {receipe.Customer}, {receipe.ListaItems}, {receipeValue} ");
    return receipe;
}



