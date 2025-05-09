using System;
public class Program
{
    public static void Main()
    {
        Fecha fecha1 = new Fecha();
        fecha1.Incrementar(120);
        Console.WriteLine(fecha1);

    /*  
        Fecha fecha2 = new Fecha(30,2,2004);
        fecha2.Incrementar();
        Console.WriteLine(fecha2);
    */
    /*  
        Console.WriteLine(fecha1.Equals(fecha2));
        Console.WriteLine(fecha1.CompareTo(fecha2)); 
    */
    }
}

public class Fecha
{
    private int Dia;
    private int Mes;
    private int Anio;

    public Fecha()
    {
        this.Dia = 1;
        this.Mes = 1;
        this.Anio = 1970;
    }

    public Fecha(int dia, int mes, int anio) : this()
    {
        if (!FechaValida(dia, mes, anio))
            throw new ArgumentException("Fecha inválida");

        this.Dia = dia;
        this.Mes = mes;
        this.Anio = anio;
    }

    private static bool FechaValida(int dia, int mes, int anio)
    {
        return (mes >= 1 && mes <= 12 && dia >= 1 && anio >= 1 && dia <= DiasDelMes(mes, anio));
    }

    public void Incrementar()
    {
        Dia++;
        if (Dia > DiasDelMes(Mes, Anio))
        {
            Dia = 1;
            Mes++;
            if (Mes > 12)
            {
                Mes = 1;
                Anio++;
            }
        }
    }

    public void Incrementar(int i)
    {
        for (int j = 0; j < i; j++)
        {
            Incrementar();
        }
    }

    private static bool esBisiesto(int anio)
    {
        return (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0));
    }

    private static int DiasDelMes(int mes, int anio)
    {
        switch (mes)
        {
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                return esBisiesto(anio) ? 29 : 28;
            default:
                return 31;
        }
    }

    public override string ToString()
    {
        string[] abrevMes = { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };

        return $"{Dia:D2}-{abrevMes[Mes - 1]}-{Anio % 100:D2}";
    }

    public override bool Equals(object f)
    {
        if (f == null || GetType() != f.GetType())
            return false;
        Fecha otraFecha = (Fecha)f;
        return (this.Dia == otraFecha.Dia && this.Mes == otraFecha.Mes && this.Anio == otraFecha.Anio);
    }

    public override int GetHashCode()
    {
        /* return HashCode.Combine(Dia, Mes, Anio); */
        return (Dia, Mes, Anio).GetHashCode();
    }

    public int CompareTo(object f)
    {
        Fecha otraFecha = (Fecha)f;
        if (this.Anio < otraFecha.Anio) return -1;
        if (this.Anio > otraFecha.Anio) return 1;
        if (this.Mes < otraFecha.Mes) return -1;
        if (this.Mes > otraFecha.Mes) return 1;
        if (this.Dia < otraFecha.Dia) return -1;
        if (this.Dia > otraFecha.Dia) return 1;
        return 0;
    }
}