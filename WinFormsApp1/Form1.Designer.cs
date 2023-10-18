namespace WinFormsApp1
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
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(488, 364);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 395);
            button2.Name = "button2";
            button2.Size = new Size(185, 23);
            button2.TabIndex = 2;
            button2.Text = "Змінити частоту оновлення";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(315, 395);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 3;
            button1.Text = "Завершити процес";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(570, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 4;
            label1.Text = "Інформація про процес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(521, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Ідентифікатор:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 97);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Час старту:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 189);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Кількість потоків:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 134);
            label5.Name = "label5";
            label5.Size = new Size(88, 45);
            label5.TabIndex = 8;
            label5.Text = "Загальний\r\n процесорний \r\nчас:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(516, 220);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 9;
            label6.Text = "Кількість копій:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(670, 56);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(614, 97);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(614, 148);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(664, 189);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(664, 220);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 430);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}