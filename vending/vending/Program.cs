var vendingMachine = new VendingMachine();
vendingMachine.Items = new List<Item>()
{
new Item("COCA-COLA", 33),
new Item("FANTA", 33),
new Item("SPRITE", 33),
new Item("PRINGLES", 25),
new Item("LOLLIPOP", 10),
new Item("CHEWING-GUM", 10),
new Item("SNICKERS", 20),
new Item("MARABOU", 20),
new Item("REFRESHERS", 33),
new Item("POPCORN", 25),
new Item("M&M", 18),
new Item("DORRITOS", 25),
};

var options = "";
var total = 50;

Console.WriteLine("Welcome to Fantastic Vending Machine!!");

while (options == "")
{
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.Write("Type SEE, BUY NOW, VIEW CREDIT or LEAVE: ");

    options = Console.ReadLine();

    if (options == "SEE")
    {

        foreach (Item item in vendingMachine.Items)
        {
            Console.WriteLine(item.Name + " - " + item.Price + ":-");
        }

        Console.WriteLine();
        Console.Write("Type BUY NOW or LEAVE: ");
        options = Console.ReadLine(); 

        if (options == "LEAVE")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine(" :) WELCOME BACK :) ");
            Console.WriteLine("- - - - - - - - - - -");
            System.Threading.Thread.Sleep(2000);
            options = "";
            Console.Clear();
        }

        if (options == "BUY NOW")
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" :) TYPE THE NAME OF THE ITEM YOU WOULD LIKE :) ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");

            options = Console.ReadLine();


            foreach (Item item in vendingMachine.Items)
            {

                if (options == item.Name)
                {
                    if (total < item.Price)
                    {
                        Console.WriteLine("Stop being poor try again");
                        options = "";
                    }
                    else
                    {
                        total = total - item.Price;
                        Console.WriteLine(item.Name + " costs " + item.Price + " You have now " + total + " left ");
                        System.Threading.Thread.Sleep(2000);
                        options = "";
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("I'm sorry, that's not a valid item.");
            options = "";
        }

    }
    else if (options == "BUY NOW")
    {

        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine(" :) TYPE THE NAME OF THE ITEM YOU WOULD LIKE :) ");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");

        options = Console.ReadLine();

        foreach (Item item in vendingMachine.Items)
        {
           
            if(options == item.Name)
            {
                if (total < item.Price)
                {
                    Console.WriteLine("Stop being poor try again");
                    options = "";
                }
                else
                {
                    total = total - item.Price;
                    Console.WriteLine(item.Name + " costs " + item.Price + " You have now " + total + " left ");
                    System.Threading.Thread.Sleep(2000);
                    options = "";
                } 
            }
        }

    }
    else if (options == "LEAVE")
    {
        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - -");
        Console.WriteLine(" 🙂 WELCOME BACK 🙂 ");
        Console.WriteLine("- - - - - - - - - - -");
        System.Threading.Thread.Sleep(2000);
        options = "";
    }
    else if (options == "VIEW CREDIT")
    {
        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine($"Total: {total} SEK");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        System.Threading.Thread.Sleep(2000);
        options = "";

    }
    else
    {
        Console.WriteLine("I'm sorry, that's not a valid item.");
        options = "";
    }
}

