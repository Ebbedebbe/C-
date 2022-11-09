using System.Security.Cryptography.X509Certificates;

class Person //Laver en over klasse/objekt
{
   public string Name = "ggdeeznuts"; //giver forskellige data til klassen som senere kan blive inherited
   public string Email = "gg@nutsies.com";
   public string Country = "Timor Leste";
   public int Age = 4;
    public Person() { } //der skal være en Person til de andre personer

   public Person(string name, string email, string country, int age) //laver en constructor så man nemt kan indsætte værdier
    {
        Name = name;
        Email = email;
        Country = country;
        Age = age;
    }

    public bool JoinTourney() //public means accessible for objects
    {
        return true;//funktionen skal ikke gøre noget i koden, så return er bare altid true.
    }

    public double Salary() //Anden funktion som heller ingen funktion i koden har
    {
        double vejgaarddollar = 50.5; // inflation
        Console.WriteLine(vejgaarddollar); 
        return vejgaarddollar; 
    }
}

class Lvl100MafiaBoss : Person //Objekt der inheriter Person værdier
{
    public void dialogue() //public funktion som gør noget unkt for Lvl100MafiaBoss
    {
        Console.WriteLine($"Lvl100MafiaBoss: ...  {Name}, {Email}, {Country}, {Age}");
    }
}

class Lvl1Crook : Person //Objekt der også inhertier Person
{
    public void dialogue() //public funktion som gør noget unkt for Lvl1Crook
    {
        Console.WriteLine("Lvl1Crook: Just use code Mafia2022 for 100.000 Silver!");
    }
}
class Program
{
    static void Main()//Static fordi funktionen kun tilhører classen Program, og andre objekter kan ikke access
        //Void fordi der ikke skal returnes noget
    {
        Lvl100MafiaBoss Boss = new Lvl100MafiaBoss();//Laver en local variable der hedder Boss og Crook henholdtsvis
        Lvl1Crook Crook = new Lvl1Crook();

        Person Test = new Person("Hugo", "Hugo@gmail.com", "Seychelles", 6); //indsætter værdier i constructr
        Console.WriteLine(Test.Name);

        Crook.dialogue();//polymorphism samme funktion gør forskellige ting
        Boss.dialogue();


    } 
}