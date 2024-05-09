namespace RunManatea
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRunManatea = new System.Windows.Forms.Button();
            this.btnWriteFiles = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSizez = new System.Windows.Forms.TextBox();
            this.txtSizey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSizex = new System.Windows.Forms.TextBox();
            this.btnReadMatFile = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxllCorner0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtyllCorner0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtDy = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(3, 3);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(194, 144);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read 3 mb File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRunManatea, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReadFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWriteFiles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 611);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnRunManatea
            // 
            this.btnRunManatea.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunManatea.Location = new System.Drawing.Point(3, 298);
            this.btnRunManatea.Name = "btnRunManatea";
            this.btnRunManatea.Size = new System.Drawing.Size(194, 144);
            this.btnRunManatea.TabIndex = 3;
            this.btnRunManatea.Text = "Run Manatea";
            this.btnRunManatea.UseVisualStyleBackColor = true;
            this.btnRunManatea.Click += new System.EventHandler(this.btnRunManatea_Click);
            // 
            // btnWriteFiles
            // 
            this.btnWriteFiles.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFiles.Location = new System.Drawing.Point(442, 298);
            this.btnWriteFiles.Name = "btnWriteFiles";
            this.btnWriteFiles.Size = new System.Drawing.Size(194, 144);
            this.btnWriteFiles.TabIndex = 1;
            this.btnWriteFiles.Text = "Write Files";
            this.btnWriteFiles.UseVisualStyleBackColor = true;
            this.btnWriteFiles.Click += new System.EventHandler(this.btnWriteFiles_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.96013F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26246F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.96013F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26246F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.29236F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26246F));
            this.tableLayoutPanel2.Controls.Add(this.txtSizez, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSizey, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSizex, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnReadMatFile, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtxllCorner0, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtyllCorner0, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtStep, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtDx, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtDy, 3, 4);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(442, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 289);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txtSizez
            // 
            this.txtSizez.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizez.Location = new System.Drawing.Point(342, 37);
            this.txtSizez.Name = "txtSizez";
            this.txtSizez.Size = new System.Drawing.Size(89, 28);
            this.txtSizez.TabIndex = 13;
            this.txtSizez.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtSizey
            // 
            this.txtSizey.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizey.Location = new System.Drawing.Point(197, 37);
            this.txtSizey.Name = "txtSizey";
            this.txtSizey.Size = new System.Drawing.Size(86, 28);
            this.txtSizey.TabIndex = 12;
            this.txtSizey.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSizex
            // 
            this.txtSizex.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizex.Location = new System.Drawing.Point(54, 37);
            this.txtSizex.Name = "txtSizex";
            this.txtSizex.Size = new System.Drawing.Size(86, 28);
            this.txtSizex.TabIndex = 6;
            this.txtSizex.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnReadMatFile
            // 
            this.btnReadMatFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.SetColumnSpan(this.btnReadMatFile, 6);
            this.btnReadMatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMatFile.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMatFile.Location = new System.Drawing.Point(15, 235);
            this.btnReadMatFile.Margin = new System.Windows.Forms.Padding(15, 1, 1, 5);
            this.btnReadMatFile.Name = "btnReadMatFile";
            this.btnReadMatFile.Size = new System.Drawing.Size(398, 47);
            this.btnReadMatFile.TabIndex = 2;
            this.btnReadMatFile.Text = "Read mat file";
            this.btnReadMatFile.UseVisualStyleBackColor = false;
            this.btnReadMatFile.Click += new System.EventHandler(this.but3dgridRead_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.lbl1, 6);
            this.lbl1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(3, 3);
            this.lbl1.Margin = new System.Windows.Forms.Padding(3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(428, 28);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "3 grid size";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "X size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 6);
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 44);
            this.label4.TabIndex = 14;
            this.label4.Text = "Corners/Step";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "xllCorner";
            // 
            // txtxllCorner0
            // 
            this.txtxllCorner0.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxllCorner0.Location = new System.Drawing.Point(54, 137);
            this.txtxllCorner0.Name = "txtxllCorner0";
            this.txtxllCorner0.Size = new System.Drawing.Size(86, 28);
            this.txtxllCorner0.TabIndex = 5;
            this.txtxllCorner0.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "yllCorner";
            // 
            // txtyllCorner0
            // 
            this.txtyllCorner0.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyllCorner0.Location = new System.Drawing.Point(197, 137);
            this.txtyllCorner0.Name = "txtyllCorner0";
            this.txtyllCorner0.Size = new System.Drawing.Size(72, 28);
            this.txtyllCorner0.TabIndex = 8;
            this.txtyllCorner0.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 50);
            this.label7.TabIndex = 17;
            this.label7.Text = "depthStep";
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStep.Location = new System.Drawing.Point(342, 137);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(83, 28);
            this.txtStep.TabIndex = 4;
            this.txtStep.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "dx0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "dy0";
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(54, 187);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(86, 28);
            this.txtDx.TabIndex = 20;
            // 
            // txtDy
            // 
            this.txtDy.Location = new System.Drawing.Point(197, 187);
            this.txtDy.Name = "txtDy";
            this.txtDy.Size = new System.Drawing.Size(86, 28);
            this.txtDy.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblStatus, 2);
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(3, 590);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(873, 21);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnWriteFiles;
        private System.Windows.Forms.Button btnReadMatFile;
        private System.Windows.Forms.Button btnRunManatea;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtxllCorner0;
        private System.Windows.Forms.TextBox txtSizex;
        private System.Windows.Forms.TextBox txtyllCorner0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtSizez;
        private System.Windows.Forms.TextBox txtSizey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtDy;
        private System.Windows.Forms.Label lblStatus;
    }
}

