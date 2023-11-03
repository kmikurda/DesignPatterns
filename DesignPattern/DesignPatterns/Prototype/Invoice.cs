namespace Prototype;

public class Invoice
{
    public int Id;
    public string Name;
    public DateTime Date;
    public Creator Creator;

    public Invoice ShallowCopy()
    {
        return (Invoice) this.MemberwiseClone();
    }

    public Invoice DeepCopy()
    {
        Invoice clone = ShallowCopy();
        clone.Creator = new Creator();
        clone.Name = string.Copy(Name);
        return clone;
    }
}

public class Creator
{
    public string name;

    public Creator()
    {
        name = "asd";
    }
}