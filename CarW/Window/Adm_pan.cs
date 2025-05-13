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

        }

        private void Adm_pan_Load(object sender, EventArgs e)
        {
            name.Text = DB_AS.DB_NAME_EMP(con_p, id_e);
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string se = comboBox1.SelectedItem.ToString();
            txb_display(se);
            dataGridView1.DataSource = DB_ADM.SELECT_TABLE(con_p, se);
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
                six.Visible = false;
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
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["car_id"].Value);

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string se = comboBox1.SelectedIndex.ToString();
            var sel = dataGridView1.SelectedCells;
            DB_ADM.UPDATE(con_p, sel, one.Text, two.Text, three.Text, four.Text, five.Text, se);
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
    }
}
