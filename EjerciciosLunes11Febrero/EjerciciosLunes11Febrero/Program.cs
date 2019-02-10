using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            bool exit = false;
            do {

                Console.WriteLine("Que ejercicio quieres ejecutar? Pulsa '?' para saber que ejercicios hay disponibles.");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "?":
                        Console.WriteLine("1 = Extension Methods");
                        Console.WriteLine("2 = Boxing y Unboxing");
                        Console.WriteLine("3 = Using y Dispose");
                        Console.WriteLine("exit = Salir y cerrar programa");
                        Console.WriteLine("? = Ayuda");
                        Console.WriteLine();
                        break;

                    case "1":
                        // Extension Methods
                        Console.WriteLine("Escribe una frase y la giraremos con un extension method:");
                        string sentence = Console.ReadLine();
                        Console.WriteLine(sentence.reverseSentence()); // Aqui es donde usamos el extension method
                        Console.WriteLine();
                        break;

                    case "2":
                        int num = 25;
                        string name = "asdf";

                        // Boxing
                        object[] array = Box(num, name);

                        // Unboxing
                        int unboxedNum = (int) array[0];
                        string unboxedName = array[1].ToString();
                        Console.WriteLine("unboxedNum = {0}, unboxedName = {1}", unboxedNum, unboxedName);

                        Console.WriteLine();
                        break;

                    case "3":
                        DisposableClass dc = null;
                        // Dispose usando el using
                        using (dc = new DisposableClass())
                        {
                            Console.WriteLine("Cosas que hariamos dentro del using");
                        }

                        // Dispose usando try finally
                        try
                        {
                             dc = new DisposableClass();
                            Console.WriteLine("Cosas que hariamos dentro del try");
                        } finally
                        {
                            dc.Dispose();
                        }

                        break;
                        
                    case "exit":
                        exit = true;
                        break;
                        
                    default:
                        Console.WriteLine("Entrada incorrecta");
                        Console.WriteLine("Pulsa '?' para ver que comandos hay disponibles");
                        Console.WriteLine();
                        break;
                }
            } while (!exit);
            
        }

        static object[] Box(params object[] arg)
        {
            return arg;
        }

    }
}
