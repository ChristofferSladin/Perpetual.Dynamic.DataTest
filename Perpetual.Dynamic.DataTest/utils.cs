


class utils
{
    

    public void Add()
    {
        Console.WriteLine("Ange namn:");
        var name = Console.ReadLine();
        Console.WriteLine("ange age");
        var age = int.Parse(Console.ReadLine());

        var p = new Person();

        p.NameAge(name, age);

        p.ListOFPerson.Add(p);

    }

    public void ShowPersons()
    {
        var p = new Person();

        foreach (var person in p.ListOFPerson)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }

    }

}



