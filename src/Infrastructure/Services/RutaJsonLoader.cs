using System.IO;
using System.Text.Json;
using Infrastructure.Models;

namespace Infrastructure.Services
{
    public class RutaJsonLoader
    {
        public static RutaDto[] CargarRutasDesdeArchivo(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"No se encontró el archivo de rutas en: {filePath}");
            }

            string jsonString = File.ReadAllText(filePath);
            
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var redRutas = JsonSerializer.Deserialize<RedRutasDto>(jsonString, opciones);

            return redRutas?.Rutas ?? new RutaDto[0];
        }
    }
}