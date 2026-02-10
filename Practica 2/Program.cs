using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esmeralda Soto 2024-1861

//Ejercicio 1: Clases y Objetos
public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Paginas: {Paginas}");
    }
}

//Ejercicio 2: Herencia
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

public class Estudiante : Persona
{
    public string Grado { get; set; }

    public void MostrarInformacionEstudiante()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Grado: {Grado}");
    }
}

//Ejercicio 3: Polimorfismo y Encapsulamiento

public class InstrumentoMusical
{
    public virtual void Tocar()
    {
        Console.WriteLine("El instrumento esta siendo tocado.");
    }
}

public class Guitarra : InstrumentoMusical
{
    public override void Tocar()
    {
        Console.WriteLine("La Guitarra esta sonando.");
    }
}

public class Piano : InstrumentoMusical
{
    public override void Tocar()
    {
        Console.WriteLine("El piano esta sonando.");
    }
}


public class Program
{
    public static void Main()
    {
        //Ejercicio 1
        Libro libro1 = new Libro();
        libro1.Titulo = "El Sutil Arte De Que Te Importe Un Carajo";
        libro1.Autor = "Mark Manson";
        libro1.Paginas = 230;
        libro1.MostrarInformacion();

        //Ejercicio 2
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Esmeralda";
        estudiante1.Edad = 20;
        estudiante1.Grado = "Desarrollo de Software";
        estudiante1.MostrarInformacionEstudiante();

        //Ejercicio 3
        List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();
        {
            instrumentos.Add(new Guitarra());
            instrumentos.Add(new Piano());
        }

        foreach (var instrumento in instrumentos)
        {
            instrumento.Tocar();
        }
    }
}


