using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            homeControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnFoto.Height;
            sidePanel.Top = btnFoto.Top;
            filtrosControl1.BringToFront();
        }

        private void btnDeteccion_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnDeteccion.Height;
            sidePanel.Top = btnDeteccion.Top;
            deteccionMovController1.BringToFront();
        }
    }
}
