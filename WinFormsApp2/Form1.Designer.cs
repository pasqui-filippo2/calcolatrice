namespace WinFormsApp2
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
            btn0 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnUguale = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnPer = new Button();
            btnMeno = new Button();
            btnplus = new Button();
            btnReset = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Location = new Point(113, 102);
            btn0.Name = "btn0";
            btn0.Size = new Size(30, 26);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(149, 166);
            btn7.Name = "btn7";
            btn7.Size = new Size(30, 26);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(113, 166);
            btn6.Name = "btn6";
            btn6.Size = new Size(30, 26);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(185, 134);
            btn5.Name = "btn5";
            btn5.Size = new Size(30, 26);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(149, 134);
            btn4.Name = "btn4";
            btn4.Size = new Size(30, 26);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(113, 134);
            btn3.Name = "btn3";
            btn3.Size = new Size(30, 26);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(185, 102);
            btn2.Name = "btn2";
            btn2.Size = new Size(30, 26);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(149, 102);
            btn1.Name = "btn1";
            btn1.Size = new Size(30, 26);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnUguale
            // 
            btnUguale.Location = new Point(198, 198);
            btnUguale.Name = "btnUguale";
            btnUguale.Size = new Size(62, 26);
            btnUguale.TabIndex = 8;
            btnUguale.Text = "=";
            btnUguale.UseVisualStyleBackColor = true;
            btnUguale.Click += btnUguale_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(162, 198);
            btn9.Name = "btn9";
            btn9.Size = new Size(30, 26);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(185, 166);
            btn8.Name = "btn8";
            btn8.Size = new Size(30, 26);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btnPer
            // 
            btnPer.Location = new Point(230, 102);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(30, 26);
            btnPer.TabIndex = 11;
            btnPer.Text = "x";
            btnPer.UseVisualStyleBackColor = true;
            // 
            // btnMeno
            // 
            btnMeno.Location = new Point(230, 134);
            btnMeno.Name = "btnMeno";
            btnMeno.Size = new Size(30, 26);
            btnMeno.TabIndex = 12;
            btnMeno.Text = "-";
            btnMeno.UseVisualStyleBackColor = true;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(230, 166);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(30, 26);
            btnplus.TabIndex = 13;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(113, 198);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(43, 26);
            btnReset.TabIndex = 15;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 71);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 16;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(141, 71);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnplus);
            Controls.Add(btnMeno);
            Controls.Add(btnPer);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnUguale);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnUguale;
        private Button btn9;
        private Button btn8;
        private Button btnPer;
        private Button btnMeno;
        private Button btnplus;
        private Button btnReset;
        private Label label1;
        private Label label2;
    }
}
