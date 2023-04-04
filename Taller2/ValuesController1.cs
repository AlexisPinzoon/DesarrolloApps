using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DesarrolloDeApps.Taller2
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> Productos = new List<Product>
        {
            new Product { nombre = "Producto 1", Codigo = "001", Precio = 10.0, Estado = "Disponible" },
            new Product { nombre = "Producto 2", Codigo = "002", Precio = 20.0, Estado = "Disponible" },
            new Product { nombre = "Producto 3", Codigo = "003", Precio = 30.0, Estado = "No disponible" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(Productos);
        }
    }

    public class Product
    {
        public string nombre { get; set; }
        public string Codigo { get; set; }
        public double Precio { get; set; }
        public string Estado { get; set; }
    }
}

