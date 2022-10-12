using System.Collections.Generic;

namespace GestorDeProyectos
{
    public class Tarjeta
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
        private List<Campo> campos;
    }
   

}