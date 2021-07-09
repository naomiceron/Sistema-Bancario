namespace Gerente
{
    partial class DarDeAltaCuentaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroClienteTxb = new System.Windows.Forms.TextBox();
            this.numeroCuentaTxb = new System.Windows.Forms.TextBox();
            this.nipTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saldoTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // numeroClienteTxb
            // 
            this.numeroClienteTxb.Location = new System.Drawing.Point(96, 92);
            this.numeroClienteTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroClienteTxb.Name = "numeroClienteTxb";
            this.numeroClienteTxb.Size = new System.Drawing.Size(228, 22);
            this.numeroClienteTxb.TabIndex = 4;
            // 
            // numeroCuentaTxb
            // 
            this.numeroCuentaTxb.Location = new System.Drawing.Point(96, 160);
            this.numeroCuentaTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroCuentaTxb.Name = "numeroCuentaTxb";
            this.numeroCuentaTxb.Size = new System.Drawing.Size(228, 22);
            this.numeroCuentaTxb.TabIndex = 5;
            // 
            // nipTxb
            // 
            this.nipTxb.Location = new System.Drawing.Point(96, 228);
            this.nipTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nipTxb.Name = "nipTxb";
            this.nipTxb.Size = new System.Drawing.Size(228, 22);
            this.nipTxb.TabIndex = 6;
            this.nipTxb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dar de Alta una Cuenta";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(16, 356);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelarBtn.TabIndex = 8;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(308, 356);
            this.aceptarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(100, 28);
            this.aceptarBtn.TabIndex = 9;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(91, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo Inicial";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // saldoTxb
            // 
            this.saldoTxb.Location = new System.Drawing.Point(96, 300);
            this.saldoTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saldoTxb.Name = "saldoTxb";
            this.saldoTxb.Size = new System.Drawing.Size(228, 22);
            this.saldoTxb.TabIndex = 11;
            // 
            // DarDeAltaCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.saldoTxb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nipTxb);
            this.Controls.Add(this.numeroCuentaTxb);
            this.Controls.Add(this.numeroClienteTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DarDeAltaCuentaForm";
            this.Text = "DarDeAltaCuentaForm";
            this.Load += new System.EventHandler(this.DarDeAltaCuentaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeroClienteTxb;
        private System.Windows.Forms.TextBox numeroCuentaTxb;
        private System.Windows.Forms.TextBox nipTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox saldoTxb;
    }
}