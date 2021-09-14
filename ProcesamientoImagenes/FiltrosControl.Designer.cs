
namespace ProcesamientoImagenes
{
    partial class FiltrosControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCamaras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CargarImg = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnActivarCamara = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnACromatica = new System.Windows.Forms.Button();
            this.btnEGrises = new System.Windows.Forms.Button();
            this.btnColorizar = new System.Windows.Forms.Button();
            this.btnGamma = new System.Windows.Forms.Button();
            this.btnRuido = new System.Windows.Forms.Button();
            this.txbR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbG = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnGradianteColores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbContraste = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbBrillo = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrillo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(600, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTROS";
            // 
            // cmbCamaras
            // 
            this.cmbCamaras.FormattingEnabled = true;
            this.cmbCamaras.Location = new System.Drawing.Point(40, 56);
            this.cmbCamaras.Name = "cmbCamaras";
            this.cmbCamaras.Size = new System.Drawing.Size(240, 23);
            this.cmbCamaras.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la cámara";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de filtros";
            // 
            // btn_CargarImg
            // 
            this.btn_CargarImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.btn_CargarImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btn_CargarImg.FlatAppearance.BorderSize = 2;
            this.btn_CargarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarImg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarImg.ForeColor = System.Drawing.Color.White;
            this.btn_CargarImg.Location = new System.Drawing.Point(56, 280);
            this.btn_CargarImg.Name = "btn_CargarImg";
            this.btn_CargarImg.Size = new System.Drawing.Size(224, 48);
            this.btn_CargarImg.TabIndex = 10;
            this.btn_CargarImg.Text = "Subir una imagen";
            this.btn_CargarImg.UseVisualStyleBackColor = false;
            this.btn_CargarImg.Click += new System.EventHandler(this.btn_CargarImg_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(56, 896);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(160, 23);
            this.cmbColor.TabIndex = 20;
            // 
            // btnActivarCamara
            // 
            this.btnActivarCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.btnActivarCamara.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnActivarCamara.FlatAppearance.BorderSize = 2;
            this.btnActivarCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarCamara.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnActivarCamara.ForeColor = System.Drawing.Color.White;
            this.btnActivarCamara.Location = new System.Drawing.Point(56, 416);
            this.btnActivarCamara.Name = "btnActivarCamara";
            this.btnActivarCamara.Size = new System.Drawing.Size(224, 48);
            this.btnActivarCamara.TabIndex = 12;
            this.btnActivarCamara.Text = "Activar cámara";
            this.btnActivarCamara.UseVisualStyleBackColor = false;
            this.btnActivarCamara.Click += new System.EventHandler(this.btnActivarCamara_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.btnCapturar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnCapturar.FlatAppearance.BorderSize = 2;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCapturar.ForeColor = System.Drawing.Color.White;
            this.btnCapturar.Location = new System.Drawing.Point(56, 472);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(224, 48);
            this.btnCapturar.TabIndex = 13;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usar una foto de \r\nsu computadora.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(104, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usar la cámara de\r\nsu computadora.";
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.btnGuardarImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnGuardarImagen.FlatAppearance.BorderSize = 2;
            this.btnGuardarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarImagen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarImagen.ForeColor = System.Drawing.Color.White;
            this.btnGuardarImagen.Location = new System.Drawing.Point(952, 896);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(224, 48);
            this.btnGuardarImagen.TabIndex = 16;
            this.btnGuardarImagen.Text = "Guardar imagen";
            this.btnGuardarImagen.UseVisualStyleBackColor = false;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(840, 808);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 66);
            this.label6.TabIndex = 17;
            this.label6.Text = "¿A quedado satisfecho con la foto?\r\n¡GUARDALA!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(56, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 76);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nota: Si desea volver\r\na tomar otra foto\r\npresione el boton\r\n\"Activar cámara\" den" +
    "uevo.\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(56, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cerrar camara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(328, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(712, 504);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnNegativo
            // 
            this.btnNegativo.BackColor = System.Drawing.Color.White;
            this.btnNegativo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnNegativo.FlatAppearance.BorderSize = 2;
            this.btnNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegativo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnNegativo.ForeColor = System.Drawing.Color.Black;
            this.btnNegativo.Location = new System.Drawing.Point(56, 816);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(160, 32);
            this.btnNegativo.TabIndex = 21;
            this.btnNegativo.Text = "Negativo";
            this.btnNegativo.UseVisualStyleBackColor = false;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnColor.FlatAppearance.BorderSize = 2;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(56, 856);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(160, 32);
            this.btnColor.TabIndex = 22;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnACromatica
            // 
            this.btnACromatica.BackColor = System.Drawing.Color.White;
            this.btnACromatica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnACromatica.FlatAppearance.BorderSize = 2;
            this.btnACromatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACromatica.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnACromatica.ForeColor = System.Drawing.Color.Black;
            this.btnACromatica.Location = new System.Drawing.Point(232, 816);
            this.btnACromatica.Name = "btnACromatica";
            this.btnACromatica.Size = new System.Drawing.Size(160, 32);
            this.btnACromatica.TabIndex = 23;
            this.btnACromatica.Text = "Aberración Cromática";
            this.btnACromatica.UseVisualStyleBackColor = false;
            this.btnACromatica.Click += new System.EventHandler(this.btnACromatica_Click);
            // 
            // btnEGrises
            // 
            this.btnEGrises.BackColor = System.Drawing.Color.White;
            this.btnEGrises.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnEGrises.FlatAppearance.BorderSize = 2;
            this.btnEGrises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEGrises.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEGrises.ForeColor = System.Drawing.Color.Black;
            this.btnEGrises.Location = new System.Drawing.Point(408, 816);
            this.btnEGrises.Name = "btnEGrises";
            this.btnEGrises.Size = new System.Drawing.Size(160, 32);
            this.btnEGrises.TabIndex = 24;
            this.btnEGrises.Text = "Escala de grises";
            this.btnEGrises.UseVisualStyleBackColor = false;
            this.btnEGrises.Click += new System.EventHandler(this.btnEGrises_Click);
            // 
            // btnColorizar
            // 
            this.btnColorizar.BackColor = System.Drawing.Color.White;
            this.btnColorizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnColorizar.FlatAppearance.BorderSize = 2;
            this.btnColorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorizar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnColorizar.ForeColor = System.Drawing.Color.Black;
            this.btnColorizar.Location = new System.Drawing.Point(232, 856);
            this.btnColorizar.Name = "btnColorizar";
            this.btnColorizar.Size = new System.Drawing.Size(160, 32);
            this.btnColorizar.TabIndex = 25;
            this.btnColorizar.Text = "Colorizar";
            this.btnColorizar.UseVisualStyleBackColor = false;
            this.btnColorizar.Click += new System.EventHandler(this.btnColorizar_Click);
            // 
            // btnGamma
            // 
            this.btnGamma.BackColor = System.Drawing.Color.White;
            this.btnGamma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnGamma.FlatAppearance.BorderSize = 2;
            this.btnGamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGamma.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGamma.ForeColor = System.Drawing.Color.Black;
            this.btnGamma.Location = new System.Drawing.Point(576, 816);
            this.btnGamma.Name = "btnGamma";
            this.btnGamma.Size = new System.Drawing.Size(160, 32);
            this.btnGamma.TabIndex = 26;
            this.btnGamma.Text = "Gamma";
            this.btnGamma.UseVisualStyleBackColor = false;
            this.btnGamma.Click += new System.EventHandler(this.btnGamma_Click);
            // 
            // btnRuido
            // 
            this.btnRuido.BackColor = System.Drawing.Color.White;
            this.btnRuido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnRuido.FlatAppearance.BorderSize = 2;
            this.btnRuido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuido.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRuido.ForeColor = System.Drawing.Color.Black;
            this.btnRuido.Location = new System.Drawing.Point(576, 856);
            this.btnRuido.Name = "btnRuido";
            this.btnRuido.Size = new System.Drawing.Size(160, 32);
            this.btnRuido.TabIndex = 27;
            this.btnRuido.Text = "Ruido";
            this.btnRuido.UseVisualStyleBackColor = false;
            this.btnRuido.Click += new System.EventHandler(this.btnRuido_Click);
            // 
            // txbR
            // 
            this.txbR.Location = new System.Drawing.Point(240, 136);
            this.txbR.Name = "txbR";
            this.txbR.Size = new System.Drawing.Size(24, 23);
            this.txbR.TabIndex = 28;
            this.txbR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.label8.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(200, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "RGB";
            // 
            // txbG
            // 
            this.txbG.Location = new System.Drawing.Point(272, 136);
            this.txbG.Name = "txbG";
            this.txbG.Size = new System.Drawing.Size(24, 23);
            this.txbG.TabIndex = 30;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(304, 136);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(24, 23);
            this.txbB.TabIndex = 31;
            // 
            // btnGradianteColores
            // 
            this.btnGradianteColores.BackColor = System.Drawing.Color.White;
            this.btnGradianteColores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnGradianteColores.FlatAppearance.BorderSize = 2;
            this.btnGradianteColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradianteColores.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGradianteColores.ForeColor = System.Drawing.Color.Black;
            this.btnGradianteColores.Location = new System.Drawing.Point(408, 856);
            this.btnGradianteColores.Name = "btnGradianteColores";
            this.btnGradianteColores.Size = new System.Drawing.Size(160, 32);
            this.btnGradianteColores.TabIndex = 32;
            this.btnGradianteColores.Text = "Gradientes de colores";
            this.btnGradianteColores.UseVisualStyleBackColor = false;
            this.btnGradianteColores.Click += new System.EventHandler(this.btnGradianteColores_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbB);
            this.panel1.Controls.Add(this.txbG);
            this.panel1.Controls.Add(this.txbR);
            this.panel1.Location = new System.Drawing.Point(40, 760);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 200);
            this.panel1.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1112, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Imagen original.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(640, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Imagen editada.";
            // 
            // tbContraste
            // 
            this.tbContraste.Location = new System.Drawing.Point(1064, 424);
            this.tbContraste.Name = "tbContraste";
            this.tbContraste.Size = new System.Drawing.Size(216, 45);
            this.tbContraste.TabIndex = 36;
            this.tbContraste.Value = 5;
            this.tbContraste.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbContraste_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1136, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Contraste";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1152, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 39;
            this.label12.Text = "Brillo";
            // 
            // tbBrillo
            // 
            this.tbBrillo.Location = new System.Drawing.Point(1072, 504);
            this.tbBrillo.Name = "tbBrillo";
            this.tbBrillo.Size = new System.Drawing.Size(216, 45);
            this.tbBrillo.TabIndex = 38;
            this.tbBrillo.Value = 5;
            this.tbBrillo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbBrillo_MouseUp);
            // 
            // FiltrosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbBrillo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbContraste);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGradianteColores);
            this.Controls.Add(this.btnRuido);
            this.Controls.Add(this.btnGamma);
            this.Controls.Add(this.btnColorizar);
            this.Controls.Add(this.btnEGrises);
            this.Controls.Add(this.btnACromatica);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnActivarCamara);
            this.Controls.Add(this.btn_CargarImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCamaras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FiltrosControl";
            this.Size = new System.Drawing.Size(1340, 994);
            this.Load += new System.EventHandler(this.FiltrosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCamaras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CargarImg;
        private System.Windows.Forms.Button btnActivarCamara;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnACromatica;
        private System.Windows.Forms.Button btnEGrises;
        private System.Windows.Forms.Button btnColorizar;
        private System.Windows.Forms.Button btnGamma;
        private System.Windows.Forms.Button btnRuido;
        private System.Windows.Forms.TextBox txbR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbG;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnGradianteColores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbContraste;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar tbBrillo;
    }
}
