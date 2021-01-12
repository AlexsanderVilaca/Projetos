namespace _20201109___Loja_de_Celulares
{
    partial class ftTelaExibirVendas
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
            this.tabelaDados = new System.Windows.Forms.DataGridView();
            this.btnRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaDados
            // 
            this.tabelaDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDados.Location = new System.Drawing.Point(12, 12);
            this.tabelaDados.Name = "tabelaDados";
            this.tabelaDados.ReadOnly = true;
            this.tabelaDados.Size = new System.Drawing.Size(548, 164);
            this.tabelaDados.TabIndex = 0;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(217, 196);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(120, 44);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.Text = "button1";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // ftTelaExibirVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 261);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.tabelaDados);
            this.Name = "ftTelaExibirVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ftTelaExibirVendas";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaDados;
        private System.Windows.Forms.Button btnRelatorio;
    }
}