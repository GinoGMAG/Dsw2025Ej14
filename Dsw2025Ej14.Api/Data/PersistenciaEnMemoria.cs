using Dsw2025Ej14.Api.Domain;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistenciaEnMemoria
    {
        private const string Archivo = "products.json";
        private static List<Product>? _productos;
        public static void LoadProduct()
        {
            var products = File.ReadAllText(Archivo);
            _productos = JsonSerializer.Deserialize<List<Product>>(products, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? [];

        }
    }
}
