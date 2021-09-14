using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ProcesamientoImagenes
{
    public partial class FiltrosControl : UserControl
    {
        //Va en la clase CAMARA
        public string path = @"C:\Users\edgar\OneDrive\Pictures\PI\";
        private bool hayDispositivos;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;

        //Atributos para filtros
        Bitmap image;
        Bitmap imageOriginal;

        //instancia de filtros
        Filtros filtro = new Filtros();

        //Rellenar cmb
        List<string> colores = new List<string>();

        public FiltrosControl()
        {
            InitializeComponent();
        }

        private void FiltrosControl_Load(object sender, EventArgs e)
        {
            cargaDispositvos();
            cargarColores();
        }
        //Va en la clase
        public void cargaDispositvos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            hayDispositivos = (misDispositivos.Count > 0) ? true : false;
            if (hayDispositivos)
                for (int i = 0; i < misDispositivos.Count; i++)
                    cmbCamaras.Items.Add(misDispositivos[i].Name.ToString());

            cmbCamaras.Text = misDispositivos[0].Name.ToString();
        }

        public void cargarColores()
        {
            colores.Add("Rojo");
            colores.Add("Cian");
            colores.Add("Magenta");
            colores.Add("Azul");
            colores.Add("Amarillo");
            colores.Add("Verde");

            for (int i = 0; i < colores.Count; i++)
                cmbColor.Items.Add(colores[i]);

            cmbColor.Text = colores[0];
        }

        private void btnActivarCamara_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            int i = cmbCamaras.SelectedIndex;
            string nombreVideo = misDispositivos[i].MonikerString;
            miWebCam = new VideoCaptureDevice(nombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(capturando);
            miWebCam.Start();
        }

        //Va en la clase
        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap) eventArgs.Frame.Clone();
            pictureBox1.Image = imagen;
        }

        //Va en la clase
        private void cerrarWebCam()
        {
            if(miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
        }
        
        public void Alerta(string msg, Alertas_Form.enmTipo tipo)
        {
            Alertas_Form frm = new Alertas_Form();
            frm.mostrarAlerta(msg, tipo);
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            this.Alerta("Foto guardad con exito", Alertas_Form.enmTipo.Success);
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                cerrarWebCam();
                pictureBox1.Image.Save(path + "imagen.jpg", ImageFormat.Jpeg);
                filtro.setImage((Bitmap)pictureBox1.Image);
            }
        }

        private void btn_CargarImg_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            var resultado = d.ShowDialog();
            if(resultado == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            string filename = d.FileName;
            filtro.setImage((Bitmap)Bitmap.FromFile(filename));
            imageOriginal = filtro.getImage();
            pictureBox1.Image = filtro.getImage();
            pictureBox2.Image = filtro.getImage();
        }

        //Filtros
        private void btnColor_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = filtro.FiltroColor(cmbColor.Text);
            cmbColor.Enabled = false;
            bloquearBoton(btnColor);
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {   
            pictureBox2.Image = filtro.FiltroNegativo();
            bloquearBoton(btnNegativo);
        }

        private void btnACromatica_Click(object sender, EventArgs e)
        { 
            pictureBox2.Image = filtro.FiltroACromatica();
            bloquearBoton(btnACromatica);
        }

        private void btnEGrises_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = filtro.FiltroEGrises()
            bloquearBoton(btnEGrises);
        }

        private void btnColorizar_Click(object sender, EventArgs e)
        {
            if(txbR.Text == "" || txbG.Text == "" || txbB.Text == "")
                MessageBox.Show("Porfavor colocar color con el que desee colorizar la imagen en formato RGB");
            else
            {
                int paramR = Int32.Parse(txbR.Text);
                int paramG = Int32.Parse(txbG.Text);
                int paramB = Int32.Parse(txbB.Text);

                pictureBox2.Image = filtro.FiltroColorizar(paramR, paramG, paramB);

                txbR.Enabled = false;
                txbG.Enabled = false;
                txbB.Enabled = false;

                bloquearBoton(btnColorizar);
            }
        }

        private void tbContraste_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = filtro.FiltroContraste(tbContraste.Value);
            
            tbContraste.Enabled = false;

            this.Invalidate();
           
        }

        private void btnGradianteColores_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = filtro.FiltroGradianteColores();
            bloquearBoton(btnGradianteColores);
        }

        private void tbBrillo_MouseUp(object sender, MouseEventArgs e)
        {
            

            pictureBox2.Image = filtro.FiltroBrillo(tbBrillo.Value);

            tbBrillo.Enabled = false;

            this.Invalidate();
        }

        private void btnGamma_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = filtro.FiltroGamma() ;
            bloquearBoton(btnGamma);
        }

        private void btnRuido_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = filtro.FiltroRuido() ;
            bloquearBoton(btnRuido);
        }

        //Funciones extra
        private void bloquearBoton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(100, 129, 168);
            this.Invalidate();
        }
    }
}
