namespace ExpensesApp.Inicio
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(475, 89);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(111, 26);
            this.btnAddExpense.TabIndex = 0;
            this.btnAddExpense.Text = "Agregar Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.BtnAddExpense_Click);
            // 
            // btnVerLista
            // 
            this.btnVerLista.Location = new System.Drawing.Point(475, 162);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(111, 26);
            this.btnVerLista.TabIndex = 1;
            this.btnVerLista.Text = "Mostrar";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.btnAddExpense);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnVerLista;
    }
}

