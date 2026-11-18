namespace Infrastructure.Models
{
    public class RutaDto
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int Tiempo { get; set; }
    }

    public class RedRutasDto
    {
        public RutaDto[] Rutas { get; set; }
    }
}