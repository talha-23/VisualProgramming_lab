using System;

class car
{
    private int model_year;
    private string name;
    private double price;

    public void set_data()
    {
        Console.WriteLine("Enter the name of car: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter the model year of car: ");
        model_year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price of the car: ");
        price = double.Parse(Console.ReadLine());
    }

    public int get_model_year() { return model_year; }
    public string getName() { return name; }
    public double get_price() { return price; }

    public void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Model Year: " + model_year);
        Console.WriteLine("Price: " + price);
    }
}
class program
{

    static void Main(string[] args)
    {
        car c = new car();
        c.set_data();
        Console.WriteLine("Displaying via getters");
        Console.WriteLine("name: " + c.getName());
        Console.WriteLine("model year: " + c.get_model_year());
        Console.WriteLine("price: " + c.get_price());
        Console.WriteLine("Displaying via function: ");
        c.display();

    }
}
