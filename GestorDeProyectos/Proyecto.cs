using System.Collections.Generic;

namespace GestorDeProyectos
{
    public class Proyecto
    {
        public string Titulo { get; set; }
        public List<Tarjeta> tarjetas { get; set; }
        public bool EsVisible { get; set; }
    }
}