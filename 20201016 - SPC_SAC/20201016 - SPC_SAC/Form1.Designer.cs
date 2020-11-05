namespace _20201016___SPC_SAC
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtPrestacoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioSPC = new System.Windows.Forms.RadioButton();
            this.radioSAC = new System.Windows.Forms.RadioButton();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selecionaTaxa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exportar .txt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(105, 76);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(90, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(105, 103);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(90, 20);
            this.txtTaxa.TabIndex = 3;
            // 
            // txtPrestacoes
            // 
            this.txtPrestacoes.Location = new System.Drawing.Point(105, 129);
            this.txtPrestacoes.Name = "txtPrestacoes";
            this.txtPrestacoes.Size = new System.Drawing.Size(90, 20);
            this.txtPrestacoes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo Devedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Taxa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Prestações";
            // 
            // radioSPC
            // 
            this.radioSPC.AutoSize = true;
            this.radioSPC.Checked = true;
            this.radioSPC.Location = new System.Drawing.Point(71, 12);
            this.radioSPC.Name = "radioSPC";
            this.radioSPC.Size = new System.Drawing.Size(46, 17);
            this.radioSPC.TabIndex = 8;
            this.radioSPC.TabStop = true;
            this.radioSPC.Text = "SPC";
            this.radioSPC.UseVisualStyleBackColor = true;
            // 
            // radioSAC
            // 
            this.radioSAC.AutoSize = true;
            this.radioSAC.Location = new System.Drawing.Point(178, 12);
            this.radioSAC.Name = "radioSAC";
            this.radioSAC.Size = new System.Drawing.Size(46, 17);
            this.radioSAC.TabIndex = 9;
            this.radioSAC.Text = "SAC";
            this.radioSAC.UseVisualStyleBackColor = true;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(105, 50);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(90, 20);
            this.txtEntrada.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Entrada";
            // 
            // selecionaTaxa
            // 
            this.selecionaTaxa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionaTaxa.FormattingEnabled = true;
            this.selecionaTaxa.Items.AddRange(new object[] {
            "% a.a.",
            "% a.m."});
            this.selecionaTaxa.Location = new System.Drawing.Point(201, 103);
            this.selecionaTaxa.Name = "selecionaTaxa";
            this.selecionaTaxa.Size = new System.Drawing.Size(56, 21);
            this.selecionaTaxa.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 233);
            this.Controls.Add(this.selecionaTaxa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.radioSAC);
            this.Controls.Add(this.radioSPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrestacoes);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtPrestacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioSPC;
        private System.Windows.Forms.RadioButton radioSAC;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selecionaTaxa;
    }
}

