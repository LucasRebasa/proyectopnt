using System;
using System.Collections.Generic;
using System.Text;

namespace GestorDeProyectos
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        private List<Proyecto> proyectos;

    }
}
