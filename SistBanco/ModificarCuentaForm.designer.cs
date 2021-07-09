namespace Gerente
{
    partial class ModificarCuentaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nuevonipLbl = new System.Windows.Forms.Label();
            this.nuevoNipTxb = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.numCuentaComboBox = new System.Windows.Forms.ComboBox();
            numCuentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifica los datos de tu cuenta";
            // 
            // nuevonipLbl
            // 
            this.nuevonipLbl.AutoSize = true;
            this.nuevonipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevonipLbl.Location = new System.Drawing.Point(17, 95);
            this.nuevonipLbl.Name = "nuevonipLbl";
            this.nuevonipLbl.Size = new System.Drawing.Size(72, 16);
            this.nuevonipLbl.TabIndex = 1;
            this.nuevonipLbl.Text = "Nuevo Nip";
            // 
            // nuevoNipTxb
            // 
            this.nuevoNipTxb.Location = new System.Drawing.Point(20, 125);
            this.nuevoNipTxb.Name = "nuevoNipTxb";
            this.nuevoNipTxb.Size = new System.Drawing.Size(165, 20);
            this.nuevoNipTxb.TabIndex = 2;
            this.nuevoNipTxb.UseSystemPasswordChar = true;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(287, 163);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 3;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(13, 163);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 4;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
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
            // numCuentaLabel
            // 
            numCuentaLabel.AutoSize = true;
            numCuentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            numCuentaLabel.Location = new System.Drawing.Point(17, 46);
            numCuentaLabel.Name = "numCuentaLabel";
            numCuentaLabel.Size = new System.Drawing.Size(90, 17);
            numCuentaLabel.TabIndex = 6;
            numCuentaLabel.Text = "Num Cuenta:";
            // 
            // numCuentaComboBox
            // 
            this.numCuentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NumCuenta", true));
            this.numCuentaComboBox.DataSource = this.aTMTablaBindingSource;
            this.numCuentaComboBox.DisplayMember = "NumCuenta";
            this.numCuentaComboBox.FormattingEnabled = true;
            this.numCuentaComboBox.Location = new System.Drawing.Point(17, 71);
            this.numCuentaComboBox.Name = "numCuentaComboBox";
            this.numCuentaComboBox.Size = new System.Drawing.Size(121, 21);
            this.numCuentaComboBox.TabIndex = 7;
            // 
            // ModificarCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 206);
            this.Controls.Add(numCuentaLabel);
            this.Controls.Add(this.numCuentaComboBox);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.nuevoNipTxb);
            this.Controls.Add(this.nuevonipLbl);
            this.Controls.Add(this.label1);
            this.Name = "ModificarCuentaForm";
            this.Text = "ModificarCuentaForm";
            this.Load += new System.EventHandler(this.ModificarCuentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nuevonipLbl;
        private System.Windows.Forms.TextBox nuevoNipTxb;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private SistBanco.BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox numCuentaComboBox;
    }
}