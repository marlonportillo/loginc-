using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inici
{
    public partial class Form1 : Form
    {
        conexion con = new conexion();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.abrir();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int i = con.login(txtuser.Text, txtpass.Text);

            if (i > 0)

            {

                //Usuarios Correcto
                MessageBox.Show("bienvenido");
                Form2 form = new Form2();
                form.ShowDialog();



            }
            else

            {

                //Usuarios Incorrecto.
                MessageBox.Show("error no coincide algo ");

            }

        }
        public void mostrarData()
        {
            
        }
    }
}
