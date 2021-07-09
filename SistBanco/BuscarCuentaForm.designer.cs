namespace Gerente
{
    partial class BuscarCuentaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuentaLbl = new System.Windows.Forms.Label();
            this.saldoLbl = new System.Windows.Forms.Label();
            this.regresarBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.bancoBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.aTMTablaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.numCuentaLabel1 = new System.Windows.Forms.Label();
            this.saldoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cuenta a buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo";
            // 
            // cuentaLbl
            // 
            this.cuentaLbl.AutoSize = true;
            this.cuentaLbl.Location = new System.Drawing.Point(20, 137);
            this.cuentaLbl.Name = "cuentaLbl";
            this.cuentaLbl.Size = new System.Drawing.Size(0, 13);
            this.cuentaLbl.TabIndex = 4;
            // 
            // saldoLbl
            // 
            this.saldoLbl.AutoSize = true;
            this.saldoLbl.Location = new System.Drawing.Point(20, 205);
            this.saldoLbl.Name = "saldoLbl";
            this.saldoLbl.Size = new System.Drawing.Size(0, 13);
            this.saldoLbl.TabIndex = 5;
            // 
            // regresarBtn
            // 
            this.regresarBtn.Location = new System.Drawing.Point(21, 195);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(75, 23);
            this.regresarBtn.TabIndex = 6;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.UseVisualStyleBackColor = true;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.aTMTablaBindingSource1;
            this.comboBox1.DisplayMember = "NumCuenta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // bancoBDDataSet
            // 
            this.bancoBDDataSet.DataSetName = "BancoBDDataSet";
            this.bancoBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoBDDataSetBindingSource
            // 
            this.bancoBDDataSetBindingSource.DataSource = this.bancoBDDataSet;
            this.bancoBDDataSetBindingSource.Position = 0;
            // 
            // aTMTablaBindingSource
            // 
            this.aTMTablaBindingSource.DataMember = "ATMTabla";
            this.aTMTablaBindingSource.DataSource = this.bancoBDDataSetBindingSource;
            // 
            // aTMTablaTableAdapter
            // 
            this.aTMTablaTableAdapter.ClearBeforeFill = true;
            // 
            // aTMTablaBindingSource1
            // 
            this.aTMTablaBindingSource1.DataMember = "ATMTabla";
            this.aTMTablaBindingSource1.DataSource = this.bancoBDDataSet;
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
            this.numCuentaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource1, "NumCuenta", true));
            this.numCuentaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numCuentaLabel1.Location = new System.Drawing.Point(105, 101);
            this.numCuentaLabel1.Name = "numCuentaLabel1";
            this.numCuentaLabel1.Size = new System.Drawing.Size(144, 23);
            this.numCuentaLabel1.TabIndex = 8;
            this.numCuentaLabel1.Text = "label4";
            // 
            // saldoLabel1
            // 
            this.saldoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource1, "Saldo", true));
            this.saldoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.saldoLabel1.Location = new System.Drawing.Point(105, 150);
            this.saldoLabel1.Name = "saldoLabel1";
            this.saldoLabel1.Size = new System.Drawing.Size(144, 23);
            this.saldoLabel1.TabIndex = 9;
            this.saldoLabel1.Text = "label4";
            // 
            // BuscarCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 236);
            this.Controls.Add(this.saldoLabel1);
            this.Controls.Add(this.numCuentaLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.saldoLbl);
            this.Controls.Add(this.cuentaLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarCuentaForm";
            this.Text = "BuscarCuentaForm";
            this.Load += new System.EventHandler(this.BuscarCuentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cuentaLbl;
        private System.Windows.Forms.Label saldoLbl;
        private System.Windows.Forms.Button regresarBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bancoBDDataSetBindingSource;
        private SistBanco.BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource1;
        private SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label numCuentaLabel1;
        private System.Windows.Forms.Label saldoLabel1;
    }
}