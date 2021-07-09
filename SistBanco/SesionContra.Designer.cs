namespace SistBanco
{
    partial class SesionContra
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
            this.usuarioSesionTxb = new System.Windows.Forms.TextBox();
            this.contraSesionTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inicioSesionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioSesionTxb
            // 
            this.usuarioSesionTxb.Location = new System.Drawing.Point(60, 101);
            this.usuarioSesionTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuarioSesionTxb.Name = "usuarioSesionTxb";
            this.usuarioSesionTxb.Size = new System.Drawing.Size(321, 22);
            this.usuarioSesionTxb.TabIndex = 0;
            this.usuarioSesionTxb.TextChanged += new System.EventHandler(this.usuarioSesionTxb_TextChanged);
            // 
            // contraSesionTxb
            // 
            this.contraSesionTxb.Location = new System.Drawing.Point(60, 188);
            this.contraSesionTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contraSesionTxb.Name = "contraSesionTxb";
            this.contraSesionTxb.Size = new System.Drawing.Size(321, 22);
            this.contraSesionTxb.TabIndex = 1;
            this.contraSesionTxb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Introduzca su Usuario y Contraseña";
            // 
            // inicioSesionBtn
            // 
            this.inicioSesionBtn.Location = new System.Drawing.Point(344, 262);
            this.inicioSesionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioSesionBtn.Name = "inicioSesionBtn";
            this.inicioSesionBtn.Size = new System.Drawing.Size(100, 28);
            this.inicioSesionBtn.TabIndex = 5;
            this.inicioSesionBtn.Text = "Aceptar";
            this.inicioSesionBtn.UseVisualStyleBackColor = true;
            this.inicioSesionBtn.Click += new System.EventHandler(this.inicioSesionBtn_Click);
            // 
            // SesionContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 305);
            this.Controls.Add(this.inicioSesionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraSesionTxb);
            this.Controls.Add(this.usuarioSesionTxb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SesionContra";
            this.Text = "SesionContra";
            this.Load += new System.EventHandler(this.SesionContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioSesionTxb;
        private System.Windows.Forms.TextBox contraSesionTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inicioSesionBtn;
    }
}