public class Persona
{
    public string dni {get;}
    public int edad {get;}
    public string nombre {get;}

    public Persona(int edad, long nDni, char lDni)
    {
        this.edad = edad;
    }
    public Persona(string nombre, int edad, long nDni, char lDni) : this(edad, nDni, lDni)
    {
        this.nombre = nombre;
    }

    public override string ToString()
    {

    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        

        throw new System.NotImplementedException();
        return base.Equals (obj);
    }
    
    public override int GetHashCode()
    {
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }
}

public class Estudiante : Persona, IComparable<Estudiante>
{
    public Estudiante(int edad, long nDni, char lDni)
    {

    }
    public Estudiante(string nombre, int edad, long nDni, char lDni) : this(edad, nDni, lDni)
    {

    }

    public void Calificar(string asignatura, float nota)
    {

    }

    public float NotaMedia()
    {

    }

    public int CompareTo(Estudiante otro)    
    {
        if (otro == null) return 1;
        return dni.CompareTo(otro.dni);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

public class DNI 
{
    public char lDni {get;}
    public long nDni {get;}

    public DNI(long num, char letra)
    {

    }

    private char LetraValida(long n)
    {

    }

    // override object.Equals
    public override bool Equals(object obj)
    {        
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        throw new System.NotImplementedException();
        return base.Equals (obj);
    }
    
    public override int GetHashCode()
    {
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }

    public override string ToString()
    {

    }
}

public class Calificacion
{
    public string asignatura {get;}
    public float nota {get;}

    public Calificacion(string _asignatura, float _nota)
    {

    }

    public override string ToString()
    {
        
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Persona persona1 = new Persona(13, 42243076, 'b');
        Persona persona2 = new Persona(13, 42243076, 'b');
        persona1.Equals(persona2);
    }
}