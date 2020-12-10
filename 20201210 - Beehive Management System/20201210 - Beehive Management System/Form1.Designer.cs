namespace _20201210___Beehive_Management_System
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssignJob2Bee = new System.Windows.Forms.Button();
            this.npNumberOfShifts = new System.Windows.Forms.NumericUpDown();
            this.cbSelectWorkerBee = new System.Windows.Forms.ComboBox();
            this.btnNextShift = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npNumberOfShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAssignJob2Bee);
            this.groupBox1.Controls.Add(this.npNumberOfShifts);
            this.groupBox1.Controls.Add(this.cbSelectWorkerBee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Worker bee job";
            // 
            // btnAssignJob2Bee
            // 
            this.btnAssignJob2Bee.Location = new System.Drawing.Point(6, 64);
            this.btnAssignJob2Bee.Name = "btnAssignJob2Bee";
            this.btnAssignJob2Bee.Size = new System.Drawing.Size(199, 24);
            this.btnAssignJob2Bee.TabIndex = 2;
            this.btnAssignJob2Bee.Text = "Assign this job to a bee\r\n\r\n";
            this.btnAssignJob2Bee.UseVisualStyleBackColor = true;
            // 
            // npNumberOfShifts
            // 
            this.npNumberOfShifts.Location = new System.Drawing.Point(211, 38);
            this.npNumberOfShifts.Name = "npNumberOfShifts";
            this.npNumberOfShifts.Size = new System.Drawing.Size(56, 20);
            this.npNumberOfShifts.TabIndex = 1;
            this.npNumberOfShifts.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbSelectWorkerBee
            // 
            this.cbSelectWorkerBee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectWorkerBee.FormattingEnabled = true;
            this.cbSelectWorkerBee.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Baby bee tutorial",
            "Sting patrol"});
            this.cbSelectWorkerBee.Location = new System.Drawing.Point(6, 37);
            this.cbSelectWorkerBee.Name = "cbSelectWorkerBee";
            this.cbSelectWorkerBee.Size = new System.Drawing.Size(199, 21);
            this.cbSelectWorkerBee.TabIndex = 0;
            this.cbSelectWorkerBee.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnNextShift
            // 
            this.btnNextShift.Location = new System.Drawing.Point(303, 30);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(68, 68);
            this.btnNextShift.TabIndex = 1;
            this.btnNextShift.Text = "Work the next shift";
            this.btnNextShift.UseVisualStyleBackColor = true;
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(12, 130);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(359, 151);
            this.txtReport.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 293);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnNextShift);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Beehive Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npNumberOfShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSelectWorkerBee;
        private System.Windows.Forms.NumericUpDown npNumberOfShifts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssignJob2Bee;
        private System.Windows.Forms.Button btnNextShift;
        private System.Windows.Forms.TextBox txtReport;
    }
}

