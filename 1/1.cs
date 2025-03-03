

namespace CE_1;

public static class Program
{
    public static void Main()
    {
        Person p1 = new Person("Armin", "1234567890");
        Person p2 = new Person("Ali", 20);
        Person p3 = new Person("Mohammad", 22);
        p1.PrintInfo();
        p2.PrintInfo();
        p3.PrintInfo();
    }
}

public class Person
{
    private string? phonenumber;

    public string name;
    public int? age;

    public Person(string name, string phonenumber)
    {
        this.name = name;
        this.phonenumber = phonenumber;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void PrintInfo()
    {
        if (!String.IsNullOrEmpty(name))
        {
            Console.Write($"name: {name}. ");
        }

        if (!String.IsNullOrEmpty(phonenumber))
        {
            Console.Write($"phonenumber: {phonenumber}");
        }

        if (age is not null)
        {
            Console.Write($"Age: {age}");
        }

        System.Console.WriteLine();
    }
}
