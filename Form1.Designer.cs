namespace Lr1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            yearOfOpening = new DateTimePicker();
            Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Навзвание станции";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 1;
            label2.Text = "Количество мест";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 2;
            label3.Text = "Проданные билеты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F);
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(160, 21);
            label4.TabIndex = 3;
            label4.Text = "Телефонный номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F);
            label5.Location = new Point(12, 158);
            label5.Name = "label5";
            label5.Size = new Size(191, 21);
            label5.TabIndex = 4;
            label5.Text = "Средняя посещаемость";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F);
            label6.Location = new Point(12, 193);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 5;
            label6.Text = "Год открытия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F);
            label7.Location = new Point(12, 229);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 6;
            label7.Text = "Адрес";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F);
            label8.Location = new Point(12, 260);
            label8.Name = "label8";
            label8.Size = new Size(167, 21);
            label8.TabIndex = 7;
            label8.Text = "Количество станций";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(236, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(236, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(236, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(236, 262);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(236, 231);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // yearOfOpening
            // 
            yearOfOpening.ImeMode = ImeMode.NoControl;
            yearOfOpening.Location = new Point(236, 193);
            yearOfOpening.Name = "yearOfOpening";
            yearOfOpening.Size = new Size(100, 23);
            yearOfOpening.TabIndex = 15;
            yearOfOpening.Value = new DateTime(2024, 2, 12, 0, 0, 0, 0);
            // 
            // Close
            // 
            Close.Location = new Point(490, 655);
            Close.Name = "Close";
            Close.Size = new Size(112, 23);
            Close.TabIndex = 16;
            Close.Text = "Выход";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 690);
            Controls.Add(Close);
            Controls.Add(yearOfOpening);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DateTimePicker yearOfOpening;
        private Button Close;
    }
}
