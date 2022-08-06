// See https://aka.ms/new-console-template for more information

using DesignPattern;

Console.WriteLine("Builder Design Pattern");

var carDirector = new CarDirector();
var sportCar = new SportCarBuilder();
var familyCar = new FamilyCarBuilder();

var car = carDirector.MakeCar(sportCar);
car.DisplayParameters();

car = carDirector.MakeCar(familyCar);
car.DisplayParameters();

Console.ReadKey();
