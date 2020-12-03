namespace _20201127___KathleenEventPlanner_Encapsulamento
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStringName = new System.Windows.Forms.TextBox();
            this.txtCostBirthday = new System.Windows.Forms.TextBox();
            this.npNumberOfBirthday = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbFancyBirthday = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbHealthyOption = new System.Windows.Forms.CheckBox();
            this.ckbFancyDecorations = new System.Windows.Forms.CheckBox();
            this.npNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npNumberOfBirthday)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(195, 185);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtStringName);
            this.tabPage1.Controls.Add(this.txtCostBirthday);
            this.tabPage1.Controls.Add(this.npNumberOfBirthday);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ckbFancyBirthday);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(187, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Birthday Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cake Writing";
            // 
            // txtStringName
            // 
            this.txtStringName.Location = new System.Drawing.Point(40, 96);
            this.txtStringName.Name = "txtStringName";
            this.txtStringName.Size = new System.Drawing.Size(106, 20);
            this.txtStringName.TabIndex = 12;
            this.txtStringName.TextChanged += new System.EventHandler(this.txtStringName_TextChanged);
            // 
            // txtCostBirthday
            // 
            this.txtCostBirthday.Location = new System.Drawing.Point(75, 126);
            this.txtCostBirthday.Name = "txtCostBirthday";
            this.txtCostBirthday.Size = new System.Drawing.Size(71, 20);
            this.txtCostBirthday.TabIndex = 11;
            // 
            // npNumberOfBirthday
            // 
            this.npNumberOfBirthday.Location = new System.Drawing.Point(40, 29);
            this.npNumberOfBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.npNumberOfBirthday.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npNumberOfBirthday.Name = "npNumberOfBirthday";
            this.npNumberOfBirthday.Size = new System.Drawing.Size(85, 20);
            this.npNumberOfBirthday.TabIndex = 6;
            this.npNumberOfBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npNumberOfBirthday.ValueChanged += new System.EventHandler(this.npNumberOfBirthday_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // ckbFancyBirthday
            // 
            this.ckbFancyBirthday.AutoSize = true;
            this.ckbFancyBirthday.Location = new System.Drawing.Point(40, 55);
            this.ckbFancyBirthday.Name = "ckbFancyBirthday";
            this.ckbFancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.ckbFancyBirthday.TabIndex = 7;
            this.ckbFancyBirthday.Text = "Fancy Decorations";
            this.ckbFancyBirthday.UseVisualStyleBackColor = true;
            this.ckbFancyBirthday.CheckedChanged += new System.EventHandler(this.ckbFancyBirthday_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ckbHealthyOption);
            this.tabPage2.Controls.Add(this.ckbFancyDecorations);
            this.tabPage2.Controls.Add(this.npNumberOfPeople);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dinner Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(78, 116);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(71, 20);
            this.txtCost.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of People";
            // 
            // ckbHealthyOption
            // 
            this.ckbHealthyOption.AutoSize = true;
            this.ckbHealthyOption.Location = new System.Drawing.Point(43, 89);
            this.ckbHealthyOption.Name = "ckbHealthyOption";
            this.ckbHealthyOption.Size = new System.Drawing.Size(92, 17);
            this.ckbHealthyOption.TabIndex = 8;
            this.ckbHealthyOption.Text = "Healtly Option";
            this.ckbHealthyOption.UseVisualStyleBackColor = true;
            this.ckbHealthyOption.CheckedChanged += new System.EventHandler(this.ckbHealthyOption_CheckedChanged_1);
            // 
            // ckbFancyDecorations
            // 
            this.ckbFancyDecorations.AutoSize = true;
            this.ckbFancyDecorations.Location = new System.Drawing.Point(43, 66);
            this.ckbFancyDecorations.Name = "ckbFancyDecorations";
            this.ckbFancyDecorations.Size = new System.Drawing.Size(115, 17);
            this.ckbFancyDecorations.TabIndex = 7;
            this.ckbFancyDecorations.Text = "Fancy Decorations";
            this.ckbFancyDecorations.UseVisualStyleBackColor = true;
            this.ckbFancyDecorations.CheckedChanged += new System.EventHandler(this.ckbFancyDecorations_CheckedChanged_1);
            // 
            // npNumberOfPeople
            // 
            this.npNumberOfPeople.Location = new System.Drawing.Point(43, 40);
            this.npNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.npNumberOfPeople.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npNumberOfPeople.Name = "npNumberOfPeople";
            this.npNumberOfPeople.Size = new System.Drawing.Size(85, 20);
            this.npNumberOfPeople.TabIndex = 6;
            this.npNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npNumberOfPeople.ValueChanged += new System.EventHandler(this.npNumberOfPeople_ValueChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 185);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npNumberOfBirthday)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npNumberOfPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStringName;
        private System.Windows.Forms.TextBox txtCostBirthday;
        private System.Windows.Forms.NumericUpDown npNumberOfBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbFancyBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbHealthyOption;
        private System.Windows.Forms.CheckBox ckbFancyDecorations;
        private System.Windows.Forms.NumericUpDown npNumberOfPeople;

    }
}

