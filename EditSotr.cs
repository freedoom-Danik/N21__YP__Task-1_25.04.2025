using N21__YP__Task_1_25._04._2025.Models;
using N21__YP__Task_1_25._04._2025.Data;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class EditSotr : Form
    {
        private int _id; // ID редактируемого сотрудника

        public EditSotr(int id)
        {
            InitializeComponent();
            _id = id;
            LoadData(); // Загрузка данных сотрудника при открытии формы
        }

        private void LoadData()
        {
            using (var db = DB.CreateContext())
            {
                var sotrud = db.Sotrud.Find(_id);
                if (sotrud != null)
                {
                    textBox1.Text = sotrud.Фамилия;
                    textBox2.Text = sotrud.Имя;
                    textBox3.Text = sotrud.Отчество;
                    maskedTextBox1.Text = sotrud.Дата_Рождения.ToString("dd.MM.yyyy");
                    textBox4.Text = sotrud.Адрес;
                    maskedTextBox2.Text = sotrud.Дата_Приема.ToString("dd.MM.yyyy");
                    comboBox1.SelectedItem = sotrud.Должность;
                    textBox5.Text = sotrud.Почта;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Сохранить
        {
            using (var db = DB.CreateContext())
            {
                var sotrud = db.Sotrud.Find(_id);
                if (sotrud != null)
                {
                    sotrud.Фамилия = textBox1.Text;
                    sotrud.Имя = textBox2.Text;
                    sotrud.Отчество = textBox3.Text;
                    sotrud.Дата_Рождения = DateTime.Parse(maskedTextBox1.Text);
                    sotrud.Адрес = textBox4.Text;
                    sotrud.Дата_Приема = DateTime.Parse(maskedTextBox2.Text);
                    sotrud.Должность = comboBox1.SelectedItem?.ToString();
                    sotrud.Почта = textBox5.Text;

                    db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Отмена
        {
            this.Close();
        }
    }
}