using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;



namespace PictureBox
{

    
    public partial class Form1 : Form
    {
        Image<Bgr, byte> InputColor;
        Image<Gray, byte> InputGray;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string imagen = "F:\\ValentinElizalde.jpg";


            InputColor = new Image<Bgr, byte>(imagen);


            if (InputColor == null)
            {
                MessageBox.Show("No se cargo la imagen");
                return;
            }

            imageBox1.Image = InputColor;
            //Desactivar opciones de clic derecho emguCV
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Convertir a escala de grises
            InputGray = InputColor.Convert<Gray, byte>();
            imageBox2.Image = InputGray;
        }
    }
}
