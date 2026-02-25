using System;

abstract class human
{
    private int age;
    public void set(int age)
    {
        this.age = age;
    }
    public int getAge()
    {
        return age;
    }
    //implementation for poly morphism
    public virtual void role()
    {
        Console.WriteLine("i have not being assigined any role till now:(");
    }
    // implementation ofr abstract class
    public abstract void DOB();
}

class student : human
{
    private string name;
    public void setname(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return name;
    }

    //implementation for poly morphism
    public override void role()
    {
        Console.WriteLine("I am a student:)");
    }

    // implementation ofr abstract class
    public override void DOB()
    {
        Console.WriteLine("my Doate of Birth is 4 October");
    }
}

class teacher : human
{
    public string name;
    public void setname(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return name;
    }

    //implementation for poly morphism
    public override void role()
    {
        Console.WriteLine("I am a teacher:)");
    }

    // implementation ofr abstract class
    public override void DOB()
    {
        Console.WriteLine("my Doate of Birth is 23 March");
    }
}

class sweeper : human
{
    public string name;
    public void setname(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return name;
    }

    //implementation for poly morphism
    public override void role()
    {
        base.role();
        //Console.WriteLine("I am a Sweeper:)");
    }


    // implementation ofr abstract class
    public override void DOB()
    {
        Console.WriteLine("my Doate of Birth is 1 januray");
    }
}

//==========================INTERFACE========================
interface iAnimals
{
    string name { get; set; }
    int limbs { get; set; }
}

class Elephant : iAnimals
{
    public string name { get; set; }
    public int limbs { get; set; }
    public void sound()
    {
        Console.WriteLine("ELEPHANT :RUMBLES");
    }
}

class Loin : iAnimals
{
    public string name { get; set; }
    public int limbs { get; set; }

    public void sound()
    {
        Console.WriteLine("lOIN :ROARS");
    }
}

class program
{
    static void Main()
    {
        student s = new student();
        teacher t = new teacher();
        sweeper sw = new sweeper();
        Console.WriteLine("===DEALING with STUDENTS===");
        s.set(20);//inheritance
        s.setname("talha");
        Console.WriteLine("the name of student is: " + s.getName() + " and his age is: " + s.getAge());
        s.role();//polymorphism
        s.DOB(); //abstraction - object of child but refrence of base class
        Console.WriteLine("\n");

        //=========================================================================================================
        Console.WriteLine("===DEALING with TEACHER===");
        t.set(22);
        t.setname("Taimur Jutt");
        Console.WriteLine("the name of teacher is: " + t.getName() + " and his age is: " + t.getAge());
        t.role();
        t.DOB();
        Console.WriteLine("\n");

        //===========================================================================================================
        Console.WriteLine("===DEALING with SWEEPER===");
        sw.set(47);
        sw.setname("Chacha Nazakat");
        Console.WriteLine("the name of Sweeper is: " + sw.getName() + " and his age is: " + sw.getAge());
        sw.role();
        sw.DOB();
        Console.WriteLine("\n");

        //=================================INTERFACE=====================================
        Console.WriteLine("\n");
        Console.WriteLine("======INTERFACE======");
        Console.WriteLine("\n");
        Elephant e = new Elephant();
        e.name = "Dumbo";
        e.limbs = 4;
        Console.WriteLine("Name: " + e.name);
        Console.WriteLine("Limbs: " + e.limbs);
        e.sound();

        Loin l = new Loin();
        l.name = "Simba";
        l.limbs = 4;
        Console.WriteLine("Name: " + l.name);
        Console.WriteLine("Limbs: " + l.limbs);
        l.sound();


    }
}
