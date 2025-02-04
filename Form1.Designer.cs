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
            tbGPAmin = new TextBox();
            tbGPAmax = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAD
            // 
            btnAD.Location = new Point(256, 67);
            btnAD.Name = "btnAD";
            btnAD.Size = new Size(83, 54);
            btnAD.TabIndex = 0;
            btnAD.Text = "button1";
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
            tbGPAx.Location = new Point(117, 22);
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
            tblnputGPAx.Location = new Point(117, 67);
            tblnputGPAx.Name = "tblnputGPAx";
            tblnputGPAx.Size = new Size(100, 23);
            tblnputGPAx.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbGPAmin);
            groupBox1.Controls.Add(tbGPAmax);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
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
            groupBox1.Text = "groupBox1";
            // 
            // tbGPAmin
            // 
            tbGPAmin.Location = new Point(117, 134);
            tbGPAmin.Name = "tbGPAmin";
            tbGPAmin.Size = new Size(100, 23);
            tbGPAmin.TabIndex = 9;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 137);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "GPAMin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "GPAMax";
            // 
            // button1
            // 
            button1.Location = new Point(33, 242);
            button1.Name = "button1";
            button1.Size = new Size(318, 74);
            button1.TabIndex = 10;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 377);
            Controls.Add(button1);
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
        private Label label4;
        private Label label3;
        private TextBox tbGPAmin;
        private TextBox tbGPAmax;
        private Button button1;
    }
}
