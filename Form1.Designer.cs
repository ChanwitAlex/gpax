namespace gpax
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAD = new Button();
            label1 = new Label();
            tbGPAx = new TextBox();
            label2 = new Label();
            tblnputGPAx = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            tbGPAmin = new TextBox();
            tbSTD = new TextBox();
            tbGPAmax = new TextBox();
            label5 = new Label();
            GPAMin = new Label();
            GPAMax = new Label();
            btclear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAD
            // 
            btnAD.Location = new Point(253, 67);
            btnAD.Name = "btnAD";
            btnAD.Size = new Size(83, 54);
            btnAD.TabIndex = 0;
            btnAD.Text = "Add bata";
            btnAD.UseVisualStyleBackColor = true;
            btnAD.Click += btnAD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "ใส่คะแนน GPAx";
            // 
            // tbGPAx
            // 
            tbGPAx.Location = new Point(117, 72);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(100, 23);
            tbGPAx.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "GPAx";
            // 
            // tblnputGPAx
            // 
            tblnputGPAx.Location = new Point(117, 22);
            tblnputGPAx.Name = "tblnputGPAx";
            tblnputGPAx.Size = new Size(100, 23);
            tblnputGPAx.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbGPAmin);
            groupBox1.Controls.Add(tbSTD);
            groupBox1.Controls.Add(tbGPAmax);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(GPAMin);
            groupBox1.Controls.Add(GPAMax);
            groupBox1.Controls.Add(tbGPAx);
            groupBox1.Controls.Add(tblnputGPAx);
            groupBox1.Controls.Add(btnAD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 194);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "GPAx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 165);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "student";
            // 
            // tbGPAmin
            // 
            tbGPAmin.Location = new Point(117, 134);
            tbGPAmin.Name = "tbGPAmin";
            tbGPAmin.Size = new Size(100, 23);
            tbGPAmin.TabIndex = 9;
            // 
            // tbSTD
            // 
            tbSTD.Location = new Point(117, 162);
            tbSTD.Name = "tbSTD";
            tbSTD.Size = new Size(100, 23);
            tbSTD.TabIndex = 11;
            // 
            // tbGPAmax
            // 
            tbGPAmax.Location = new Point(117, 103);
            tbGPAmax.Name = "tbGPAmax";
            tbGPAmax.Size = new Size(100, 23);
            tbGPAmax.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 165);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // GPAMin
            // 
            GPAMin.AutoSize = true;
            GPAMin.Location = new Point(46, 137);
            GPAMin.Name = "GPAMin";
            GPAMin.Size = new Size(50, 15);
            GPAMin.TabIndex = 6;
            GPAMin.Text = "GPAMin";
            // 
            // GPAMax
            // 
            GPAMax.AutoSize = true;
            GPAMax.Location = new Point(46, 106);
            GPAMax.Name = "GPAMax";
            GPAMax.Size = new Size(51, 15);
            GPAMax.TabIndex = 5;
            GPAMax.Text = "GPAMax";
            // 
            // btclear
            // 
            btclear.Location = new Point(62, 237);
            btclear.Name = "btclear";
            btclear.Size = new Size(209, 54);
            btclear.TabIndex = 10;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 377);
            Controls.Add(btclear);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAD;
        private Label label1;
        private TextBox tbGPAx;
        private Label label2;
        private TextBox tblnputGPAx;
        private GroupBox groupBox1;
        private Label label5;
        private Label GPAMin;
        private Label GPAMax;
        private TextBox tbGPAmin;
        private TextBox tbGPAmax;
        private Button btclear;
        private Label label3;
        private TextBox tbSTD;
    }
}
