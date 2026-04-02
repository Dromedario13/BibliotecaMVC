using BibliotecaMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMVC.Views
{
    public class LibroView
    {
        private LibroController controller = new LibroController();

        public void Menu()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Write(@"
**** Sistema de biblioteca C# ****
----------------------------------
Menu:
1.Agregar
2.Mostrar
3.Editar
4.Eliminar
5.Salir
----------------------------------
selecione una obcion del menu: ");

    
                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción inválida...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Mostrar();
                        break;
                    case 3:
                        Editar();
                        break;
                    case 4:
                        Eliminar();
                        break;
                    case 5:
                        Console.WriteLine("\n Saliendo del sistema...");
                        salir = true; 
                        break;
                    default:
                        Console.WriteLine("❌ Opción no válida");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        private void Agregar()
        {
// Feature: Agregar libro
// Permite al usuario registrar un nuevo libro en el sistema
            Console.WriteLine("*** Agregar Libro ***");

            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
           
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            

            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());
           

            controller.Crear(titulo, autor, anio);
        }

        private void Mostrar()
        {
// Feature: Mostrar libros
// Muestra todos los libros registrados
            var libros = controller.ObtenerTodos();

            foreach (var l in libros)
            {
                Console.WriteLine($"{l.Id} - {l.Titulo} - {l.Autor} - {l.Anio}");
            }
        }

        private void Editar()
        {
// Feature: Editar libro
// Permite modificar los datos de un libro existente
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nuevo titulo: ");
            string titulo = Console.ReadLine();

            Console.Write("Nuevo autor: ");
            string autor = Console.ReadLine();

            Console.Write("Nuevo año: ");
            int anio = int.Parse(Console.ReadLine());

            controller.Editar(id, titulo, autor, anio);
        }

        private void Eliminar()
        {
// Feature: Eliminar libro
// Elimina un libro del sistema por su ID
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            controller.Eliminar(id);
        }
    }
}
