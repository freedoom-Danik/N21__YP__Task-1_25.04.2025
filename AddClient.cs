using N21__YP__Task_1_25._04._2025.Data;
using N21__YP__Task_1_25._04._2025.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = DB.CreateContext())
            {
                var today = DateTime.Now.Year;
                int age = today - int.Parse(maskedTextBox2.Text.Substring(6, 4));

                db.Clients.Add(new Clients
                {
                    Фио = textBox1.Text,
                    Возраст = age,
                    Телефон = maskedTextBox1.Text,
                    Почта = textBox4.Text,
                    Разряд = comboBox1.Text,
                    Дата_Регистрации = DateTime.Parse(maskedTextBox3.Text),
                    Группа = GetGroup(age)
                });

                db.SaveChanges();
                MessageBox.Show("Клиент успешно добавлен!");
                this.Close();
            }
        }

        private string GetGroup(int age)
        {
            if (age <= 9) return "A1";
            if (age <= 16) return "A2";
            if (age <= 25) return "Б";
            return "В";
        }
    }
}