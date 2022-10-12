namespace GestorDeProyectos
{
    public class Campo
    {
        public TipoTarjeta Tipo { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
    }
    public enum TipoTarjeta { Texto, Imagen, Archivo }
}