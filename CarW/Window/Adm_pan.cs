using CarW.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarW.Window
{
    public partial class Adm_pan : Form
    {

        string id_e;
        SqlConnection con_p;
        public Adm_pan(string id, SqlConnection con)
        {
            InitializeComponent();
            this.id_e = id;
            this.con_p = con;

            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged; // Новая строка
        }

        private void Adm_pan_Load(object sender, EventArgs e)
        {
            name.Text = DB_AS.DB_NAME_EMP(con_p, id_e);
            //LoadTablesToComboBox();// вызывает подгруз таблиц из бд, ломает подгрузку полей
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            string se = comboBox1.SelectedItem.ToString();
            txb_display(se);
            dataGridView1.DataSource = DB_ADM.SELECT_TABLE(con_p, se);

            string tableName = comboBox1.SelectedItem.ToString();
            LoadColumnsForTable(tableName);
        }
        private void LoadColumnsForTable(string tableName)//муть с фильтрацией(подгрузка полей из таблицы)
        {
            List<string> columns = new List<string>();

            try
            {
                if (con_p.State != ConnectionState.Open)
                    con_p.Open();

                string query = @"SELECT COLUMN_NAME 
                        FROM INFORMATION_SCHEMA.COLUMNS 
                        WHERE TABLE_NAME = @TableName";

                using (SqlCommand command = new SqlCommand(query, con_p))
                {
                    command.Parameters.AddWithValue("@TableName", tableName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки столбцов: {ex.Message}");
            }

            comboBox2.DataSource = null;
            comboBox2.Items.Clear();

            if (columns.Any())
            {
                comboBox2.DataSource = columns;
            }
            else
            {
                MessageBox.Show("Столбцы для выбранной таблицы не найдены.");
            }
        }
        private void LoadTablesToComboBox()//ещё одна муть для собабоксав
        {
            List<string> tables = new List<string>();

            try
            {
                if (con_p.State != ConnectionState.Open)
                    con_p.Open();

                string query = @"SELECT TABLE_NAME 
                        FROM INFORMATION_SCHEMA.TABLES 
                        WHERE TABLE_TYPE = 'BASE TABLE'";

                using (SqlCommand command = new SqlCommand(query, con_p))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки таблиц: {ex.Message}");
            }

            comboBox1.DataSource = tables;
        }

        public void txb_display(string select)
        {
            int com = comboBox1.SelectedIndex;
            if (com == 0)
            {
                one.Visible = true;
                two.Visible = true;
                three.Visible = true;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = true;
                add.Visible = false;
            }
            else if (com == 1)
            {
                one.Visible = true;
                two.Visible = true;
                three.Visible = false;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = false;
                add.Visible = false;
            }
            else if(com == 2)
            {
                one.Visible = true;
                two.Visible = true;
                three.Visible = true;
                four.Visible = true;
                five.Visible = true;
                six.Visible = true;
                delete.Visible = false;
                add.Visible = true;
            }
            else if (com == 3)
            {
                one.Visible = false;
                two.Visible = false;
                three.Visible = false;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = false;
                add.Visible = false;
            }
            else if (com == 4)
            {
                one.Visible = true;
                two.Visible = false;
                three.Visible = false;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = false;
                add.Visible = false;
            }
            else if (com == 5)
            {
                one.Visible = true;
                two.Visible = true;
                three.Visible = true;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = false;
                add.Visible = true;
            }
            else if (com == 6)
            {
                one.Visible = true;
                two.Visible = false;
                three.Visible = false;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = false;
                add.Visible = true;
            }
            else if (com == 7)
            {
                one.Visible = true;
                two.Visible = true;
                three.Visible = true;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                delete.Visible = false;
                add.Visible = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void delete_Click(object sender, EventArgs e)// Спорная функция, приходится сносить не только авто но и заказ с этим авто. Пока что можно оставить, но ввобще скорее всего стоит отказаться
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем car_id из выбранной строки
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["car_id"].Value);//при удалении Suplies кидает сюда

                // Уточняем имя таблицы
                string tableName = "Cars"; // Для таблицы Cars

                // Выполняем удаление
                DB_AS.DeleteRecord(con_p, tableName, id); // Обновляем данные
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string se = comboBox1.SelectedIndex.ToString();
            var sel = dataGridView1.SelectedCells;
            if (se == "0")//Cars
            {
                one.Text = sel[1].Value.ToString();
                two.Text = sel[2].Value.ToString();
                three.Text = sel[3].Value.ToString();

            }
            else if(se == "1")
            {
                one.Text = sel[1].Value.ToString();
                two.Text = sel[2].Value.ToString();
            }
            else if (se == "2")
            {
                one.Text = sel[1].Value.ToString();
                two.Text = sel[2].Value.ToString();
                three.Text = sel[3].Value.ToString();
                four.Text = sel[4].Value.ToString();
                five.Text = sel[5].Value.ToString();
                six.Text = sel[6].Value.ToString();
            }
            else if (se == "3")
            {
                MessageBox.Show("Тут менять ничего не надо");
            }
            else if (se == "4")
            {
                one.Text = sel[5].Value.ToString();
            }
            else if (se == "5")
            {
                one.Text = sel[1].Value.ToString();
                two.Text = sel[2].Value.ToString();
                three.Text = sel[3].Value.ToString();
            }
            else if (se == "6")
            {
                one.Text = sel[4].Value.ToString();
            }
            else if (se == "7")
            {
                one.Text = sel[1].Value.ToString();
                two.Text = sel[2].Value.ToString();
                three.Text = sel[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string se = comboBox1.SelectedIndex.ToString();
            var sel = dataGridView1.SelectedCells;
            DB_ADM.UPDATE(con_p, sel, one.Text, two.Text, three.Text, four.Text, five.Text, six.Text, se);
        }

        private void add_Click(object sender, EventArgs e)
        {
            string se = comboBox1.SelectedIndex.ToString();
            DB_ADM.INSERT_DATA(con_p, one.Text, two.Text, three.Text, four.Text, five.Text, se);
            //if (se == "2")
            //{
            //    DB_ADM.INSERT_DATA(con_p, one.Text, two.Text, three.Text, four.Text, five.Text, se);
            //}
            //else if (se == "5")
            //{
            //    DB_ADM.INSERT_DATA(con_p, one.Text, two.Text, three.Text, four.Text, five.Text, se);
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selectedColumn = comboBox2.SelectedItem.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{comboBox2.Text} LIKE '%{textBox1.Text}%'";// работает не со всеми полями(всякие emploee_id)
            }
            catch{}
        }
    }
}
