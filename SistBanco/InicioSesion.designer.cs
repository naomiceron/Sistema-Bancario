namespace Cajero
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.inicioSesionPanel = new System.Windows.Forms.Panel();
            this.seleccionarModoLbl = new System.Windows.Forms.Label();
            this.atmBtn = new System.Windows.Forms.Button();
            this.cajeroBtn = new System.Windows.Forms.Button();
            this.gerenteBtn = new System.Windows.Forms.Button();
            this.inicioSesionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inicioSesionPanel
            // 
            this.inicioSesionPanel.Controls.Add(this.seleccionarModoLbl);
            this.inicioSesionPanel.Controls.Add(this.atmBtn);
            this.inicioSesionPanel.Controls.Add(this.cajeroBtn);
            this.inicioSesionPanel.Controls.Add(this.gerenteBtn);
            this.inicioSesionPanel.Location = new System.Drawing.Point(31, 47);
            this.inicioSesionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioSesionPanel.Name = "inicioSesionPanel";
            this.inicioSesionPanel.Size = new System.Drawing.Size(755, 508);
            this.inicioSesionPanel.TabIndex = 1;
            // 
            // seleccionarModoLbl
            // 
            this.seleccionarModoLbl.AutoSize = true;
            this.seleccionarModoLbl.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarModoLbl.Location = new System.Drawing.Point(4, 12);
            this.seleccionarModoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seleccionarModoLbl.Name = "seleccionarModoLbl";
            this.seleccionarModoLbl.Size = new System.Drawing.Size(355, 55);
            this.seleccionarModoLbl.TabIndex = 3;
            this.seleccionarModoLbl.Text = "Seleccionar Modo";
            // 
            // atmBtn
            // 
            this.atmBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.atmBtn.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmBtn.Image = ((System.Drawing.Image)(resources.GetObject("atmBtn.Image")));
            this.atmBtn.Location = new System.Drawing.Point(188, 367);
            this.atmBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmBtn.Name = "atmBtn";
            this.atmBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.atmBtn.Size = new System.Drawing.Size(369, 130);
            this.atmBtn.TabIndex = 2;
            this.atmBtn.Text = "ATM";
            this.atmBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.atmBtn.UseVisualStyleBackColor = false;
            this.atmBtn.Click += new System.EventHandler(this.atmBtn_Click);
            // 
            // cajeroBtn
            // 
            this.cajeroBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cajeroBtn.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajeroBtn.Image = ((System.Drawing.Image)(resources.GetObject("cajeroBtn.Image")));
            this.cajeroBtn.Location = new System.Drawing.Point(188, 228);
            this.cajeroBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cajeroBtn.Name = "cajeroBtn";
            this.cajeroBtn.Size = new System.Drawing.Size(369, 132);
            this.cajeroBtn.TabIndex = 1;
            this.cajeroBtn.Text = "Cajero";
            this.cajeroBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cajeroBtn.UseVisualStyleBackColor = false;
            this.cajeroBtn.Click += new System.EventHandler(this.cajeroBtn_Click);
            // 
            // gerenteBtn
            // 
            this.gerenteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gerenteBtn.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenteBtn.Image = ((System.Drawing.Image)(resources.GetObject("gerenteBtn.Image")));
            this.gerenteBtn.Location = new System.Drawing.Point(188, 94);
            this.gerenteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerenteBtn.Name = "gerenteBtn";
            this.gerenteBtn.Size = new System.Drawing.Size(369, 127);
            this.gerenteBtn.TabIndex = 0;
            this.gerenteBtn.Text = "Gerente";
            this.gerenteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gerenteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gerenteBtn.UseVisualStyleBackColor = false;
            this.gerenteBtn.Click += new System.EventHandler(this.gerenteBtn_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 602);
            this.Controls.Add(this.inicioSesionPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InicioSesion";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.inicioSesionPanel.ResumeLayout(false);
            this.inicioSesionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inicioSesionPanel;
        private System.Windows.Forms.Label seleccionarModoLbl;
        private System.Windows.Forms.Button atmBtn;
        private System.Windows.Forms.Button cajeroBtn;
        private System.Windows.Forms.Button gerenteBtn;
    }
}

