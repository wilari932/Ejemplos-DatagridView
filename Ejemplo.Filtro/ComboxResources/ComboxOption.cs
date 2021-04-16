using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Filtro.ComboxResources
{
   public class ComboxOption<T>
    {
        public ComboxOption(T value, string label)
        {
            Value = value;
            Label = label;
        }
        // label es el texto que se amuestra en combox 
        public  string Label { get; set; }
        //Value es el valor que optenemos del combox en mi caso es generico 
        public T Value { get; set; }
        public override string ToString()
        {
            return Label;
        }
    }
}
