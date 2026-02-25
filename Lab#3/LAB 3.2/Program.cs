using System;

////parent class
//class Rectangle
//{
//    private double length;
//    private double width;

//    public void set(double length, double width)
//    {
//        this.length = length;
//        this.width = width;
//    }

//    public double getLength() { return length; }
//    public double getWidth() { return width; }

//    public double recArea() { return length * width; }
//}

//class Cuboid : Rectangle
//{
//    private double height;
//    public void setHeight(double height){this.height = height;}
//    public double cuboidArea() { return getLength() * getWidth() * height; }
//}
//class program
//{
//    static void Main(string[] args)
//    {
//        Cuboid c=new Cuboid();
//        Console.WriteLine("Inheritance relationship between Rectangle and Cuboid:\n");
//        c.set(32.8, 10.2);
//        c.setHeight(8.4);
//        Console.WriteLine("The area of rectangel is :" + Math.Round(c.recArea(),3) + "\n");
//        Console.WriteLine("The area of Couboid is :" + Math.Round(c.cuboidArea(),2) + "\n");


//    }
//}





//class GraduateCourse
//{
//    string courseID;
//    string courseName;
//    int creditHours;
//    int courseFee;

//    public GraduateCourse(string courseID, string courseName, int creditHours, int courseFee)
//    {
//        this.courseID = courseID;
//        this.courseName = courseName;
//        this.creditHours = creditHours;
//        this.courseFee = courseFee;
//    }
//    protected void display()
//    {
//        Console.WriteLine("the course id :" + courseID + "\nhaving name: "
//            + courseName + "\nhas creadit id: " + creditHours + "\nhas corse fee: " + courseFee);
//    }
//}

//class ResearchCourse : GraduateCourse
//{
//    decimal experimentFee;
//    public ResearchCourse(string courseID, string courseName, int creditHours, int courseFee,
//        decimal experimentFee)
//        : base(courseID, courseName, creditHours, courseFee)
//    {
//        this.experimentFee = experimentFee;
//    }

//    public void setExperimentFee(Decimal experimentFee) { this.experimentFee = experimentFee; }
//    public void Alldisplay()
//    {
//        base.display();

//        Console.WriteLine("the experimental fee for Research Course is: " + experimentFee);
//    }
//}
//class program
//{
//    static void Main(string[] args)
//    {
//        ResearchCourse r = new ResearchCourse("CS2133", "VP", 1, 10000, 3200);
//        r.Alldisplay();
//        Console.WriteLine("\n");
//        r.setExperimentFee(3500);
//        r.Alldisplay();
//    }
//}

//class Animal
//{
//    public virtual void eat(string food)
//    {
//        Console.WriteLine("animal is eating " + food);
//    }
//}
//class herbivore : Animal
//{
//    public override void eat(string food)
//    {
//        Console.WriteLine("herbivore prefers to eat plants: " + food);
//    }
//}
//class carnivore : Animal
//{
//    public override void eat(string food)
//    {
//        Console.WriteLine("carnivore prefers to eat meat: " + food);
//    }
//}
//class omnivore : Animal
//{
//    public override void eat(string food)
//    {
//        Console.WriteLine("omnivore can eat both plants and meat: " + food);
//    }
//}
//class program
//{
//    static void Main()
//    {
//        herbivore h = new herbivore();
//        carnivore c = new carnivore();
//        omnivore o = new omnivore();

//        h.eat("grass");
//        c.eat("meat");
//        o.eat("fruits and meat");
//    }
//}




abstract class Vehicle
{
    protected double speed;
    public Vehicle(double s)
    {
        speed = s;
    }

    public abstract void move();
    public void displayspeed()
    {
        Console.WriteLine("current speed: " + speed + " km/h");
    }
}
interface ifuelefficiency
{
    double calculatefuelefficiency();
}
class car : Vehicle, ifuelefficiency
{
    private double mileage;
    public car(double s, double m) : base(s)
    {
        mileage = m;
    }

    public override void move()
    {
        Console.WriteLine("car is moving on the road.");
    }

    public double calculatefuelefficiency()
    {
        return mileage;
    }
}

class boat : Vehicle, ifuelefficiency
{
    private double fuelconsumption;

    public boat(double s, double fc) : base(s)
    {
        fuelconsumption = fc;
    }
    public override void move()
    {
        Console.WriteLine("boat is sailing in water.");
    }

    public double calculatefuelefficiency()
    {
        return 100 / fuelconsumption;
    }
}
class program
{
    static void Main()
    {
        car c = new car(120, 15);
        boat b = new boat(40, 8);

        Console.WriteLine("--- Car ---");
        c.move();
        c.displayspeed();
        Console.WriteLine("fuel efficiency: " + c.calculatefuelefficiency() + " km/l");

        Console.WriteLine("\n--- Boat ---");
        b.move();
        b.displayspeed();
        Console.WriteLine("fuel efficiency: " + b.calculatefuelefficiency() + " km/l");
        Console.WriteLine("fuel efficiency: " + b.calculatefuelefficiency() + " km/l");
    }
}


