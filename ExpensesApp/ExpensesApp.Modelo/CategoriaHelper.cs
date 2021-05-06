using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Modelo
{
    public static class CategoriaHelper
    {
        public static List<string> GetCategoriasGastos()
        {
            List<string> categorias = new List<string>();

            categorias.Add("Comida");
            categorias.Add("Vivienda");
            categorias.Add("Transporte");
            categorias.Add("Salud");

            return categorias;
        }

        public static List<string> GetCategoriasIngresos()
        {
            List<string> categorias = new List<string>();

            categorias.Add("Sueldo");
            categorias.Add("Regalo");
            categorias.Add("Propina");

            return categorias;
        }

    }
}
