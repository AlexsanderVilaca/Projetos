namespace _20201125___009_Corrida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.lblApostas = new System.Windows.Forms.Label();
            this.lblAtualApostador = new System.Windows.Forms.Label();
            this.btnApostar = new System.Windows.Forms.Button();
            this.npValorAposta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.npNumeroCachorro = new System.Windows.Forms.NumericUpDown();
            this.btnIniciarCorrida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJoe = new System.Windows.Forms.TextBox();
            this.txtBob = new System.Windows.Forms.TextBox();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.timerPasso = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npValorAposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNumeroCachorro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(32, 25);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(98, 29);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(30, 89);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(98, 29);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(32, 163);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(98, 29);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(32, 234);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(98, 29);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJoe.Location = new System.Drawing.Point(16, 340);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(51, 22);
            this.rbJoe.TabIndex = 5;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBob.Location = new System.Drawing.Point(16, 363);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(53, 22);
            this.rbBob.TabIndex = 6;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAl.Location = new System.Drawing.Point(16, 386);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(38, 22);
            this.rbAl.TabIndex = 7;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            // 
            // lblApostas
            // 
            this.lblApostas.AutoSize = true;
            this.lblApostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostas.Location = new System.Drawing.Point(12, 314);
            this.lblApostas.Name = "lblApostas";
            this.lblApostas.Size = new System.Drawing.Size(155, 18);
            this.lblApostas.TabIndex = 8;
            this.lblApostas.Text = "Minimum bet: X bucks";
            // 
            // lblAtualApostador
            // 
            this.lblAtualApostador.AutoSize = true;
            this.lblAtualApostador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtualApostador.Location = new System.Drawing.Point(8, 419);
            this.lblAtualApostador.Name = "lblAtualApostador";
            this.lblAtualApostador.Size = new System.Drawing.Size(120, 20);
            this.lblAtualApostador.TabIndex = 9;
            this.lblAtualApostador.Text = "apostador atual";
            // 
            // btnApostar
            // 
            this.btnApostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.Location = new System.Drawing.Point(143, 410);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(79, 29);
            this.btnApostar.TabIndex = 10;
            this.btnApostar.Text = "Bets";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // npValorAposta
            // 
            this.npValorAposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npValorAposta.Location = new System.Drawing.Point(228, 410);
            this.npValorAposta.Name = "npValorAposta";
            this.npValorAposta.Size = new System.Drawing.Size(63, 29);
            this.npValorAposta.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "bucks on dog number";
            // 
            // npNumeroCachorro
            // 
            this.npNumeroCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npNumeroCachorro.Location = new System.Drawing.Point(479, 410);
            this.npNumeroCachorro.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.npNumeroCachorro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npNumeroCachorro.Name = "npNumeroCachorro";
            this.npNumeroCachorro.Size = new System.Drawing.Size(63, 29);
            this.npNumeroCachorro.TabIndex = 13;
            this.npNumeroCachorro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIniciarCorrida
            // 
            this.btnIniciarCorrida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarCorrida.Location = new System.Drawing.Point(651, 394);
            this.btnIniciarCorrida.Name = "btnIniciarCorrida";
            this.btnIniciarCorrida.Size = new System.Drawing.Size(104, 44);
            this.btnIniciarCorrida.TabIndex = 14;
            this.btnIniciarCorrida.Text = "Race!";
            this.btnIniciarCorrida.UseVisualStyleBackColor = true;
            this.btnIniciarCorrida.Click += new System.EventHandler(this.btnIniciarCorrida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bets";
            // 
            // txtJoe
            // 
            this.txtJoe.Location = new System.Drawing.Point(557, 312);
            this.txtJoe.Name = "txtJoe";
            this.txtJoe.Size = new System.Drawing.Size(198, 20);
            this.txtJoe.TabIndex = 16;
            // 
            // txtBob
            // 
            this.txtBob.Location = new System.Drawing.Point(557, 338);
            this.txtBob.Name = "txtBob";
            this.txtBob.Size = new System.Drawing.Size(198, 20);
            this.txtBob.TabIndex = 17;
            // 
            // txtAl
            // 
            this.txtAl.Location = new System.Drawing.Point(557, 364);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(198, 20);
            this.txtAl.TabIndex = 18;
            // 
            // timerPasso
            // 
            this.timerPasso.Tick += new System.EventHandler(this.timerPasso_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.txtAl);
            this.Controls.Add(this.txtBob);
            this.Controls.Add(this.txtJoe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciarCorrida);
            this.Controls.Add(this.npNumeroCachorro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.npValorAposta);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lblAtualApostador);
            this.Controls.Add(this.lblApostas);
            this.Controls.Add(this.rbAl);
            this.Controls.Add(this.rbBob);
            this.Controls.Add(this.rbJoe);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npValorAposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNumeroCachorro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.Label lblApostas;
        private System.Windows.Forms.Label lblAtualApostador;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.NumericUpDown npValorAposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown npNumeroCachorro;
        private System.Windows.Forms.Button btnIniciarCorrida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJoe;
        private System.Windows.Forms.TextBox txtBob;
        private System.Windows.Forms.TextBox txtAl;
        private System.Windows.Forms.Timer timerPasso;
    }
}

