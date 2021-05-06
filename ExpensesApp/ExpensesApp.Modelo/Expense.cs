using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Modelo
{
    public class Expense : Transaction
    {
        public Expense(string fecha, string categoria, decimal monto, string descripcion = "") : base(fecha, categoria, monto, descripcion) { }
    }
}
