// See https://aka.ms/new-console-template for more information

using AbstractFactory;

Console.WriteLine("Hello, World!");

var ModernFactory = new ModernFurnitureFactory();
var ModerChair = ModernFactory.CreateChair();
var modernTable = ModernFactory.CreateTable();

var medievalFactory = new MedievalFurnitureFactory();
var medievalChair = medievalFactory.CreateChair();
var medievalTable = medievalFactory.CreateTable();

Console.WriteLine(ModerChair.getFurnitureUsage());
Console.WriteLine(modernTable.getFurnitureUsage());
Console.WriteLine(medievalChair.getFurnitureUsage());
Console.WriteLine(medievalTable.getFurnitureUsage());