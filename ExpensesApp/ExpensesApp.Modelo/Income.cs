using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Modelo
{
    public class Income : Transaction
    {
        public Income(string fecha, string categoria, decimal monto, string descripcion = "") : base(fecha, categoria, monto, descripcion) { }
    }
}
