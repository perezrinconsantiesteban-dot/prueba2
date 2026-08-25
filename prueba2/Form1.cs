using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_CheckedChanged(object sender, EventArgs e)
        {
            {
                // Cambia el texto del botón al acercar el cursor
                btnNo.Text = "Debes decirle";

                // Genera posiciones aleatorias para que se mueva
                Random rand = new Random();

                int maxX = this.ClientSize.Width - btnNo.Width;
                int maxY = this.ClientSize.Height - btnNo.Height;

                int newX = rand.Next(0, maxX);
                int newY = rand.Next(0, maxY);

                // Mueve el botón a la nueva posición
                btnNo.Location = new System.Drawing.Point(newX, newY);
            }
        }

        private void btnSi_CheckedChanged(object sender, EventArgs e)
        {
            {
                MessageBox.Show("¡Sabía que dirías que sí!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
