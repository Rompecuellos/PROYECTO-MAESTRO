using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAESTRO
{
    public partial class Form3 : Form
    {
        Form2 form2; //Se hace referencia del formulario original
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void btnRegresarM_Click(object sender, EventArgs e)
        {
            Form1 llamar = new Form1();
            llamar.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblPuntaje.Text = "¡Juego terminado! \nPuntaje: " + form2.puntaje + " / 10";
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Form2 llamar = new Form2();
            llamar.Show();
            this.Hide();
        }
    }
}
