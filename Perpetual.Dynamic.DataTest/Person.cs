
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<Person> ListOFPerson { get; set; } = new List<Person>();


    public void NameAge(string name, int age)
    {
        Name= name;
        Age= age;
    }
}

