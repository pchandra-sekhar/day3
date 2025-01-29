
class person
{
    public string name=Console.ReadLine();

    public void Display()
    {
        Console.WriteLine($"Hello my name is {name}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        person p=new person();

       // p.name = "Chandrasekhar";
        p.Display();


    }
}