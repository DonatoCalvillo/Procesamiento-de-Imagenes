using ProcesamientoImagenes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcesamientoImagenes
{
    public partial class Alertas_Form : Form
    {
        public Alertas_Form()
        {
            InitializeComponent();
        }

        public enum enmAccion
        {
            wait,
            start,
            close
        }

        public enum enmTipo
        {
            Success,
            Warning,
            Error,
            Info
        }

        private Alertas_Form.enmAccion acccion;

        private int x, y;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            acccion = enmAccion.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.acccion)
            {
                case enmAccion.wait: 
                    timer1.Interval = 5000;
                    acccion = enmAccion.close;
                    break;
                case enmAccion.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            acccion = enmAccion.wait;
                        }
                    }
                    break;
                case enmAccion.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void mostrarAlerta(string msg, enmTipo tipo)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alertas_Form frm = (Alertas_Form)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height  * i) ;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (tipo)
            {
                case enmTipo.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmTipo.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmTipo.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmTipo.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.lblMsg.Text = msg;

            this.Show();
            this.BringToFront();
            this.acccion = enmAccion.start;

            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
