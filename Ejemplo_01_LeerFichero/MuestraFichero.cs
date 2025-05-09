using System;
using System.IO;
// Para StreamReader 
public class MuestraFichero {
    private const string NFICH = "texto.txt"; 
    public static void Main() {
        StreamReader? sr;
        string? nFich;
        string? linea;

        sr = new StreamReader(new FileStream(NFICH,FileMode.Open)); 
        linea = sr.ReadLine();
        while(linea != null) {
            Console.WriteLine(linea);
            linea = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine("************************************");
    }
}