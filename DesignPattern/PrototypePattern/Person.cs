namespace PrototypePattern;

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public Hobby Hobby { get; set; }

    public Person ShallowCopy()
    {
        return (Person) this.MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person) this.MemberwiseClone();
        clone.Name = string.Copy(Name);
        clone.Hobby = new Hobby(Hobby.Name, Hobby.YearsOfExperience);
        return clone;
    }
}

public class Hobby
{
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }

    public Hobby(string name, int years)
    {
        this.Name = name;
        this.YearsOfExperience = years;
    }
}