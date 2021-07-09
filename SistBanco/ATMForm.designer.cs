namespace ATM
{
    partial class ATMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.regresarBtn = new System.Windows.Forms.Button();
            this.recargaBtn = new System.Windows.Forms.Button();
            this.transferenciaBtn = new System.Windows.Forms.Button();
            this.depositoBtn = new System.Windows.Forms.Button();
            this.consultaBtn = new System.Windows.Forms.Button();
            this.retiroBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.regresarBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.recargaBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.transferenciaBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.depositoBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.consultaBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.retiroBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // regresarBtn
            // 
            this.regresarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regresarBtn.Font = new System.Drawing.Font("Arial Narrow", 39.75F);
            this.regresarBtn.Image = ((System.Drawing.Image)(resources.GetObject("regresarBtn.Image")));
            this.regresarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regresarBtn.Location = new System.Drawing.Point(3, 271);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(289, 128);
            this.regresarBtn.TabIndex = 3;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regresarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regresarBtn.UseVisualStyleBackColor = true;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
            // 
            // recargaBtn
            // 
            this.recargaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recargaBtn.Font = new System.Drawing.Font("Arial Narrow", 39.75F);
            this.recargaBtn.Image = ((System.Drawing.Image)(resources.GetObject("recargaBtn.Image")));
            this.recargaBtn.Location = new System.Drawing.Point(298, 271);
            this.recargaBtn.Name = "recargaBtn";
            this.recargaBtn.Size = new System.Drawing.Size(289, 128);
            this.recargaBtn.TabIndex = 4;
            this.recargaBtn.Text = "Recarga";
            this.recargaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.recargaBtn.UseVisualStyleBackColor = true;
            this.recargaBtn.Click += new System.EventHandler(this.recargaBtn_Click);
            // 
            // transferenciaBtn
            // 
            this.transferenciaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transferenciaBtn.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferenciaBtn.Image = ((System.Drawing.Image)(resources.GetObject("transferenciaBtn.Image")));
            this.transferenciaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transferenciaBtn.Location = new System.Drawing.Point(298, 137);
            this.transferenciaBtn.Name = "transferenciaBtn";
            this.transferenciaBtn.Size = new System.Drawing.Size(289, 128);
            this.transferenciaBtn.TabIndex = 3;
            this.transferenciaBtn.Text = "Transferencia";
            this.transferenciaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transferenciaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.transferenciaBtn.UseVisualStyleBackColor = true;
            this.transferenciaBtn.Click += new System.EventHandler(this.transferenciaBtn_Click);
            // 
            // depositoBtn
            // 
            this.depositoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depositoBtn.Font = new System.Drawing.Font("Arial Narrow", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositoBtn.Image = ((System.Drawing.Image)(resources.GetObject("depositoBtn.Image")));
            this.depositoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depositoBtn.Location = new System.Drawing.Point(298, 3);
            this.depositoBtn.Name = "depositoBtn";
            this.depositoBtn.Size = new System.Drawing.Size(289, 128);
            this.depositoBtn.TabIndex = 1;
            this.depositoBtn.Text = "Deposito";
            this.depositoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depositoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.depositoBtn.UseVisualStyleBackColor = true;
            this.depositoBtn.Click += new System.EventHandler(this.depositoBtn_Click);
            // 
            // consultaBtn
            // 
            this.consultaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultaBtn.Font = new System.Drawing.Font("Arial Narrow", 39.75F);
            this.consultaBtn.Image = ((System.Drawing.Image)(resources.GetObject("consultaBtn.Image")));
            this.consultaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultaBtn.Location = new System.Drawing.Point(3, 137);
            this.consultaBtn.Name = "consultaBtn";
            this.consultaBtn.Size = new System.Drawing.Size(289, 128);
            this.consultaBtn.TabIndex = 2;
            this.consultaBtn.Text = "Consulta";
            this.consultaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consultaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.consultaBtn.UseVisualStyleBackColor = true;
            this.consultaBtn.Click += new System.EventHandler(this.consultaBtn_Click);
            // 
            // retiroBtn
            // 
            this.retiroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retiroBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.retiroBtn.Font = new System.Drawing.Font("Arial Narrow", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retiroBtn.Image = ((System.Drawing.Image)(resources.GetObject("retiroBtn.Image")));
            this.retiroBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retiroBtn.Location = new System.Drawing.Point(3, 3);
            this.retiroBtn.Name = "retiroBtn";
            this.retiroBtn.Size = new System.Drawing.Size(289, 128);
            this.retiroBtn.TabIndex = 0;
            this.retiroBtn.Text = "Retiro";
            this.retiroBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.retiroBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.retiroBtn.UseVisualStyleBackColor = false;
            this.retiroBtn.Click += new System.EventHandler(this.retiroBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la operación a realizar";
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ATMForm";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATMForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button regresarBtn;
        private System.Windows.Forms.Button transferenciaBtn;
        private System.Windows.Forms.Button consultaBtn;
        private System.Windows.Forms.Button depositoBtn;
        private System.Windows.Forms.Button retiroBtn;
        private System.Windows.Forms.Button recargaBtn;
        private System.Windows.Forms.Label label1;
    }
}

