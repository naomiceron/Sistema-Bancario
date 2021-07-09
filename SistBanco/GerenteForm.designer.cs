namespace Gerente
{
    partial class GerenteForm
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
            this.regresarBtn = new System.Windows.Forms.Button();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this.buscarClienteBtn = new System.Windows.Forms.Button();
            this.modificarClienteBtn = new System.Windows.Forms.Button();
            this.altaClienteBtn = new System.Windows.Forms.Button();
            this.operacionesBtn = new System.Windows.Forms.Button();
            this.altaCuentaBtn = new System.Windows.Forms.Button();
            this.modificarCuentaBtn = new System.Windows.Forms.Button();
            this.buscarCuentaBtn = new System.Windows.Forms.Button();
            this.asignarCuentaBtn = new System.Windows.Forms.Button();
            this.cuentaGroupBox = new System.Windows.Forms.GroupBox();
            this.clienteGroupBox.SuspendLayout();
            this.cuentaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // regresarBtn
            // 
            this.regresarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBtn.Location = new System.Drawing.Point(24, 339);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(145, 70);
            this.regresarBtn.TabIndex = 0;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.UseVisualStyleBackColor = true;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Controls.Add(this.buscarClienteBtn);
            this.clienteGroupBox.Controls.Add(this.modificarClienteBtn);
            this.clienteGroupBox.Controls.Add(this.altaClienteBtn);
            this.clienteGroupBox.Location = new System.Drawing.Point(12, 12);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(504, 106);
            this.clienteGroupBox.TabIndex = 1;
            this.clienteGroupBox.TabStop = false;
            this.clienteGroupBox.Text = "Cliente";
            // 
            // buscarClienteBtn
            // 
            this.buscarClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarClienteBtn.Location = new System.Drawing.Point(347, 19);
            this.buscarClienteBtn.Name = "buscarClienteBtn";
            this.buscarClienteBtn.Size = new System.Drawing.Size(151, 63);
            this.buscarClienteBtn.TabIndex = 4;
            this.buscarClienteBtn.Text = "Buscar";
            this.buscarClienteBtn.UseVisualStyleBackColor = true;
            this.buscarClienteBtn.Click += new System.EventHandler(this.buscarClienteBtn_Click);
            // 
            // modificarClienteBtn
            // 
            this.modificarClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarClienteBtn.Location = new System.Drawing.Point(180, 19);
            this.modificarClienteBtn.Name = "modificarClienteBtn";
            this.modificarClienteBtn.Size = new System.Drawing.Size(151, 63);
            this.modificarClienteBtn.TabIndex = 3;
            this.modificarClienteBtn.Text = "Modificar";
            this.modificarClienteBtn.UseVisualStyleBackColor = true;
            this.modificarClienteBtn.Click += new System.EventHandler(this.modificarClienteBtn_Click);
            // 
            // altaClienteBtn
            // 
            this.altaClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaClienteBtn.Location = new System.Drawing.Point(6, 19);
            this.altaClienteBtn.Name = "altaClienteBtn";
            this.altaClienteBtn.Size = new System.Drawing.Size(151, 63);
            this.altaClienteBtn.TabIndex = 2;
            this.altaClienteBtn.Text = "Dar de alta";
            this.altaClienteBtn.UseVisualStyleBackColor = true;
            this.altaClienteBtn.Click += new System.EventHandler(this.altaClienteBtn_Click);
            // 
            // operacionesBtn
            // 
            this.operacionesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionesBtn.Location = new System.Drawing.Point(359, 336);
            this.operacionesBtn.Name = "operacionesBtn";
            this.operacionesBtn.Size = new System.Drawing.Size(151, 70);
            this.operacionesBtn.TabIndex = 1;
            this.operacionesBtn.Text = "Operaciones";
            this.operacionesBtn.UseVisualStyleBackColor = true;
            this.operacionesBtn.Click += new System.EventHandler(this.operacionesBtn_Click);
            // 
            // altaCuentaBtn
            // 
            this.altaCuentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaCuentaBtn.Location = new System.Drawing.Point(47, 21);
            this.altaCuentaBtn.Name = "altaCuentaBtn";
            this.altaCuentaBtn.Size = new System.Drawing.Size(197, 76);
            this.altaCuentaBtn.TabIndex = 5;
            this.altaCuentaBtn.Text = "Dar de alta";
            this.altaCuentaBtn.UseVisualStyleBackColor = true;
            this.altaCuentaBtn.Click += new System.EventHandler(this.altaCuentaBtn_Click);
            // 
            // modificarCuentaBtn
            // 
            this.modificarCuentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarCuentaBtn.Location = new System.Drawing.Point(264, 21);
            this.modificarCuentaBtn.Name = "modificarCuentaBtn";
            this.modificarCuentaBtn.Size = new System.Drawing.Size(197, 76);
            this.modificarCuentaBtn.TabIndex = 6;
            this.modificarCuentaBtn.Text = "Modificar";
            this.modificarCuentaBtn.UseVisualStyleBackColor = true;
            this.modificarCuentaBtn.Click += new System.EventHandler(this.modificarCuentaBtn_Click);
            // 
            // buscarCuentaBtn
            // 
            this.buscarCuentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuentaBtn.Location = new System.Drawing.Point(47, 109);
            this.buscarCuentaBtn.Name = "buscarCuentaBtn";
            this.buscarCuentaBtn.Size = new System.Drawing.Size(197, 76);
            this.buscarCuentaBtn.TabIndex = 7;
            this.buscarCuentaBtn.Text = "Buscar";
            this.buscarCuentaBtn.UseVisualStyleBackColor = true;
            this.buscarCuentaBtn.Click += new System.EventHandler(this.buscarCuentaBtn_Click);
            // 
            // asignarCuentaBtn
            // 
            this.asignarCuentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignarCuentaBtn.Location = new System.Drawing.Point(264, 109);
            this.asignarCuentaBtn.Name = "asignarCuentaBtn";
            this.asignarCuentaBtn.Size = new System.Drawing.Size(197, 76);
            this.asignarCuentaBtn.TabIndex = 8;
            this.asignarCuentaBtn.Text = "Asignar";
            this.asignarCuentaBtn.UseVisualStyleBackColor = true;
            this.asignarCuentaBtn.Click += new System.EventHandler(this.asignarCuentaBtn_Click);
            // 
            // cuentaGroupBox
            // 
            this.cuentaGroupBox.Controls.Add(this.asignarCuentaBtn);
            this.cuentaGroupBox.Controls.Add(this.altaCuentaBtn);
            this.cuentaGroupBox.Controls.Add(this.buscarCuentaBtn);
            this.cuentaGroupBox.Controls.Add(this.modificarCuentaBtn);
            this.cuentaGroupBox.Location = new System.Drawing.Point(12, 124);
            this.cuentaGroupBox.Name = "cuentaGroupBox";
            this.cuentaGroupBox.Size = new System.Drawing.Size(504, 206);
            this.cuentaGroupBox.TabIndex = 2;
            this.cuentaGroupBox.TabStop = false;
            this.cuentaGroupBox.Text = "Cuenta";
            // 
            // GerenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 421);
            this.Controls.Add(this.cuentaGroupBox);
            this.Controls.Add(this.clienteGroupBox);
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.operacionesBtn);
            this.Name = "GerenteForm";
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.GerenteForm_Load);
            this.clienteGroupBox.ResumeLayout(false);
            this.cuentaGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regresarBtn;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.Button asignarCuentaBtn;
        private System.Windows.Forms.Button buscarCuentaBtn;
        private System.Windows.Forms.Button modificarCuentaBtn;
        private System.Windows.Forms.Button altaCuentaBtn;
        private System.Windows.Forms.Button buscarClienteBtn;
        private System.Windows.Forms.Button modificarClienteBtn;
        private System.Windows.Forms.Button altaClienteBtn;
        private System.Windows.Forms.Button operacionesBtn;
        private System.Windows.Forms.GroupBox cuentaGroupBox;
    }
}

