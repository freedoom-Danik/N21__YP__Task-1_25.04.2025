using N21__YP__Task_1_25._04._2025.Data;
using N21__YP__Task_1_25._04._2025.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Windows.Forms;
using System.Linq;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class Sotr : Form
    {
        public Sotr()
        {
            InitializeComponent();
            LoadData(); // Загрузка данных при открытии формы
        }

        private void LoadData()
        {
            using (var db = DB.CreateContext())
            {
                dataGridView1.DataSource = db.Sotrud.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Добавить
        {
            AddSotr addForm = new AddSotr();
            addForm.ShowDialog();
            LoadData(); // Обновляем данные после добавления
        }

        private void button2_Click(object sender, EventArgs e) // Изменить
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                EditSotr editForm = new EditSotr(id);
                editForm.ShowDialog();
                LoadData(); // Обновляем данные после изменения
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для редактирования!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Удалить
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                using (var db = DB.CreateContext())
                {
                    var sotrud = db.Sotrud.Find(id);
                    if (sotrud != null)
                    {
                        db.Sotrud.Remove(sotrud);
                        db.SaveChanges();
                        LoadData(); // Обновляем данные после удаления
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления!");
            }
        }
        private void button5_Click(object sender, EventArgs e) // Обновить
        {
            LoadData();
        }
    }
}