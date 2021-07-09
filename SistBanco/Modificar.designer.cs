namespace Cajero
{
    partial class Modificar
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
            System.Windows.Forms.Label apellidoPatLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoMatLabel;
            System.Windows.Forms.Label rFCLabel;
            System.Windows.Forms.Label cURPLabel;
            System.Windows.Forms.Label numClienteLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label calleLabel;
            System.Windows.Forms.Label numExtLabel;
            System.Windows.Forms.Label numeroIntLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label municipioLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label paisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.datosPanel = new System.Windows.Forms.Panel();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.gerenteTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoBDDataSet = new SistBanco.BancoBDDataSet();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.municipioTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.coloniaTextBox = new System.Windows.Forms.TextBox();
            this.numeroIntTextBox = new System.Windows.Forms.TextBox();
            this.numExtTextBox = new System.Windows.Forms.TextBox();
            this.calleTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.numClienteComboBox = new System.Windows.Forms.ComboBox();
            this.cURPTextBox = new System.Windows.Forms.TextBox();
            this.rFCTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMatTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPatTextBox = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.domicilioLbl = new System.Windows.Forms.Label();
            this.datosLbl = new System.Windows.Forms.Label();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.gerenteTablaTableAdapter = new SistBanco.BancoBDDataSetTableAdapters.GerenteTablaTableAdapter();
            this.tableAdapterManager = new SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager();
            this.gerenteTablaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gerenteTablaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            apellidoPatLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoMatLabel = new System.Windows.Forms.Label();
            rFCLabel = new System.Windows.Forms.Label();
            cURPLabel = new System.Windows.Forms.Label();
            numClienteLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            calleLabel = new System.Windows.Forms.Label();
            numExtLabel = new System.Windows.Forms.Label();
            numeroIntLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            municipioLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            this.datosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteTablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteTablaBindingNavigator)).BeginInit();
            this.gerenteTablaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // apellidoPatLabel
            // 
            apellidoPatLabel.AutoSize = true;
            apellidoPatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoPatLabel.Location = new System.Drawing.Point(12, 108);
            apellidoPatLabel.Name = "apellidoPatLabel";
            apellidoPatLabel.Size = new System.Drawing.Size(84, 16);
            apellidoPatLabel.TabIndex = 107;
            apellidoPatLabel.Text = "Apellido Pat:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(22, 73);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 108;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoMatLabel
            // 
            apellidoMatLabel.AutoSize = true;
            apellidoMatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoMatLabel.Location = new System.Drawing.Point(10, 143);
            apellidoMatLabel.Name = "apellidoMatLabel";
            apellidoMatLabel.Size = new System.Drawing.Size(86, 16);
            apellidoMatLabel.TabIndex = 109;
            apellidoMatLabel.Text = "Apellido Mat:";
            apellidoMatLabel.Click += new System.EventHandler(this.apellidoMatLabel_Click);
            // 
            // rFCLabel
            // 
            rFCLabel.AutoSize = true;
            rFCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rFCLabel.Location = new System.Drawing.Point(29, 181);
            rFCLabel.Name = "rFCLabel";
            rFCLabel.Size = new System.Drawing.Size(38, 16);
            rFCLabel.TabIndex = 110;
            rFCLabel.Text = "RFC:";
            // 
            // cURPLabel
            // 
            cURPLabel.AutoSize = true;
            cURPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cURPLabel.Location = new System.Drawing.Point(242, 178);
            cURPLabel.Name = "cURPLabel";
            cURPLabel.Size = new System.Drawing.Size(49, 16);
            cURPLabel.TabIndex = 111;
            cURPLabel.Text = "CURP:";
            // 
            // numClienteLabel
            // 
            numClienteLabel.AutoSize = true;
            numClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numClienteLabel.Location = new System.Drawing.Point(11, 37);
            numClienteLabel.Name = "numClienteLabel";
            numClienteLabel.Size = new System.Drawing.Size(83, 16);
            numClienteLabel.TabIndex = 112;
            numClienteLabel.Text = "Num Cliente:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(17, 221);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(65, 16);
            telefonoLabel.TabIndex = 113;
            telefonoLabel.Text = "Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(259, 218);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 16);
            emailLabel.TabIndex = 114;
            emailLabel.Text = "Email:";
            // 
            // calleLabel
            // 
            calleLabel.AutoSize = true;
            calleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calleLabel.Location = new System.Drawing.Point(12, 276);
            calleLabel.Name = "calleLabel";
            calleLabel.Size = new System.Drawing.Size(42, 16);
            calleLabel.TabIndex = 115;
            calleLabel.Text = "Calle:";
            // 
            // numExtLabel
            // 
            numExtLabel.AutoSize = true;
            numExtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numExtLabel.Location = new System.Drawing.Point(230, 300);
            numExtLabel.Name = "numExtLabel";
            numExtLabel.Size = new System.Drawing.Size(60, 16);
            numExtLabel.TabIndex = 116;
            numExtLabel.Text = "Num Ext:";
            // 
            // numeroIntLabel
            // 
            numeroIntLabel.AutoSize = true;
            numeroIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroIntLabel.Location = new System.Drawing.Point(18, 302);
            numeroIntLabel.Name = "numeroIntLabel";
            numeroIntLabel.Size = new System.Drawing.Size(75, 16);
            numeroIntLabel.TabIndex = 117;
            numeroIntLabel.Text = "Numero Int:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(235, 274);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(57, 16);
            coloniaLabel.TabIndex = 118;
            coloniaLabel.Text = "Colonia:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoPostalLabel.Location = new System.Drawing.Point(15, 328);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(96, 16);
            codigoPostalLabel.TabIndex = 119;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // municipioLabel
            // 
            municipioLabel.AutoSize = true;
            municipioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            municipioLabel.Location = new System.Drawing.Point(237, 332);
            municipioLabel.Name = "municipioLabel";
            municipioLabel.Size = new System.Drawing.Size(68, 16);
            municipioLabel.TabIndex = 120;
            municipioLabel.Text = "Municipio:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(23, 354);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(54, 16);
            ciudadLabel.TabIndex = 121;
            ciudadLabel.Text = "Ciudad:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(237, 368);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(54, 16);
            estadoLabel.TabIndex = 122;
            estadoLabel.Text = "Estado:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paisLabel.Location = new System.Drawing.Point(27, 380);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(38, 16);
            paisLabel.TabIndex = 123;
            paisLabel.Text = "Pais:";
            // 
            // datosPanel
            // 
            this.datosPanel.Controls.Add(paisLabel);
            this.datosPanel.Controls.Add(this.paisTextBox);
            this.datosPanel.Controls.Add(estadoLabel);
            this.datosPanel.Controls.Add(this.estadoTextBox);
            this.datosPanel.Controls.Add(ciudadLabel);
            this.datosPanel.Controls.Add(this.ciudadTextBox);
            this.datosPanel.Controls.Add(municipioLabel);
            this.datosPanel.Controls.Add(this.municipioTextBox);
            this.datosPanel.Controls.Add(codigoPostalLabel);
            this.datosPanel.Controls.Add(this.codigoPostalTextBox);
            this.datosPanel.Controls.Add(coloniaLabel);
            this.datosPanel.Controls.Add(this.coloniaTextBox);
            this.datosPanel.Controls.Add(numeroIntLabel);
            this.datosPanel.Controls.Add(this.numeroIntTextBox);
            this.datosPanel.Controls.Add(numExtLabel);
            this.datosPanel.Controls.Add(this.numExtTextBox);
            this.datosPanel.Controls.Add(calleLabel);
            this.datosPanel.Controls.Add(this.calleTextBox);
            this.datosPanel.Controls.Add(emailLabel);
            this.datosPanel.Controls.Add(this.emailTextBox);
            this.datosPanel.Controls.Add(telefonoLabel);
            this.datosPanel.Controls.Add(this.telefonoTextBox);
            this.datosPanel.Controls.Add(numClienteLabel);
            this.datosPanel.Controls.Add(this.numClienteComboBox);
            this.datosPanel.Controls.Add(cURPLabel);
            this.datosPanel.Controls.Add(this.cURPTextBox);
            this.datosPanel.Controls.Add(rFCLabel);
            this.datosPanel.Controls.Add(this.rFCTextBox);
            this.datosPanel.Controls.Add(apellidoMatLabel);
            this.datosPanel.Controls.Add(this.apellidoMatTextBox);
            this.datosPanel.Controls.Add(nombreLabel);
            this.datosPanel.Controls.Add(this.nombreTextBox);
            this.datosPanel.Controls.Add(apellidoPatLabel);
            this.datosPanel.Controls.Add(this.apellidoPatTextBox);
            this.datosPanel.Controls.Add(this.cancelarBtn);
            this.datosPanel.Controls.Add(this.domicilioLbl);
            this.datosPanel.Controls.Add(this.datosLbl);
            this.datosPanel.Controls.Add(this.guardarBtn);
            this.datosPanel.Location = new System.Drawing.Point(12, 12);
            this.datosPanel.Name = "datosPanel";
            this.datosPanel.Size = new System.Drawing.Size(596, 482);
            this.datosPanel.TabIndex = 1;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(79, 380);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 20);
            this.paisTextBox.TabIndex = 124;
            // 
            // gerenteTablaBindingSource
            // 
            this.gerenteTablaBindingSource.DataMember = "GerenteTabla";
            this.gerenteTablaBindingSource.DataSource = this.bancoBDDataSet;
            // 
            // bancoBDDataSet
            // 
            this.bancoBDDataSet.DataSetName = "BancoBDDataSet";
            this.bancoBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(298, 367);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 123;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(88, 354);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciudadTextBox.TabIndex = 122;
            // 
            // municipioTextBox
            // 
            this.municipioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Municipio", true));
            this.municipioTextBox.Location = new System.Drawing.Point(310, 331);
            this.municipioTextBox.Name = "municipioTextBox";
            this.municipioTextBox.Size = new System.Drawing.Size(100, 20);
            this.municipioTextBox.TabIndex = 121;
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "CodigoPostal", true));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(112, 328);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoPostalTextBox.TabIndex = 120;
            // 
            // coloniaTextBox
            // 
            this.coloniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Colonia", true));
            this.coloniaTextBox.Location = new System.Drawing.Point(298, 273);
            this.coloniaTextBox.Name = "coloniaTextBox";
            this.coloniaTextBox.Size = new System.Drawing.Size(125, 20);
            this.coloniaTextBox.TabIndex = 119;
            // 
            // numeroIntTextBox
            // 
            this.numeroIntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "NumeroInt", true));
            this.numeroIntTextBox.Location = new System.Drawing.Point(102, 302);
            this.numeroIntTextBox.Name = "numeroIntTextBox";
            this.numeroIntTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroIntTextBox.TabIndex = 118;
            // 
            // numExtTextBox
            // 
            this.numExtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "NumExt", true));
            this.numExtTextBox.Location = new System.Drawing.Point(298, 299);
            this.numExtTextBox.Name = "numExtTextBox";
            this.numExtTextBox.Size = new System.Drawing.Size(100, 20);
            this.numExtTextBox.TabIndex = 117;
            // 
            // calleTextBox
            // 
            this.calleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Calle", true));
            this.calleTextBox.Location = new System.Drawing.Point(67, 276);
            this.calleTextBox.Name = "calleTextBox";
            this.calleTextBox.Size = new System.Drawing.Size(155, 20);
            this.calleTextBox.TabIndex = 116;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(310, 217);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 115;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(88, 217);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 114;
            // 
            // numClienteComboBox
            // 
            this.numClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "NumCliente", true));
            this.numClienteComboBox.DataSource = this.gerenteTablaBindingSource;
            this.numClienteComboBox.DisplayMember = "NumCliente";
            this.numClienteComboBox.FormattingEnabled = true;
            this.numClienteComboBox.Location = new System.Drawing.Point(97, 33);
            this.numClienteComboBox.Name = "numClienteComboBox";
            this.numClienteComboBox.Size = new System.Drawing.Size(121, 21);
            this.numClienteComboBox.TabIndex = 113;
            // 
            // cURPTextBox
            // 
            this.cURPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "CURP", true));
            this.cURPTextBox.Location = new System.Drawing.Point(298, 177);
            this.cURPTextBox.Name = "cURPTextBox";
            this.cURPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cURPTextBox.TabIndex = 112;
            // 
            // rFCTextBox
            // 
            this.rFCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "RFC", true));
            this.rFCTextBox.Location = new System.Drawing.Point(79, 177);
            this.rFCTextBox.Name = "rFCTextBox";
            this.rFCTextBox.Size = new System.Drawing.Size(100, 20);
            this.rFCTextBox.TabIndex = 111;
            // 
            // apellidoMatTextBox
            // 
            this.apellidoMatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "ApellidoMat", true));
            this.apellidoMatTextBox.Location = new System.Drawing.Point(97, 139);
            this.apellidoMatTextBox.Name = "apellidoMatTextBox";
            this.apellidoMatTextBox.Size = new System.Drawing.Size(313, 20);
            this.apellidoMatTextBox.TabIndex = 110;
            this.apellidoMatTextBox.TextChanged += new System.EventHandler(this.apellidoMatTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(88, 69);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(322, 20);
            this.nombreTextBox.TabIndex = 109;
            // 
            // apellidoPatTextBox
            // 
            this.apellidoPatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gerenteTablaBindingSource, "ApellidoPat", true));
            this.apellidoPatTextBox.Location = new System.Drawing.Point(97, 104);
            this.apellidoPatTextBox.Name = "apellidoPatTextBox";
            this.apellidoPatTextBox.Size = new System.Drawing.Size(313, 20);
            this.apellidoPatTextBox.TabIndex = 108;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(403, 434);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(78, 28);
            this.cancelarBtn.TabIndex = 107;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // domicilioLbl
            // 
            this.domicilioLbl.AutoSize = true;
            this.domicilioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilioLbl.Location = new System.Drawing.Point(186, 246);
            this.domicilioLbl.Name = "domicilioLbl";
            this.domicilioLbl.Size = new System.Drawing.Size(81, 20);
            this.domicilioLbl.TabIndex = 84;
            this.domicilioLbl.Text = "Domicilio";
            // 
            // datosLbl
            // 
            this.datosLbl.AutoSize = true;
            this.datosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosLbl.Location = new System.Drawing.Point(177, 0);
            this.datosLbl.Name = "datosLbl";
            this.datosLbl.Size = new System.Drawing.Size(145, 20);
            this.datosLbl.TabIndex = 75;
            this.datosLbl.Text = "Datos Generales";
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(304, 434);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(78, 28);
            this.guardarBtn.TabIndex = 38;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // gerenteTablaTableAdapter
            // 
            this.gerenteTablaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATMTablaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajeroTablaTableAdapter = null;
            this.tableAdapterManager.GerenteTablaTableAdapter = this.gerenteTablaTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gerenteTablaBindingNavigator
            // 
            this.gerenteTablaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gerenteTablaBindingNavigator.BindingSource = this.gerenteTablaBindingSource;
            this.gerenteTablaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gerenteTablaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gerenteTablaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gerenteTablaBindingNavigatorSaveItem});
            this.gerenteTablaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gerenteTablaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gerenteTablaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gerenteTablaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gerenteTablaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gerenteTablaBindingNavigator.Name = "gerenteTablaBindingNavigator";
            this.gerenteTablaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gerenteTablaBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.gerenteTablaBindingNavigator.TabIndex = 2;
            this.gerenteTablaBindingNavigator.Text = "bindingNavigator1";
            this.gerenteTablaBindingNavigator.Visible = false;
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
            // gerenteTablaBindingNavigatorSaveItem
            // 
            this.gerenteTablaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gerenteTablaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gerenteTablaBindingNavigatorSaveItem.Image")));
            this.gerenteTablaBindingNavigatorSaveItem.Name = "gerenteTablaBindingNavigatorSaveItem";
            this.gerenteTablaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gerenteTablaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.gerenteTablaBindingNavigatorSaveItem.Click += new System.EventHandler(this.gerenteTablaBindingNavigatorSaveItem_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 494);
            this.Controls.Add(this.gerenteTablaBindingNavigator);
            this.Controls.Add(this.datosPanel);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.datosPanel.ResumeLayout(false);
            this.datosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteTablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteTablaBindingNavigator)).EndInit();
            this.gerenteTablaBindingNavigator.ResumeLayout(false);
            this.gerenteTablaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel datosPanel;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label domicilioLbl;
        private System.Windows.Forms.Label datosLbl;
        private System.Windows.Forms.Button guardarBtn;
        private SistBanco.BancoBDDataSet bancoBDDataSet;
        private System.Windows.Forms.BindingSource gerenteTablaBindingSource;
        private SistBanco.BancoBDDataSetTableAdapters.GerenteTablaTableAdapter gerenteTablaTableAdapter;
        private SistBanco.BancoBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gerenteTablaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gerenteTablaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cURPTextBox;
        private System.Windows.Forms.TextBox rFCTextBox;
        private System.Windows.Forms.TextBox apellidoMatTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoPatTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox municipioTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox coloniaTextBox;
        private System.Windows.Forms.TextBox numeroIntTextBox;
        private System.Windows.Forms.TextBox numExtTextBox;
        private System.Windows.Forms.TextBox calleTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.ComboBox numClienteComboBox;
    }
}