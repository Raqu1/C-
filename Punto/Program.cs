public class Program
{
    public static void Main(string[] args)
    {
        Punto p = new Punto();
        Punto q = new Punto(-14, 11);
        p.x = 11;
        p.y = 8;
        // q.x = 14;
        // q.y = 11;
        Console.WriteLine($"p = {p}");
        Console.WriteLine($"q = {q}");
        Console.WriteLine($"dist({p},{q}) = {p.Distancia(q):f2}");
        p.Mostrar('*');
        q.Mostrar('x');
    }
}
