using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DesarrolloDeApps.Taller2
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly List<User> Users = new List<User>
        {
            new User { Nombre = "Juan Camilo", Id = "001-1234567-8", direccion = "Calle 123", celular = "555-1234", cumpleaños = new DateTime(1990, 01, 01) },
            new User { Nombre = "Mariam Velez", Id = "002-1234567-9", direccion = "Calle 456", celular = "555-5678", cumpleaños = new DateTime(1985, 03, 15) },
            new User { Nombre = "Luis Lunes", Id = "003-1234567-0", direccion = "Calle 789", celular = "555-9101", cumpleaños = new DateTime(1995, 05, 21) }
        };

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(Users);
        }
    }

    public class User
    {
        public string Nombre { get; set; }
        public string Id { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
        public DateTime cumpleaños { get; set; }
    }
}
