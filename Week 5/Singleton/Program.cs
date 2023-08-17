namespace Singleton;
class Program
{
    static void Main()
    {
        ClassA classA = new ClassA();
        ClassB classB = new ClassB();
        ClassC classC = new ClassC();
        ClassD classD = new ClassD();
        ClassE classE = new ClassE();

        classA.UseSingleton();
        classB.UseSingleton();
        classC.UseSingleton();
        classD.UseSingleton();
        classE.UseSingleton();
    }
}
