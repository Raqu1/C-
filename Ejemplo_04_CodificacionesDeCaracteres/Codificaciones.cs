// Referencia:
// https://es.stackoverflow.com/questions/608211/problema-de-codificaci%C3%B3n-en-aplicaci%C3%B3n-de-consola-de-c-no-se-muestran-caracte

using System.Text;

public class Codificaciones
{
    public static void Main()
    {
        EncodingDeConsola();
        //ConversionDeEncoding();
    }
    private static void EncodingDeConsola(){
        //Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.ASCII;
        //Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.ASCII;

        Console.WriteLine("¿Cuál es tu nombre?");
        string nombre = Console.ReadLine();
        //if(nombre == "ñ")
            Console.WriteLine($"Hola {nombre}!");
        Console.InputEncoding = System.Text.Encoding.Default;
        Console.OutputEncoding = System.Text.Encoding.Default;
    }







    private static void ConversionDeEncoding(){
        Console.WriteLine("¿Cuál es tu nombre?");
        string nombre = Console.ReadLine();

        byte[] bytes = Encoding.Default.GetBytes(nombre);
        nombre = Encoding.UTF8.GetString(bytes);

        Console.WriteLine($"Hola {nombre}!");
    }
}