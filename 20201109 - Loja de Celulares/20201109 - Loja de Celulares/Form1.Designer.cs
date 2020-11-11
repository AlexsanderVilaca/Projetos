namespace _20201109___Loja_de_Celulares
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
            this.components = new System.ComponentModel.Container();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.CadastrarAparelho = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarAparelho,
            this.CadastrarVenda,
            this.ExibirVendas});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(496, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // CadastrarAparelho
            // 
            this.CadastrarAparelho.Name = "CadastrarAparelho";
            this.CadastrarAparelho.Size = new System.Drawing.Size(120, 20);
            this.CadastrarAparelho.Text = "Cadastrar Aparelho";
            this.CadastrarAparelho.Click += new System.EventHandler(this.CadastrarAparelho_Click);
            // 
            // CadastrarVenda
            // 
            this.CadastrarVenda.Name = "CadastrarVenda";
            this.CadastrarVenda.Size = new System.Drawing.Size(104, 20);
            this.CadastrarVenda.Text = "Cadastrar Venda";
            this.CadastrarVenda.Click += new System.EventHandler(this.CadastrarVenda_Click);
            // 
            // ExibirVendas
            // 
            this.ExibirVendas.Name = "ExibirVendas";
            this.ExibirVendas.Size = new System.Drawing.Size(88, 20);
            this.ExibirVendas.Text = "Exibir Vendas";
            this.ExibirVendas.Click += new System.EventHandler(this.ExibirVendas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loja de Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "dd/MM/yyyy - HH:mm:ss";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem CadastrarAparelho;
        private System.Windows.Forms.ToolStripMenuItem CadastrarVenda;
        private System.Windows.Forms.ToolStripMenuItem ExibirVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

