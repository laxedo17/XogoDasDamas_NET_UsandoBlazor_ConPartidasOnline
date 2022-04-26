namespace Damas.Client.Datos
{
    public class Dama
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public DireccionDama Direccion { get; set; }
        public string Color { get; set; }
    }

    public enum DireccionDama
    {
        Abaixo,
        Arriba,
        Ambos
    }
}