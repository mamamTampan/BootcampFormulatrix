namespace Singleton;

public class ClassA
{
    public void UseSingleton()
    {
        Singleton.Instance.PrintMessage("ClassA is using the Singleton.");
    }
}

public class ClassB
{
    public void UseSingleton()
    {
        Singleton.Instance.PrintMessage("ClassB is using the Singleton.");
    }
}

public class ClassC
{
    public void UseSingleton()
    {
        Singleton.Instance.PrintMessage("ClassC is using the Singleton.");
    }
}

public class ClassD
{
    public void UseSingleton()
    {
        Singleton.Instance.PrintMessage("ClassD is using the Singleton.");
    }
}

public class ClassE
{
    public void UseSingleton()
    {
        Singleton.Instance.PrintMessage("ClassE is using the Singleton.");
    }
}
