using System;

class AndDevice
{
    private long IMEINo;
    private string Type;
    private string Make;
    private string ModelNo;
    private double Memory;
    private string OperatingSystem;

    public void set_values(long IMEINo, string Type, string Make,
        string ModelNO,
        double Memory,
        string OperatingSystem)
    {

        this.IMEINo = IMEINo;
        this.Type = Type;
        this.Make = Make;
        this.ModelNo = ModelNo;
        this.Memory = Memory;
        this.OperatingSystem = OperatingSystem;

    }
    public void display()
    {
        Console.WriteLine("IMEI Number: "+ IMEINo);
        Console.WriteLine("Type: "+ Type);
        Console.WriteLine("Make: "+ Make);
        Console.WriteLine("ModelNo: "+ ModelNo);
        Console.WriteLine("Memory: "+ Memory);
        Console.WriteLine("OperatingSystem: "+ OperatingSystem);
    }
}
class program
{
    static void Main(String[] args)
    {
        AndDevice phone= new AndDevice();
        phone.set_values(12345678901234,"Tablet","Chuwi","V8 HD",860.50,"Android Icream");
        Console.WriteLine("OUTPUT: ");
        phone.display();

    }
}