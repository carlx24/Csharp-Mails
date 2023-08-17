
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// See https://aka.ms/new-console-template for more information

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona(1 , "Pedro", "pedro@mail.cl"),
                new Persona(2 , "Juan", "juan@mail.cl"),
                new Persona(3 , "Jorge", "jorge@mail.cl"),
                new Persona(4 , "Diego", "diego@mail.cl")
            };

            Console.WriteLine("Seleccione una opción para continuar:");
            Console.WriteLine("1) Enviar correo a una persona");
            Console.WriteLine("2) Enviar correo todos");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.KeyChar.Equals('1'))
            {
                Console.WriteLine("");
                Console.WriteLine("Seleccione un usuario de la lista para enviar el correo:");
                DibujarListadoPersonas(personas);
                ConsoleKeyInfo keyPersona = Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine(EnviarCorreoAPersona(personas, keyPersona));
            }
            else if (key.KeyChar.Equals('2'))
            {
                Console.WriteLine("");
                Console.WriteLine(EnviarCorreoATodos(personas));
            }

            Console.WriteLine("");
            Console.WriteLine("Fin del proceso, presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public static void DibujarListadoPersonas(List<Persona> personas)
        {

            foreach (Persona aPersona in personas)
            {
                Console.WriteLine(aPersona.Id + ". " + aPersona.Nombre + ": " + aPersona.Correo);
            }
        }

        public static string EnviarCorreoAPersona(List<Persona> personas, ConsoleKeyInfo keyPersona)
        {
            if (keyPersona.KeyChar.Equals('1')) { Console.WriteLine("Enviando Correo a : " + personas[0].Correo); }
            if (keyPersona.KeyChar.Equals('2')) { Console.WriteLine("Enviando Correo a : " + personas[1].Correo); }
            if (keyPersona.KeyChar.Equals('3')) { Console.WriteLine("Enviando Correo a : " + personas[2].Correo); }
            if (keyPersona.KeyChar.Equals('4')) { Console.WriteLine("Enviando Correo a : " + personas[3].Correo); }
            return "Correo enviado con éxito";
        }

        public static string EnviarCorreoATodos(List<Persona> personas)
        {

            foreach (Persona aPersona in personas)
            {
                Console.WriteLine("Enviando Correo a : " + aPersona.Correo);
            }
            return "Correos enviados.";
        }

    }

    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Persona(int id, string nombre, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Correo = correo;
        }

        public string EnviarCorreo()
        {
            return "Correo enviado correctamente a " + Nombre + " al correo " + Correo;
        }
    }
}

