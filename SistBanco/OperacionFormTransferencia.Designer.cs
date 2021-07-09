namespace SistBanco
{
    partial class OperacionFormTransferencia
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
            System.Windows.Forms.Label saldoLabel1;
            this.pantallaNumTxtb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.saldoTextBox1 = new System.Windows.Forms.TextBox();
            saldoLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pantallaNumTxtb
            // 
            this.pantallaNumTxtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pantallaNumTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.pantallaNumTxtb.Location = new System.Drawing.Point(21, 81);
            this.pantallaNumTxtb.Multiline = true;
            this.pantallaNumTxtb.Name = "pantallaNumTxtb";
            this.pantallaNumTxtb.ReadOnly = true;
            this.pantallaNumTxtb.Size = new System.Drawing.Size(221, 60);
            this.pantallaNumTxtb.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.aceptarBtn, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.borrarBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cancelarBtn, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(268, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 273);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptarBtn.BackColor = System.Drawing.Color.Green;
            this.aceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aceptarBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.aceptarBtn.Location = new System.Drawing.Point(3, 184);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(224, 86);
            this.aceptarBtn.TabIndex = 14;
            this.aceptarBtn.Text = "ACEPTAR";
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrarBtn.BackColor = System.Drawing.Color.Gold;
            this.borrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrarBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.borrarBtn.Location = new System.Drawing.Point(3, 93);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(224, 85);
            this.borrarBtn.TabIndex = 15;
            this.borrarBtn.Text = "BORRAR";
            this.borrarBtn.UseVisualStyleBackColor = false;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelarBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelarBtn.Location = new System.Drawing.Point(3, 3);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(224, 84);
            this.cancelarBtn.TabIndex = 16;
            this.cancelarBtn.Text = "CANCELAR";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 147);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 209);
            this.tableLayoutPanel2.TabIndex = 35;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 43);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ingrese cantidad de transacción";
            // 
            // bancoBDDataSet
            // 
            this.bancoBDDataSet.DataSetName = "BancoBDDataSet";
            this.bancoBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTMTablaBindingSource
            // 
            this.aTMTablaBindingSource.DataMember = "ATMTabla";
            this.aTMTablaBindingSource.DataSource = this.bancoBDDataSet;
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
            // saldoLabel1
            // 
            saldoLabel1.AutoSize = true;
            saldoLabel1.Location = new System.Drawing.Point(667, 213);
            saldoLabel1.Name = "saldoLabel1";
            saldoLabel1.Size = new System.Drawing.Size(37, 13);
            saldoLabel1.TabIndex = 40;
            saldoLabel1.Text = "Saldo:";
            // 
            // saldoTextBox1
            // 
            this.saldoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "Saldo", true));
            this.saldoTextBox1.Location = new System.Drawing.Point(710, 210);
            this.saldoTextBox1.Name = "saldoTextBox1";
            this.saldoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.saldoTextBox1.TabIndex = 41;
            // 
            // OperacionFormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 413);
            this.Controls.Add(saldoLabel1);
            this.Controls.Add(this.saldoTextBox1);
            this.Controls.Add(this.pantallaNumTxtb);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Name = "OperacionFormTransferencia";
            this.Text = "OperacionFormTransferencia";
            this.Load += new System.EventHandler(this.OperacionFormTransferencia_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pantallaNumTxtb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private System.Windows.Forms.Label label2;
        private BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox saldoTextBox1;
    }
}