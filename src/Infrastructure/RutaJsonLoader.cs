using System.IO;
using System.Text.Json;

namespace Infrastructure
{
    public class RutaLoader
    {
        public static RutaDto[] CargarRutas(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"No se encontró el archivo de rutas: {filePath}");
            }

            string jsonContent = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            
            var red = JsonSerializer.Deserialize<RedRutasDto>(jsonContent, options);
            return red?.Rutas ?? new RutaDto[0];
        }
    }
}