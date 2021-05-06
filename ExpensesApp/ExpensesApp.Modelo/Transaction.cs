using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Modelo
{
    public abstract class Transaction
    {
        // ATRIBUTOS
        private string _fecha;
        private string _categoria;
        private decimal _monto;
        private string _descripcion;

        // PROPIEDADES
        public string Fecha => _fecha;
        public string Categoria => _categoria;
        public decimal Monto => _monto;
        public string Descripcion => _descripcion;

        // MÉTODOS
        public Transaction(string fecha, string categoria, decimal monto, string descripcion = "")
        {
            _fecha = fecha;
            _categoria = categoria;
            _monto = monto;
            _descripcion = descripcion;
        }
    }
}
