namespace Visitor;

public interface IVisitor
{
    void VisitConcreteComponentA(Concrete Component)
}

public class ConcreteVisitor1: IVisitor