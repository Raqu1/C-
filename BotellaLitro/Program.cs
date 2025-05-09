using System;
public class BotellaLitro
{
    float Max_cont = 1f;
    float contenido = 0f;
    bool abierta = false;

    public void Abrir()
    {
        abierta = true;
        Console.WriteLine("Esta abierta");
    }

    public void Cerrar()
    {
        abierta = false;
        Console.WriteLine("Esta cerrada");

    }

    private bool EstaLlena()
    {
        bool llena = false;
        if (contenido >= Max_cont)
        {
            llena = true;
        }
        else
        {
            llena = false;
        }
        return llena;
    }

    private bool EstaVacia()
    {
        bool vacia = false;
        if (contenido < Max_cont)
        {
            vacia = true;
        }
        else
        {
            vacia = false;
        }
        return vacia;
    }

    public float Anadir(float liq)
    {
        if (!abierta)
            throw new Exception("La botella esta cerrada");
        float exceso = 0;
        contenido += liq;
        if (EstaLlena())   
        {
            exceso = contenido - Max_cont;
            contenido = Max_cont;
        }
        return exceso;
    }

    public float Quitar(float liq)
    {
        float extraido = liq;
        
        if (!abierta)
            throw new Exception("La botella esta cerrada");
        if (contenido < liq)   
        {
            extraido = contenido;
            contenido = 0;
        }
        else
        {
            contenido -= liq;
        }
        return extraido;
    }
}


class PruebaBotellaLitro
{
    public static void Main(string[] args)
    {
        BotellaLitro botella1 = new BotellaLitro();
        botella1.Abrir();
        float exceso = botella1.Anadir(1.5f);
        float extraido = botella1.Quitar(0.2f);
        Console.WriteLine(exceso);
        Console.WriteLine(extraido);
    }
}