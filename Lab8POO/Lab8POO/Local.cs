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
    public partial class Local : Form
    {
        string namelocal;
        string[] recdisponibles = { "Recreacional 1", "Recreacional 2" };
        string[] cinesdisponibles = { "Cine 1", "Cine 2" };
        string[] restdisponibles = { "Restaurant 1", "Restaurant 2", "Restaurant 3" };
        string[] tiendasdisponibles = { "Tienda 1", "Tienda 2", "Tienda 3", "Tienda 4" };
        public Local(string NameLocal)
        {
            InitializeComponent();
            namelocal = NameLocal;
        }

        private void Local_Load(object sender, EventArgs e)
        {
            popularNombres();
            NombreLocal.Text += namelocal;
        }
        void popularNombres()
        {
            if (namelocal=="Tiendas")
            {
                for (int i = 0; i < tiendasdisponibles.Length;i++)
                {
                    Nombres.Items.Add(tiendasdisponibles[i]);
                }
            }
            if (namelocal == "Cines")
            {
                for (int i = 0; i < cinesdisponibles.Length; i++)
                {
                    Nombres.Items.Add(cinesdisponibles[i]);
                }
            }
            if (namelocal == "Restaurant")
            {
                for (int i = 0; i < restdisponibles.Length; i++)
                {
                    Nombres.Items.Add(restdisponibles[i]);
                }
            }
            if (namelocal == "Recreacional")
            {
                for (int i = 0; i < recdisponibles.Length; i++)
                {
                    Nombres.Items.Add(recdisponibles[i]);
                }
            }
        }
        void NameSelec()
        {
            string nombreseleccionado = Nombres.SelectedItem.ToString().ToLower();
        }

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            //Para las tiendas
            if (Nombres.Text == "Tienda 1")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyT1 \nNumero Identificador: 0011 \nCategoría: Ropa \n";
                Info.Text += "Horario: 9:00 am - 8:00pm";
            }
            if (Nombres.Text == "Tienda 2")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyT2 \nNumero Identificador: 0011 \nCategoría: Jugueteria \n";
                Info.Text += "Horario: 9:00 am - 8:00pm";
            }
            if (Nombres.Text == "Tienda 3")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyT3 \nNumero Identificador: 0011\nCategoría: Hogar \n";
                Info.Text += "Horario: 9:00 am - 8:00pm";
            }
            if (Nombres.Text == "Tienda 4")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyT4 \nNumero Identificador: 0011 \nCategoría: Deportes \n";
                Info.Text += "Horario: 9:00 am - 8:00pm";
            }
            if (Nombres.Text == Nombrenew.Text)
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño:"+Dueñonew.Text+" \n Numero Identificador:"+Nronew.Text+"\nCategoría:"+Catnew.Text+" \n";
                Info.Text += "Horario: 9:00 am - 8:00pm";
            }


            //Para los restaurantes
            if (Nombres.Text == "Restaurant 1")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyR1 \n Numero Identificador: 0011 \n";
                Info.Text += "Horario: 10:00 am - 8:00pm\n";
                Info.Text += "Mesas Exclusivas: Sí";
            }
            if (Nombres.Text == "Restaurant 2")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyR2 \n Numero Identificador: 0011\n";
                Info.Text += "Horario: 10:00 am - 8:00pm\n";
                Info.Text += "Mesas Exclusivas: Sí";
            }
            if (Nombres.Text == "Restaurant 3")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyR3 \n Numero Identificador: 0011\n";
                Info.Text += "Horario: 10:00 am - 9:00pm\n";
                Info.Text += "Mesas Exclusivas: No";
            }
            if (Nombres.Text == Nombrenew.Text)
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño:" + Dueñonew.Text + " \n Numero Identificador:" + Nronew.Text+"\n";
                Info.Text += "Horario: 10:00 am - 9:00pm\n";
                Info.Text += "Mesas Exclusivas: "+MesExc.Text;
            }

            //Para los cines
            if (Nombres.Text == "Cine 1")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyC1 \n Numero Identificador: 0011\n";
                Info.Text += "Horario: 10:00 am - 12:00am\n";
                Info.Text += "Numero de Salas: 10";
            }
            if (Nombres.Text == "Cine 2")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyC2 \n Numero Identificador: 0011\n";
                Info.Text += "Horario: 10:00 am - 12:00am\n";
                Info.Text += "Numero de Salas: 6";
            }
            if (Nombres.Text == Nombrenew.Text)
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño:" + Dueñonew.Text + "\nNumero Identificador: " + Nronew + "\n";
                Info.Text += "Horario: 10:00 am - 12:00am\n";
                Info.Text += "Numero de Salas: " + Salasnew.Text;
            }


            //Para recreacional
            if (Nombres.Text == "Recreacional 1")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyRc1 \n Numero Identificador: 0011 \n";
                Info.Text += "Horario: 12:00 pm - 6:00pm";
            }
            if (Nombres.Text == "Recreacional 2")
            {
                Info.Text = "";
                Info.Text += "Nombre Dueño: xxyyRc2 \n Numero Identificador: 0011 \n";
                Info.Text += "Horario: 12:00 am - 6:00pm";
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (namelocal=="Tiendas")
            {
                Nombres.Items.Add(Nombrenew.Text);
            }
            if (namelocal == "Cines")
            {
                Nombres.Items.Add(Nombrenew.Text);
            }
            if (namelocal == "Restaurant")
            {
                Nombres.Items.Add(Nombrenew.Text);
            }
            if (namelocal == "Recreacional")
            {
                Nombres.Items.Add(Nombrenew.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
