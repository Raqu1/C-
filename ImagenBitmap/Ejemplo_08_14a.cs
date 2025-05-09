// Ejemplo_08_14a.cs // Información de un fichero BMP, con BinaryReader // Introducción a C#, por Nacho Cabanes
using System;
using System.IO;
public class Ejemplo_08_14a {
    public static void Main() {
        Console.WriteLine("Información de imágenes BMP"); 
        Console.WriteLine("Dime el nombre del fichero: "); 
        string nombre = "flores.bmp"; 
        if (!File.Exists(nombre)) {
            Console.WriteLine("No encontrado!"); 
        } else {
            BinaryReader fichero = new BinaryReader(File.Open(nombre, FileMode.Open));
            // Leo los dos primeros bytes 
            char marca1 = Convert.ToChar(fichero.ReadByte());
            char marca2 = Convert.ToChar(fichero.ReadByte());
            if ((marca1 != 'B') || (marca2 != 'M'))
                Console.WriteLine("No parece un fichero BMP");
            else {
                Console.WriteLine("Marca del fichero: {0}{1}", marca1, marca2);

            // Posición 18: ancho 
            fichero.BaseStream.Seek(18, SeekOrigin.Begin);
            int ancho = fichero.ReadInt32();
            Console.WriteLine("Ancho: {0}", ancho);

            // A continuación: alto 
            int alto = fichero.ReadInt32(); Console.WriteLine("Alto: {0}", alto);

            // Posición 30: compresión 
            fichero.BaseStream.Seek(30, SeekOrigin.Begin);
            int compresion = fichero.ReadInt32();
            switch (compresion) {
                case 0: Console.WriteLine("Sin compresión");
                        break;
                case 1: Console.WriteLine("Compresión RLE 8 bits");
                        break;
                case 2: Console.WriteLine("Compresión RLE 4 bits");
                        break;
            }

            // 4 bytes después: resolución horizontal 
            fichero.BaseStream.Seek(4, SeekOrigin.Current);
            int resolH = fichero.ReadInt32();
            Console.WriteLine("Resolución Horiz.: {0}", resolH);

            // A continuación: resolución vertical 
            int resolV = fichero.ReadInt32();
            Console.WriteLine("Resolución Vertical: {0}", resolV); fichero.Close();
            }
        }
    }
}