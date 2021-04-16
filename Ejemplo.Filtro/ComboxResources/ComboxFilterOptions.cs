using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Filtro.ComboxResources
{
   public static class ComboxFilterOptions
    {
        public static List<ComboxOption<string>> GetValue => new List<ComboxOption<string>>
        {
            new ComboxOption<string>("Id","Id"),
            new ComboxOption<string>("Nombre","Nombre"),
            new ComboxOption<string>("Apellido","Apellido")
        };
    }
}
