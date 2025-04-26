namespace N21__YP__Task_1_25._04._2025
{
    partial class Sotr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 300);
            this.dataGridView1.TabIndex = 0;

            // button1
            this.button1.Text = "Добавить";
            this.button1.Location = new System.Drawing.Point(10, 310);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // button2
            this.button2.Text = "Изменить";
            this.button2.Location = new System.Drawing.Point(100, 310);
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // button3
            this.button3.Text = "Удалить";
            this.button3.Location = new System.Drawing.Point(200, 310);
            this.button3.Click += new System.EventHandler(this.button3_Click);
              
            // button5
            this.button5.Text = "Обновить";
            this.button5.Location = new System.Drawing.Point(400, 310);
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // checkBox1
            this.checkBox1.Text = "Показать всех";
            this.checkBox1.Location = new System.Drawing.Point(500, 310);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sotr";
            this.Text = "Учет сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}