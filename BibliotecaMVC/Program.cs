using BibliotecaMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroView vista = new LibroView();
            vista.Menu();
        }
    }
}
