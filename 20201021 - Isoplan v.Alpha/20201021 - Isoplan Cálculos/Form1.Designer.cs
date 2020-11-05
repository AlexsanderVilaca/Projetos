namespace _20201021___Isoplan_Cálculos
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
            this.txtIncerteza2 = new System.Windows.Forms.TextBox();
            this.txtIncerteza3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroPontos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgPontos = new System.Windows.Forms.Button();
            this.tabelapontos = new System.Windows.Forms.DataGridView();
            this.tabelaFinal = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelapontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIncerteza2
            // 
            this.txtIncerteza2.Location = new System.Drawing.Point(308, 10);
            this.txtIncerteza2.Name = "txtIncerteza2";
            this.txtIncerteza2.Size = new System.Drawing.Size(77, 20);
            this.txtIncerteza2.TabIndex = 8;
            // 
            // txtIncerteza3
            // 
            this.txtIncerteza3.Location = new System.Drawing.Point(308, 36);
            this.txtIncerteza3.Name = "txtIncerteza3";
            this.txtIncerteza3.Size = new System.Drawing.Size(77, 20);
            this.txtIncerteza3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "U2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "U3";
            // 
            // txtNumeroPontos
            // 
            this.txtNumeroPontos.Location = new System.Drawing.Point(79, 25);
            this.txtNumeroPontos.Name = "txtNumeroPontos";
            this.txtNumeroPontos.Size = new System.Drawing.Size(77, 20);
            this.txtNumeroPontos.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Nº Pontos";
            // 
            // dgPontos
            // 
            this.dgPontos.Location = new System.Drawing.Point(162, 13);
            this.dgPontos.Name = "dgPontos";
            this.dgPontos.Size = new System.Drawing.Size(95, 43);
            this.dgPontos.TabIndex = 31;
            this.dgPontos.Text = "ENTRA";
            this.dgPontos.UseVisualStyleBackColor = true;
            this.dgPontos.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabelapontos
            // 
            this.tabelapontos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabelapontos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelapontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelapontos.Location = new System.Drawing.Point(12, 91);
            this.tabelapontos.Name = "tabelapontos";
            this.tabelapontos.Size = new System.Drawing.Size(878, 149);
            this.tabelapontos.TabIndex = 32;
            // 
            // tabelaFinal
            // 
            this.tabelaFinal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabelaFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFinal.Location = new System.Drawing.Point(12, 286);
            this.tabelaFinal.Name = "tabelaFinal";
            this.tabelaFinal.Size = new System.Drawing.Size(1066, 149);
            this.tabelaFinal.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "CALIBRAÇÃO PRELIMINAR";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "CALIBRAÇÃO FINAL";
            // 
            // btnCalculos
            // 
            this.btnCalculos.Location = new System.Drawing.Point(896, 91);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(75, 149);
            this.btnCalculos.TabIndex = 37;
            this.btnCalculos.Text = "CALCULA";
            this.btnCalculos.UseVisualStyleBackColor = true;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1084, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 149);
            this.button2.TabIndex = 38;
            this.button2.Text = "CALCULA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(462, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 42);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(570, 14);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(102, 42);
            this.btnCarregar.TabIndex = 40;
            this.btnCarregar.Text = "CARREGAR";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 444);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabelaFinal);
            this.Controls.Add(this.tabelapontos);
            this.Controls.Add(this.dgPontos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNumeroPontos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIncerteza3);
            this.Controls.Add(this.txtIncerteza2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabelapontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIncerteza2;
        private System.Windows.Forms.TextBox txtIncerteza3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroPontos;
        private System.Windows.Forms.Button dgPontos;
        private System.Windows.Forms.DataGridView tabelapontos;
        private System.Windows.Forms.DataGridView tabelaFinal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
    }
}

