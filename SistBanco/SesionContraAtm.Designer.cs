namespace SistBanco
{
    partial class SesionContraAtm
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
            System.Windows.Forms.Label nIPLabel;
            System.Windows.Forms.Label numClienteLabel;
            this.inicioSesionAtmBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contraSesionTxb = new System.Windows.Forms.TextBox();
            this.usuarioSesionTxb = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.nIPTextBox = new System.Windows.Forms.TextBox();
            this.numClienteTextBox = new System.Windows.Forms.TextBox();
            nIPLabel = new System.Windows.Forms.Label();
            numClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nIPLabel
            // 
            nIPLabel.AutoSize = true;
            nIPLabel.Location = new System.Drawing.Point(494, 186);
            nIPLabel.Name = "nIPLabel";
            nIPLabel.Size = new System.Drawing.Size(28, 13);
            nIPLabel.TabIndex = 12;
            nIPLabel.Text = "NIP:";
            // 
            // inicioSesionAtmBtn
            // 
            this.inicioSesionAtmBtn.Location = new System.Drawing.Point(303, 243);
            this.inicioSesionAtmBtn.Name = "inicioSesionAtmBtn";
            this.inicioSesionAtmBtn.Size = new System.Drawing.Size(75, 23);
            this.inicioSesionAtmBtn.TabIndex = 11;
            this.inicioSesionAtmBtn.Text = "Aceptar";
            this.inicioSesionAtmBtn.UseVisualStyleBackColor = true;
            this.inicioSesionAtmBtn.Click += new System.EventHandler(this.inicioSesionBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Introduzca su Numero de Cuenta y NIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NIP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero de cuenta";
            // 
            // contraSesionTxb
            // 
            this.contraSesionTxb.Location = new System.Drawing.Point(90, 183);
            this.contraSesionTxb.Name = "contraSesionTxb";
            this.contraSesionTxb.Size = new System.Drawing.Size(242, 20);
            this.contraSesionTxb.TabIndex = 7;
            this.contraSesionTxb.UseSystemPasswordChar = true;
            // 
            // usuarioSesionTxb
            // 
            this.usuarioSesionTxb.Location = new System.Drawing.Point(90, 112);
            this.usuarioSesionTxb.Name = "usuarioSesionTxb";
            this.usuarioSesionTxb.Size = new System.Drawing.Size(242, 20);
            this.usuarioSesionTxb.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.aTMTablaBindingSource;
            this.listBox1.DisplayMember = "NumCuenta";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(508, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
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
            // nIPTextBox
            // 
            this.nIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NIP", true));
            this.nIPTextBox.Location = new System.Drawing.Point(528, 183);
            this.nIPTextBox.Name = "nIPTextBox";
            this.nIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIPTextBox.TabIndex = 13;
            // 
            // numClienteLabel
            // 
            numClienteLabel.AutoSize = true;
            numClienteLabel.Location = new System.Drawing.Point(497, 221);
            numClienteLabel.Name = "numClienteLabel";
            numClienteLabel.Size = new System.Drawing.Size(67, 13);
            numClienteLabel.TabIndex = 13;
            numClienteLabel.Text = "Num Cliente:";
            // 
            // numClienteTextBox
            // 
            this.numClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NumCliente", true));
            this.numClienteTextBox.Location = new System.Drawing.Point(570, 218);
            this.numClienteTextBox.Name = "numClienteTextBox";
            this.numClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.numClienteTextBox.TabIndex = 14;
            // 
            // SesionContraAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 303);
            this.Controls.Add(numClienteLabel);
            this.Controls.Add(this.numClienteTextBox);
            this.Controls.Add(nIPLabel);
            this.Controls.Add(this.nIPTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.inicioSesionAtmBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraSesionTxb);
            this.Controls.Add(this.usuarioSesionTxb);
            this.Name = "SesionContraAtm";
            this.Text = "SesionContraAtm";
            this.Load += new System.EventHandler(this.SesionContraAtm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inicioSesionAtmBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraSesionTxb;
        private System.Windows.Forms.TextBox usuarioSesionTxb;
        private System.Windows.Forms.ListBox listBox1;
        private BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nIPTextBox;
        private System.Windows.Forms.TextBox numClienteTextBox;
    }
}