using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbOrdenador_Click(object sender, EventArgs e)
        {
            OcultarMesa();
        }

        private void pbMesa_Click(object sender, EventArgs e)
        {

        }

        private void pbPuerta_Click(object sender, EventArgs e)
        {
            OcultarMesa();
        }

        private void OcultarMesa()
        {
           
         

            foreach(Control pb in Form1.ActiveForm.Controls)
            {
                if (pb.GetType() == typeof(PictureBox) )
                  
                {
                    if (pb.Name != "pbMesa" && pb.Name != "pbOrdenador" && pb.Name != "pbPuerta" && pb.Name != "pictureBox3" && pb.Name != "pictureBox5" && pb.Name != "pictureBox7")
                    {
                        pb.Hide();
                    }
                    
                }     
            }

        }
    }
}
