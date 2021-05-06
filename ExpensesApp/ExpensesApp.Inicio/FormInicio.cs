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
    public partial class FormInicio : Form
    {
        private List<Transaction> _transacciones;
        public FormInicio()
        {
            InitializeComponent();
            _transacciones = new List<Transaction>();
        }

        public void AgregarTransaccion(Transaction t)
        {
            if(t != null)
            {
                _transacciones.Add(t);
            }
        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            FormAddExpense frmAdd = new FormAddExpense(this);
            frmAdd.Show();
            this.Hide();
            
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            FormMostrar frmMostrar = new FormMostrar(this, _transacciones);
            frmMostrar.Show();
            this.Hide();
        }
    }
}
