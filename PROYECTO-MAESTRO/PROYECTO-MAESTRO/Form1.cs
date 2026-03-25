using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAESTRO
{
    public partial class Form1 : Form
    {
        private void BordesRedondeados(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form2 llamar = new Form2();
            llamar.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BordesRedondeados(panel4, 50);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           LinearGradientBrush degradado = new LinearGradientBrush
           (panel4.ClientRectangle,
           Color.White,
           Color.LightGray,
           LinearGradientMode.Vertical);
           e.Graphics.FillRectangle(degradado, panel4.ClientRectangle);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "ProgramQuiz\n" +
                "Versión: 1.0 \n" +
                "Autores: Carlos Didier Mendoza Candela \nGustavo Mitchell Hernandez Estrada \n" +
                "¡Pon a prueba tu mente!", "Acerca de:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
