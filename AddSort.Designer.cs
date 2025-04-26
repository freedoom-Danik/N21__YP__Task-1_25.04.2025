namespace N21__YP__Task_1_25._04._2025
{
    partial class AddSotr
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // label1 (Фамилия)
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Text = "Фамилия";

            // label2 (Имя)
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Text = "Имя";

            // label3 (Отчество)
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Text = "Отчество";

            // label4 (Дата рождения)
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Text = "Дата рождения";

            // label5 (Адрес)
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Text = "Адрес";

            // label6 (Дата приема)
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Text = "Дата приема";

            // label7 (Должность)
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Text = "Должность";

            // textBox1 (Фамилия)
            this.textBox1.Location = new System.Drawing.Point(100, 6);

            // textBox2 (Имя)
            this.textBox2.Location = new System.Drawing.Point(100, 36);

            // textBox3 (Отчество)
            this.textBox3.Location = new System.Drawing.Point(100, 66);

            // maskedTextBox1 (Дата рождения)
            this.maskedTextBox1.Location = new System.Drawing.Point(100, 96);
            this.maskedTextBox1.Mask = "00/00/0000";

            // textBox4 (Адрес)
            this.textBox4.Location = new System.Drawing.Point(100, 126);

            // maskedTextBox2 (Дата приема)
            this.maskedTextBox2.Location = new System.Drawing.Point(100, 156);
            this.maskedTextBox2.Mask = "00/00/0000";

            // comboBox1 (Должность)
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(100, 186);

            // textBox5 (Почта)
            this.label7.Text = "Почта";
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.textBox5.Location = new System.Drawing.Point(100, 216);

            // button1 (Добавить)
            this.button1.Text = "Добавить";
            this.button1.Location = new System.Drawing.Point(100, 246);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSotr";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.AddSotr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}