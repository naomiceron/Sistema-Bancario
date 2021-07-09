namespace ATM
{
    partial class ConsultaForm
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
            this.numCuentaLbl = new System.Windows.Forms.Label();
            this.saldoLbl = new System.Windows.Forms.Label();
            this.regresarBtn = new System.Windows.Forms.Button();
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.saldoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tu saldo es:";
            // 
            // numCuentaLbl
            // 
            this.numCuentaLbl.AutoSize = true;
            this.numCuentaLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCuentaLbl.Location = new System.Drawing.Point(132, 39);
            this.numCuentaLbl.Name = "numCuentaLbl";
            this.numCuentaLbl.Size = new System.Drawing.Size(0, 18);
            this.numCuentaLbl.TabIndex = 2;
            // 
            // saldoLbl
            // 
            this.saldoLbl.AutoSize = true;
            this.saldoLbl.Font = new System.Drawing.Font("Arial", 12F);
            this.saldoLbl.Location = new System.Drawing.Point(135, 106);
            this.saldoLbl.Name = "saldoLbl";
            this.saldoLbl.Size = new System.Drawing.Size(0, 18);
            this.saldoLbl.TabIndex = 3;
            // 
            // regresarBtn
            // 
            this.regresarBtn.Location = new System.Drawing.Point(13, 151);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(75, 23);
            this.regresarBtn.TabIndex = 4;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.UseVisualStyleBackColor = true;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
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
            this.saldoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "Saldo", true));
            this.saldoLabel1.Location = new System.Drawing.Point(119, 105);
            this.saldoLabel1.Name = "saldoLabel1";
            this.saldoLabel1.Size = new System.Drawing.Size(100, 23);
            this.saldoLabel1.TabIndex = 6;
            this.saldoLabel1.Text = "label3";
            // 
            // ConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 194);
            this.Controls.Add(this.saldoLabel1);
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.saldoLbl);
            this.Controls.Add(this.numCuentaLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaForm";
            this.Text = "ConsultaForm";
            this.Load += new System.EventHandler(this.ConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numCuentaLbl;
        private System.Windows.Forms.Label saldoLbl;
        private System.Windows.Forms.Button regresarBtn;
        private SistBanco.BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label saldoLabel1;
    }
}