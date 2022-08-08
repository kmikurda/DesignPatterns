// See https://aka.ms/new-console-template for more information

using PrototypePattern;

Console.WriteLine("Prototype Pattern");

var person = new Person()
{
    Name = "Kamil",
    Age = 24,
    BirthDate = Convert.ToDateTime("1998-04-05"),
    Hobby = new Hobby("Kajakarstwo", 0)
};

var shallowClone = person.ShallowCopy();
var deepClone = person.DeepCopy();


DisplayPeople();

person.Name = "Franciszek";
person.Age = 123;

DisplayPeople();
Console.WriteLine("_________________");



void DisplayProps(Person person)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, BDay: {person.BirthDate}");
    Console.WriteLine($"Hobby Name: {person.Hobby.Name}, years: {person.Hobby.YearsOfExperience}");
}

void DisplayPeople()
{
    Console.WriteLine("Persone One:");
    DisplayProps(person);

    Console.WriteLine("Person Two");
    DisplayProps(shallowClone);

    Console.WriteLine("Person Three");
    DisplayProps(deepClone);
}