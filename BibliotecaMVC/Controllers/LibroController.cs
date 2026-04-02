using BibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMVC.Controllers
{
    public class LibroController
    {
        private List<Libro> libros = new List<Libro>();
        private int contador = 1;

        public void Crear(string titulo, string autor, int anio)
        {
            libros.Add(new Libro
            {
                Id = contador++,
                Titulo = titulo,
                Autor = autor,
                Anio = anio
            });
        }

        public List<Libro> ObtenerTodos()
        {
            return libros;
        }

        public void Editar(int id, string titulo, string autor, int anio)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                libro.Titulo = titulo;
                libro.Autor = autor;
                libro.Anio = anio;
            }
        }

        public void Eliminar(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                libros.Remove(libro);
            }
        }
    }
}
