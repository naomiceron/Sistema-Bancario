namespace ATM
{
    partial class PreguntaForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numCuentaLabel;
            System.Windows.Forms.Label saldoLabel;
            this.numeroTxtb = new System.Windows.Forms.TextBox();
            this.preguntaLbl = new System.Windows.Forms.Label();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.n0Btn = new System.Windows.Forms.Button();
            this.n9Btn = new System.Windows.Forms.Button();
            this.n8Btn = new System.Windows.Forms.Button();
            this.n7Btn = new System.Windows.Forms.Button();
            this.n6Btn = new System.Windows.Forms.Button();
            this.n5Btn = new System.Windows.Forms.Button();
            this.n4Btn = new System.Windows.Forms.Button();
            this.n3Btn = new System.Windows.Forms.Button();
            this.n1Btn = new System.Windows.Forms.Button();
            this.n2Btn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.numCuentaLabel1 = new System.Windows.Forms.Label();
            this.saldoLabel1 = new System.Windows.Forms.Label();
            numCuentaLabel = new System.Windows.Forms.Label();
            saldoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // numCuentaLabel
            // 
            numCuentaLabel.AutoSize = true;
            numCuentaLabel.Location = new System.Drawing.Point(482, 226);
            numCuentaLabel.Name = "numCuentaLabel";
            numCuentaLabel.Size = new System.Drawing.Size(69, 13);
            numCuentaLabel.TabIndex = 29;
            numCuentaLabel.Text = "Num Cuenta:";
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Location = new System.Drawing.Point(482, 258);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(37, 13);
            saldoLabel.TabIndex = 30;
            saldoLabel.Text = "Saldo:";
            // 
            // numeroTxtb
            // 
            this.numeroTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTxtb.Location = new System.Drawing.Point(35, 96);
            this.numeroTxtb.Multiline = true;
            this.numeroTxtb.Name = "numeroTxtb";
            this.numeroTxtb.ReadOnly = true;
            this.numeroTxtb.Size = new System.Drawing.Size(158, 37);
            this.numeroTxtb.TabIndex = 0;
            // 
            // preguntaLbl
            // 
            this.preguntaLbl.AutoSize = true;
            this.preguntaLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preguntaLbl.Location = new System.Drawing.Point(48, 56);
            this.preguntaLbl.Name = "preguntaLbl";
            this.preguntaLbl.Size = new System.Drawing.Size(0, 20);
            this.preguntaLbl.TabIndex = 1;
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Location = new System.Drawing.Point(201, 352);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(75, 23);
            this.siguienteBtn.TabIndex = 2;
            this.siguienteBtn.Text = "Siguiente";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.n0Btn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.n9Btn, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.n8Btn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.n7Btn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.n6Btn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.n5Btn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.n4Btn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.n3Btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.n1Btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.n2Btn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 209);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // n0Btn
            // 
            this.n0Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n0Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0Btn.Location = new System.Drawing.Point(85, 159);
            this.n0Btn.Name = "n0Btn";
            this.n0Btn.Size = new System.Drawing.Size(76, 47);
            this.n0Btn.TabIndex = 14;
            this.n0Btn.Text = "0";
            this.n0Btn.UseVisualStyleBackColor = true;
            this.n0Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n9Btn
            // 
            this.n9Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n9Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9Btn.Location = new System.Drawing.Point(167, 107);
            this.n9Btn.Name = "n9Btn";
            this.n9Btn.Size = new System.Drawing.Size(77, 46);
            this.n9Btn.TabIndex = 5;
            this.n9Btn.Text = "9";
            this.n9Btn.UseVisualStyleBackColor = true;
            this.n9Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n8Btn
            // 
            this.n8Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n8Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8Btn.Location = new System.Drawing.Point(85, 107);
            this.n8Btn.Name = "n8Btn";
            this.n8Btn.Size = new System.Drawing.Size(76, 46);
            this.n8Btn.TabIndex = 6;
            this.n8Btn.Text = "8";
            this.n8Btn.UseVisualStyleBackColor = true;
            this.n8Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n7Btn
            // 
            this.n7Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n7Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7Btn.Location = new System.Drawing.Point(3, 107);
            this.n7Btn.Name = "n7Btn";
            this.n7Btn.Size = new System.Drawing.Size(76, 46);
            this.n7Btn.TabIndex = 7;
            this.n7Btn.Text = "7";
            this.n7Btn.UseVisualStyleBackColor = true;
            this.n7Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n6Btn
            // 
            this.n6Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6Btn.Location = new System.Drawing.Point(167, 55);
            this.n6Btn.Name = "n6Btn";
            this.n6Btn.Size = new System.Drawing.Size(77, 46);
            this.n6Btn.TabIndex = 8;
            this.n6Btn.Text = "6";
            this.n6Btn.UseVisualStyleBackColor = true;
            this.n6Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n5Btn
            // 
            this.n5Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5Btn.Location = new System.Drawing.Point(85, 55);
            this.n5Btn.Name = "n5Btn";
            this.n5Btn.Size = new System.Drawing.Size(76, 46);
            this.n5Btn.TabIndex = 9;
            this.n5Btn.Text = "5";
            this.n5Btn.UseVisualStyleBackColor = true;
            this.n5Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n4Btn
            // 
            this.n4Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4Btn.Location = new System.Drawing.Point(3, 55);
            this.n4Btn.Name = "n4Btn";
            this.n4Btn.Size = new System.Drawing.Size(76, 46);
            this.n4Btn.TabIndex = 10;
            this.n4Btn.Text = "4";
            this.n4Btn.UseVisualStyleBackColor = true;
            this.n4Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n3Btn
            // 
            this.n3Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3Btn.Location = new System.Drawing.Point(167, 3);
            this.n3Btn.Name = "n3Btn";
            this.n3Btn.Size = new System.Drawing.Size(77, 46);
            this.n3Btn.TabIndex = 11;
            this.n3Btn.Text = "3";
            this.n3Btn.UseVisualStyleBackColor = true;
            this.n3Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n1Btn
            // 
            this.n1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1Btn.Location = new System.Drawing.Point(3, 3);
            this.n1Btn.Name = "n1Btn";
            this.n1Btn.Size = new System.Drawing.Size(76, 46);
            this.n1Btn.TabIndex = 13;
            this.n1Btn.Text = "1";
            this.n1Btn.UseVisualStyleBackColor = true;
            this.n1Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // n2Btn
            // 
            this.n2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2Btn.Location = new System.Drawing.Point(85, 3);
            this.n2Btn.Name = "n2Btn";
            this.n2Btn.Size = new System.Drawing.Size(76, 46);
            this.n2Btn.TabIndex = 12;
            this.n2Btn.Text = "2";
            this.n2Btn.UseVisualStyleBackColor = true;
            this.n2Btn.Click += new System.EventHandler(this.numero_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.borrarBtn.Location = new System.Drawing.Point(201, 96);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(75, 37);
            this.borrarBtn.TabIndex = 27;
            this.borrarBtn.Text = "←";
            this.borrarBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(35, 352);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 28;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.aTMTablaBindingSource;
            this.listBox1.DisplayMember = "NumCuenta";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(494, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 29;
            // 
            // aTMTablaBindingSource
            // 
            this.aTMTablaBindingSource.DataMember = "ATMTabla";
            this.aTMTablaBindingSource.DataSource = this.bancoBDDataSet;
            // 
            // bancoBDDataSet
            // 
            this.bancoBDDataSet.DataSetName = "BancoBDDataSet";
            this.bancoBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTMTablaTableAdapter
            // 
            this.aTMTablaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATMTablaTableAdapter = this.aTMTablaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajeroTablaTableAdapter = null;
            this.tableAdapterManager.GerenteTablaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numCuentaLabel1
            // 
            this.numCuentaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NumCuenta", true));
            this.numCuentaLabel1.Location = new System.Drawing.Point(557, 226);
            this.numCuentaLabel1.Name = "numCuentaLabel1";
            this.numCuentaLabel1.Size = new System.Drawing.Size(100, 23);
            this.numCuentaLabel1.TabIndex = 30;
            this.numCuentaLabel1.Text = "label1";
            // 
            // saldoLabel1
            // 
            this.saldoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "Saldo", true));
            this.saldoLabel1.Location = new System.Drawing.Point(541, 258);
            this.saldoLabel1.Name = "saldoLabel1";
            this.saldoLabel1.Size = new System.Drawing.Size(100, 23);
            this.saldoLabel1.TabIndex = 31;
            this.saldoLabel1.Text = "label1";
            // 
            // PreguntaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 395);
            this.Controls.Add(saldoLabel);
            this.Controls.Add(this.saldoLabel1);
            this.Controls.Add(numCuentaLabel);
            this.Controls.Add(this.numCuentaLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.preguntaLbl);
            this.Controls.Add(this.numeroTxtb);
            this.Name = "PreguntaForm";
            this.Text = "PreguntaForm";
            this.Load += new System.EventHandler(this.PreguntaForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeroTxtb;
        private System.Windows.Forms.Label preguntaLbl;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button n0Btn;
        private System.Windows.Forms.Button n9Btn;
        private System.Windows.Forms.Button n8Btn;
        private System.Windows.Forms.Button n7Btn;
        private System.Windows.Forms.Button n6Btn;
        private System.Windows.Forms.Button n5Btn;
        private System.Windows.Forms.Button n4Btn;
        private System.Windows.Forms.Button n3Btn;
        private System.Windows.Forms.Button n1Btn;
        private System.Windows.Forms.Button n2Btn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.ListBox listBox1;
        private SistBanco.BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label numCuentaLabel1;
        private System.Windows.Forms.Label saldoLabel1;
    }
}