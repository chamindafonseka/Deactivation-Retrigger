
namespace Bulk_Deactivation_Retrigger
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCAS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalBoxes = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeactCmd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allocated Deactivation Retrigger";
            // 
            // cmbCAS
            // 
            this.cmbCAS.FormattingEnabled = true;
            this.cmbCAS.Items.AddRange(new object[] {
            "iCAS",
            "NSTV"});
            this.cmbCAS.Location = new System.Drawing.Point(94, 18);
            this.cmbCAS.Name = "cmbCAS";
            this.cmbCAS.Size = new System.Drawing.Size(135, 21);
            this.cmbCAS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CAS Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "InventryID Range From  :";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(170, 181);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(64, 20);
            this.txtFrom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "To :";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(272, 181);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(67, 20);
            this.txtTo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min InventoryID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max InventoryID :";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(236, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(33, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMin.Location = new System.Drawing.Point(275, 60);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(16, 13);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "...";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMax.Location = new System.Drawing.Point(432, 60);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(16, 13);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Boxes :";
            // 
            // lblTotalBoxes
            // 
            this.lblTotalBoxes.AutoSize = true;
            this.lblTotalBoxes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalBoxes.Location = new System.Drawing.Point(95, 60);
            this.lblTotalBoxes.Name = "lblTotalBoxes";
            this.lblTotalBoxes.Size = new System.Drawing.Size(16, 13);
            this.lblTotalBoxes.TabIndex = 11;
            this.lblTotalBoxes.Text = "...";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(345, 180);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(51, 23);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.Green;
            this.lblCheck.Location = new System.Drawing.Point(403, 189);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(34, 13);
            this.lblCheck.TabIndex = 13;
            this.lblCheck.Text = ".........";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Controls.Add(this.lblTotalBoxes);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCAS);
            this.panel1.Location = new System.Drawing.Point(18, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 98);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeactCmd);
            this.panel2.Location = new System.Drawing.Point(18, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 66);
            this.panel2.TabIndex = 15;
            // 
            // btnDeactCmd
            // 
            this.btnDeactCmd.Location = new System.Drawing.Point(24, 20);
            this.btnDeactCmd.Name = "btnDeactCmd";
            this.btnDeactCmd.Size = new System.Drawing.Size(109, 23);
            this.btnDeactCmd.TabIndex = 0;
            this.btnDeactCmd.Text = "Bulk Deactivation";
            this.btnDeactCmd.UseVisualStyleBackColor = true;
            this.btnDeactCmd.Click += new System.EventHandler(this.btnDeactCmd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(464, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(15, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unallocated Boxes Deactivation Retrigger";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 381);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Allocated";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCAS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalBoxes;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeactCmd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label8;
    }
}

