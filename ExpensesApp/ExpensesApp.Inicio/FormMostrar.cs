using ExpensesApp.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesApp.Inicio
{
    public partial class FormMostrar : Form
    {
        private FormInicio _formInicio;
        private List<Transaction> _transacciones;
        public FormMostrar(FormInicio parent, List<Transaction> transacciones)
        {
            InitializeComponent();
            _formInicio = parent;
            _transacciones = transacciones;
            CargarListView();
        }

        private void CargarListView()
        {
            DataTable data = new DataTable();

            data.Columns.Add("Tipo");
            data.Columns.Add("Fecha");
            data.Columns.Add("Categoría");
            data.Columns.Add("Monto");
            data.Columns.Add("Descripción");

            foreach(Transaction t in _transacciones)
            {
                if(t is Expense)
                {
                    data.Rows.Add("Gasto", t.Fecha, t.Categoria, t.Monto, t.Descripcion);
                }
                else
                {
                    data.Rows.Add("Ingreso", t.Fecha, t.Categoria, t.Monto, t.Descripcion);
                }
                    
            }
            dataGridView.DataSource = data;
        }



        private void CerrarYVolver()
        {
            _formInicio.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CerrarYVolver();
        }
    }
}
