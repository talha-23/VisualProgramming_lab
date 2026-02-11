using System;

class popsalon
{
    string customer_name;
    string mobile_number;
    string email;
    string flavor;
    string pack_size;
    string topping;
    string rating;

    int price = 0;
    int toppingprice = 0;
    int wrapperprice = 0;

    public popsalon()
    {
        Console.WriteLine("WELCOME TO POP SALON");
    }

    public void selectflavor()
    {
        Console.WriteLine("select flavor:");
        Console.WriteLine("1 chocolate");
        Console.WriteLine("2 english toffee");
        Console.WriteLine("3 salted caramel");
        Console.WriteLine("4 caramel");
        Console.WriteLine("5 jalapeno");
        Console.WriteLine("6 cheese");
        Console.WriteLine("7 spiced cheese");
        Console.WriteLine("8 plain salted");
        Console.WriteLine("9 buttered");
        Console.WriteLine("10 salt and pepper");
        Console.WriteLine("11 garlic");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1) flavor = "chocolate";
        else if (choice == 2) flavor = "english toffee";
        else if (choice == 3) flavor = "salted caramel";
        else if (choice == 4) flavor = "caramel";
        else if (choice == 5) flavor = "jalapeno";
        else if (choice == 6) flavor = "cheese";
        else if (choice == 7) flavor = "spiced cheese";
        else if (choice == 8) flavor = "plain salted";
        else if (choice == 9) flavor = "buttered";
        else if (choice == 10) flavor = "salt and pepper";
        else if (choice == 11) flavor = "garlic";
        else
        {
            Console.WriteLine("invalid input. Slect correct");
            selectflavor();
        }
    }

    public void selectsize()
    {
        Console.WriteLine("select pack size:");
        Console.WriteLine("1 small (Rs 100)");
        Console.WriteLine("2 medium (Rs 250)");
        Console.WriteLine("3 large (Rs 500)");
        Console.WriteLine("4 X-large (Rs 750)");

        int sizechoice = int.Parse(Console.ReadLine());

        if (sizechoice == 1)
        {
            pack_size = "small";
            price = 100;
        }
        else if (sizechoice == 2)
        {
            pack_size = "medium";
            price = 250;
        }
        else if (sizechoice == 3)
        {
            pack_size = "large";
            price = 500;
        }
        else if (sizechoice == 4)
        {
            pack_size = "large tin";
            price = 750;
        }
        else
        {
            Console.WriteLine("invalid input. Slect correct");
            selectsize();
        }
    }

    public void giftwrapper()
    {
        Console.WriteLine("do you want gift wrapper? (yes/no)");
        string wrap = Console.ReadLine();

        if (wrap == "yes")
        {
            wrapperprice = 50;
        }
    }

    public void additionaltopping()
    {
        Console.WriteLine("select extra topping:(1-4)");
        Console.WriteLine("1 chocolate sauce (50)");
        Console.WriteLine("2 caramel sauce (30)");
        Console.WriteLine("3 melted cheese (60)");
        Console.WriteLine("4 no topping");

        int topchoice = int.Parse(Console.ReadLine());

        if (topchoice == 1)
        {
            topping = "chocolate sauce";
            toppingprice = 50;
        }
        else if (topchoice == 2)
        {
            topping = "caramel sauce";
            toppingprice = 30;
        }
        else if (topchoice == 3)
        {
            topping = "melted cheese";
            toppingprice = 60;
        }
        else
        {
            topping = "no topping";
            toppingprice = 0;
        }
    }

    public void customerinfo()
    {
        Console.WriteLine("enter your name:");
        customer_name = Console.ReadLine();

        Console.WriteLine("enter mobile number:");
        mobile_number = Console.ReadLine();

        Console.WriteLine("enter email:");
        email = Console.ReadLine();

        Console.WriteLine("rate our service (good/neutral/bad):");
        rating = Console.ReadLine();
    }

    public void finalbill()
    {
        int total = price + toppingprice + wrapperprice;

        Console.WriteLine("\nFINAL BILL:");
        Console.WriteLine("customer: " + customer_name);
        Console.WriteLine("flavor: " + flavor);
        Console.WriteLine("pack size: " + pack_size);
        Console.WriteLine("base price: " + price);
        Console.WriteLine("topping: " + topping);
        Console.WriteLine("topping charges: " + toppingprice);
        Console.WriteLine("wrapper charges: " + wrapperprice);
        Console.WriteLine("total amount: " + total);
        Console.WriteLine("------------------------");
    }

    ~popsalon()
    {
        Console.WriteLine("thank you for visiting popsalon");
    }
}

class program
{
    static void Main(string[] args)
    {
        popsalon order = new popsalon();

        order.selectflavor();
        order.selectsize();
        order.giftwrapper();
        order.additionaltopping();
        order.customerinfo();
        order.finalbill();
    }
}
