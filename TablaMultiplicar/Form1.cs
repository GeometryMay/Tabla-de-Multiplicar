using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroTabla.Text, out int numeroTabla))
            {
                // Limpiar el DataGridView antes de mostrar la nueva tabla
                dgvTablaMultiplicar.Rows.Clear();

                // Mostrar la cabecera de la tabla
                dgvTablaMultiplicar.Columns.Clear();
                dgvTablaMultiplicar.Columns.Add("Columna", "Multiplicador");
                dgvTablaMultiplicar.Columns.Add("Columna", "Resultado");

                // Generar la tabla de multiplicar y mostrar en el DataGridView
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numeroTabla * i;
                    dgvTablaMultiplicar.Rows.Add(i, resultado);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para la tabla.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnLimpiar_Click(sender, e, dgvTablaMultiplicar.ToString());
        }

        private void btnLimpiar_Click(object sender, EventArgs e, string v)
        {
            txtNumeroTabla.Text = "";
            dgvTablaMultiplicar.Columns.Clear();
        }
    }
}
