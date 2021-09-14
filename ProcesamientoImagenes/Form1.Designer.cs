
namespace ProcesamientoImagenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDeteccion = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeControl1 = new ProcesamientoImagenes.HomeControl();
            this.deteccionMovController1 = new ProcesamientoImagenes.DeteccionMovController();
            this.filtrosControl1 = new ProcesamientoImagenes.FiltrosControl();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.panelMenu.Controls.Add(this.sidePanel);
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnDeteccion);
            this.panelMenu.Controls.Add(this.btnFoto);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(100, 1024);
            this.panelMenu.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(8, 138);
            this.sidePanel.TabIndex = 4;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(0, 886);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(100, 138);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // btnDeteccion
            // 
            this.btnDeteccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeteccion.FlatAppearance.BorderSize = 0;
            this.btnDeteccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeteccion.Image = ((System.Drawing.Image)(resources.GetObject("btnDeteccion.Image")));
            this.btnDeteccion.Location = new System.Drawing.Point(0, 276);
            this.btnDeteccion.Name = "btnDeteccion";
            this.btnDeteccion.Size = new System.Drawing.Size(100, 138);
            this.btnDeteccion.TabIndex = 2;
            this.btnDeteccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDeteccion.UseVisualStyleBackColor = true;
            this.btnDeteccion.Click += new System.EventHandler(this.btnDeteccion_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.Location = new System.Drawing.Point(0, 138);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(100, 138);
            this.btnFoto.TabIndex = 1;
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 138);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(100, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1340, 30);
            this.panelSuperior.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeControl1);
            this.panel1.Controls.Add(this.deteccionMovController1);
            this.panel1.Controls.Add(this.filtrosControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 994);
            this.panel1.TabIndex = 2;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.White;
            this.homeControl1.Location = new System.Drawing.Point(0, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1340, 994);
            this.homeControl1.TabIndex = 0;
            // 
            // deteccionMovController1
            // 
            this.deteccionMovController1.Location = new System.Drawing.Point(0, 0);
            this.deteccionMovController1.Name = "deteccionMovController1";
            this.deteccionMovController1.Size = new System.Drawing.Size(1340, 994);
            this.deteccionMovController1.TabIndex = 1;
            // 
            // filtrosControl1
            // 
            this.filtrosControl1.Location = new System.Drawing.Point(0, 0);
            this.filtrosControl1.Name = "filtrosControl1";
            this.filtrosControl1.Size = new System.Drawing.Size(1340, 994);
            this.filtrosControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnDeteccion;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panel1;
        private HomeControl homeControl1;
        private System.Windows.Forms.Panel sidePanel;
        private DeteccionMovController deteccionMovController1;
        private FiltrosControl filtrosControl1;
    }
}

