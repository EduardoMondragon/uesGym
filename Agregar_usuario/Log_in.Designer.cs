namespace Agregar_usuario
{
    partial class Log_in
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSesion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.transparentControl1 = new TransControl_src.TransparentControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.transparentControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 25F);
            this.label1.Location = new System.Drawing.Point(157, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 25F);
            this.label2.Location = new System.Drawing.Point(194, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 57);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(40, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(560, 57);
            this.textBox2.TabIndex = 4;
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.Coral;
            this.btnSesion.Font = new System.Drawing.Font("Candara", 25F);
            this.btnSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSesion.Location = new System.Drawing.Point(212, 423);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(214, 66);
            this.btnSesion.TabIndex = 6;
            this.btnSesion.Text = "Iniciar Sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Agregar_usuario.Properties.Resources.WhatsApp_Image_2018_02_13_at_4_31_39_PM;
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2152, 1054);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // transparentControl1
            // 
            this.transparentControl1.Controls.Add(this.textBox1);
            this.transparentControl1.Controls.Add(this.btnSesion);
            this.transparentControl1.Controls.Add(this.label1);
            this.transparentControl1.Controls.Add(this.textBox2);
            this.transparentControl1.Controls.Add(this.label2);
            this.transparentControl1.ForeColor = System.Drawing.Color.Black;
            this.transparentControl1.Location = new System.Drawing.Point(802, 177);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.1D;
            this.transparentControl1.Size = new System.Drawing.Size(628, 568);
            this.transparentControl1.TabIndex = 8;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            this.transparentControl1.TransparentColor = System.Drawing.Color.Black;
            this.transparentControl1.Click += new System.EventHandler(this.transparentControl1_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 811);
            this.Controls.Add(this.transparentControl1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_in";
            this.Text = "Log_in";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.transparentControl1.ResumeLayout(false);
            this.transparentControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private TransControl_src.TransparentControl transparentControl1;
    }
}