using N21__YP__Task_1_25._04._2025.Data;
using N21__YP__Task_1_25._04._2025.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class AddSotr : Form
    {
        public AddSotr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Добавить сотрудника
        {
            try
            {
                using (var db = DB.CreateContext())
                {
                    db.Sotrud.Add(new Sotrud
                    {
                        Фамилия = textBox1.Text,
                        Имя = textBox2.Text,
                        Отчество = textBox3.Text,
                        Дата_Рождения = DateTime.Parse(maskedTextBox1.Text),
                        Адрес = textBox4.Text,
                        Дата_Приема = DateTime.Parse(maskedTextBox2.Text),
                        Должность = comboBox1.SelectedItem?.ToString(),
                        Почта = textBox5.Text
                    });
                    db.SaveChanges();
                    MessageBox.Show("Сотрудник успешно добавлен!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}");
            }
        }

        private void AddSotr_Load(object sender, EventArgs e)
        {
            // Загрузка списка должностей в ComboBox
            comboBox1.Items.AddRange(new[] { "Администратор", "Тренер", "Менеджер" });
        }
    }
}