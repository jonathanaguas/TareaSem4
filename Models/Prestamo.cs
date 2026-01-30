using BibliotecaApp.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace BibliotecaApp.Models
{


    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public int MiembroId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        // Relaciones de navegación
        public Libro Libro { get; set; }
        public Miembro Miembro { get; set; }
    }
}