using System.Security.Cryptography.X509Certificates;

class Person
{
    string Name = "ggdeeznuts";
    string Email = "gg@nutsies.com";
    string Country = "Timor Leste";
    int Age = 4;
   

    public bool JoinTourney()
    {
        return true;
    }

    public double Salary()
    {
        double vejgaarddollar = 50.5; // inflation
        Console.WriteLine(vejgaarddollar);
        return vejgaarddollar;
    }
}

class Lvl100MafiaBoss : Person
{
    public void dialogue()
    {
        Console.WriteLine("Lvl100MafiaBoss: ...");
    }
}

class Lvl1Crook : Person
{
    public void dialogue()
    {
        Console.WriteLine("Lvl1Crook: Just use code Mafia2022 for 100.000 Silver!");
    }
}


class Program
{
    static void Main()
    {
        Person Lvl100MafiaBoss = new Person();

        Lvl100MafiaBoss Boss = new Lvl100MafiaBoss();

        Lvl1Crook Crook = new Lvl1Crook();

        Crook.dialogue();
        Boss.dialogue();
    }
}