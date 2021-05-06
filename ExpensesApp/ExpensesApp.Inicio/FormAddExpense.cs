using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpensesApp.Modelo;

namespace ExpensesApp.Inicio
{
    public partial class FormAddExpense : Form
    {
        private FormInicio _formApp;

        public FormAddExpense(FormInicio parent)
        {
            InitializeComponent();
            _formApp = parent;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(
                dateTimePicker.Value.ToShortDateString() == string.Empty ||
                cmbCategoria.SelectedItem.ToString() == string.Empty ||
                txtMonto.Text == string.Empty ||
                txtDescripcion.Text == string.Empty
                )
            {
                MessageBox.Show("No puede haber campos vacíos", "Error");
            }
            else if(radioExpense.Checked)
            {
                Expense expense = new Expense(
                    dateTimePicker.Value.ToShortDateString(),
                    cmbCategoria.SelectedItem.ToString(),
                    Decimal.Parse(txtMonto.Text)*(-1),
                    txtDescripcion.Text);

                _formApp.AgregarTransaccion(expense);

                CerrarYVolver();
            }
            else
            {
                Income income = new Income(
                    dateTimePicker.Value.ToShortDateString(),
                    cmbCategoria.SelectedItem.ToString(),
                    Decimal.Parse(txtMonto.Text),
                    txtDescripcion.Text);

                _formApp.AgregarTransaccion(income);

                CerrarYVolver();
            }

            
        }

        private void FormAddExpense_Load(object sender, EventArgs e)
        {
            CargarListas();
        }

        private void CargarListas()
        {
            if (radioExpense.Checked)
            {
                cmbCategoria.DataSource = CategoriaHelper.GetCategoriasGastos();
                cmbCategoria.DisplayMember = "Categoria";
            }
            else
            {
                cmbCategoria.DataSource = CategoriaHelper.GetCategoriasIngresos();
                cmbCategoria.DisplayMember = "Categoria";
            }
            
            //cmbCategoria.ValueMember = "Categoria";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarYVolver();
        }

        private void CerrarYVolver()
        {
            _formApp.Show();
            this.Close();
        }

        private void RadioExpense_Change(object sender, EventArgs e)
        {
            CargarListas();
        }
    }
}
