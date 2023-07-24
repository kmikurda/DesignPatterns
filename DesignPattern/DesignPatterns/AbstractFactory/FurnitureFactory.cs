namespace AbstractFactory;

public interface IFurnitureFactory
{
    public IChair CreateChair();
    public ITable CreateTable();
}

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}

public class MedievalFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new MedievalChair();
    }

    public ITable CreateTable()
    {
        return new MedievalTable();
    }
}

public interface IChair
{
    string getFurnitureUsage();
}

public interface ITable
{
    string getFurnitureUsage();
}

public class ModernChair: IChair
{
    public string getFurnitureUsage()
    {
        return "For Modern Sitting";
    }
}

public class MedievalChair : IChair
{
    public string getFurnitureUsage()
    {
        return "For Medieval sitting";
    }
}

public class ModernTable : ITable
{
    public string getFurnitureUsage()
    {
        return "For Modern Eating";
    }
}

public class MedievalTable : ITable
{
    public string getFurnitureUsage()
    {
        return "For Medieval Eating";
    }
}



