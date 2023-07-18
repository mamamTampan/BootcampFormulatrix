public class Handphone<T>
{
    private T hp;

    public Handphone(T a)
    {
        hp = a;
    }

    public T HandphoneMethod(T tipe)
    {
        Console.WriteLine($"Handphone : {hp}");
        Console.WriteLine($"Tipe : {tipe}");

        return tipe;
    }
}