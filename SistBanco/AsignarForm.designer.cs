namespace Gerente
{
    partial class AsignarForm
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
            System.Windows.Forms.Label nIPLabel;
            System.Windows.Forms.Label saldoLabel;
            System.Windows.Forms.Label numClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarForm));
            this.asignarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.aTMTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.aTMTablaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aTMTablaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numCuentaTextBox = new System.Windows.Forms.TextBox();
            this.nIPTextBox = new System.Windows.Forms.TextBox();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.numClienteTextBox = new System.Windows.Forms.TextBox();
            numCuentaLabel = new System.Windows.Forms.Label();
            nIPLabel = new System.Windows.Forms.Label();
            saldoLabel = new System.Windows.Forms.Label();
            numClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingNavigator)).BeginInit();
            this.aTMTablaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCuentaLabel
            // 
            numCuentaLabel.AutoSize = true;
            numCuentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numCuentaLabel.Location = new System.Drawing.Point(67, 106);
            numCuentaLabel.Name = "numCuentaLabel";
            numCuentaLabel.Size = new System.Drawing.Size(84, 16);
            numCuentaLabel.TabIndex = 8;
            numCuentaLabel.Text = "Num Cuenta:";
            // 
            // nIPLabel
            // 
            nIPLabel.AutoSize = true;
            nIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIPLabel.Location = new System.Drawing.Point(110, 163);
            nIPLabel.Name = "nIPLabel";
            nIPLabel.Size = new System.Drawing.Size(33, 16);
            nIPLabel.TabIndex = 9;
            nIPLabel.Text = "NIP:";
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saldoLabel.Location = new System.Drawing.Point(99, 211);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(47, 16);
            saldoLabel.TabIndex = 10;
            saldoLabel.Text = "Saldo:";
            // 
            // numClienteLabel
            // 
            numClienteLabel.AutoSize = true;
            numClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numClienteLabel.Location = new System.Drawing.Point(69, 60);
            numClienteLabel.Name = "numClienteLabel";
            numClienteLabel.Size = new System.Drawing.Size(83, 16);
            numClienteLabel.TabIndex = 11;
            numClienteLabel.Text = "Num Cliente:";
            // 
            // asignarBtn
            // 
            this.asignarBtn.Location = new System.Drawing.Point(271, 265);
            this.asignarBtn.Name = "asignarBtn";
            this.asignarBtn.Size = new System.Drawing.Size(75, 23);
            this.asignarBtn.TabIndex = 4;
            this.asignarBtn.Text = "Asignar";
            this.asignarBtn.UseVisualStyleBackColor = true;
            this.asignarBtn.Click += new System.EventHandler(this.asignarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asigna un numero de cuenta a tu cliente";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(17, 265);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 6;
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
            // aTMTablaBindingNavigator
            // 
            this.aTMTablaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aTMTablaBindingNavigator.BindingSource = this.aTMTablaBindingSource;
            this.aTMTablaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aTMTablaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aTMTablaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aTMTablaBindingNavigatorSaveItem});
            this.aTMTablaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aTMTablaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aTMTablaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aTMTablaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aTMTablaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aTMTablaBindingNavigator.Name = "aTMTablaBindingNavigator";
            this.aTMTablaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aTMTablaBindingNavigator.Size = new System.Drawing.Size(366, 25);
            this.aTMTablaBindingNavigator.TabIndex = 7;
            this.aTMTablaBindingNavigator.Text = "bindingNavigator1";
            this.aTMTablaBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aTMTablaBindingNavigatorSaveItem
            // 
            this.aTMTablaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aTMTablaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aTMTablaBindingNavigatorSaveItem.Image")));
            this.aTMTablaBindingNavigatorSaveItem.Name = "aTMTablaBindingNavigatorSaveItem";
            this.aTMTablaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aTMTablaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aTMTablaBindingNavigatorSaveItem.Click += new System.EventHandler(this.aTMTablaBindingNavigatorSaveItem_Click);
            // 
            // numCuentaTextBox
            // 
            this.numCuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NumCuenta", true));
            this.numCuentaTextBox.Location = new System.Drawing.Point(158, 105);
            this.numCuentaTextBox.Name = "numCuentaTextBox";
            this.numCuentaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numCuentaTextBox.TabIndex = 9;
            // 
            // nIPTextBox
            // 
            this.nIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NIP", true));
            this.nIPTextBox.Location = new System.Drawing.Point(158, 158);
            this.nIPTextBox.Name = "nIPTextBox";
            this.nIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIPTextBox.TabIndex = 10;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "Saldo", true));
            this.saldoTextBox.Location = new System.Drawing.Point(158, 210);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(100, 20);
            this.saldoTextBox.TabIndex = 11;
            // 
            // numClienteTextBox
            // 
            this.numClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTMTablaBindingSource, "NumCliente", true));
            this.numClienteTextBox.Location = new System.Drawing.Point(158, 59);
            this.numClienteTextBox.Name = "numClienteTextBox";
            this.numClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.numClienteTextBox.TabIndex = 12;
            // 
            // AsignarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 308);
            this.Controls.Add(numClienteLabel);
            this.Controls.Add(this.numClienteTextBox);
            this.Controls.Add(saldoLabel);
            this.Controls.Add(this.saldoTextBox);
            this.Controls.Add(nIPLabel);
            this.Controls.Add(this.nIPTextBox);
            this.Controls.Add(numCuentaLabel);
            this.Controls.Add(this.numCuentaTextBox);
            this.Controls.Add(this.aTMTablaBindingNavigator);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.asignarBtn);
            this.Name = "AsignarForm";
            this.Text = "AsignarForm";
            this.Load += new System.EventHandler(this.AsignarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMTablaBindingNavigator)).EndInit();
            this.aTMTablaBindingNavigator.ResumeLayout(false);
            this.aTMTablaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button asignarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelarBtn;
        private SistBanco.BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource aTMTablaBindingSource;
        private SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter aTMTablaTableAdapter;
        private SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aTMTablaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aTMTablaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numCuentaTextBox;
        private System.Windows.Forms.TextBox nIPTextBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.TextBox numClienteTextBox;
    }
}