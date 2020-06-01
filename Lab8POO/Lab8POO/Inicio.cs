using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8POO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }
        private void controlBotones()
        {
            if (División.Text.Trim() != string.Empty && División.Text.All(Char.IsLetter))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(División, "");
            }
            else
            {
                if(!(División.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(División, "La división solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(División, "Debe introducir una división: Tienda, Restaurant, Cine, Recreacional");
                }
                btnIngresar.Enabled = false;
                División.Focus();

            }
        }

        private void División_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
