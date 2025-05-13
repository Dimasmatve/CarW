using CarW.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CarW.Window
{
    public partial class Client_interaction : Form
    {
        string id_e;
        SqlConnection con_p;

        private int panelOriginalWidth;
        public Client_interaction(string id,SqlConnection con)
        {
            InitializeComponent();
            this.id_e = id;
            this.con_p = con;
            new_client.CheckedChanged += new_client_CheckedChanged;
        }

        private void Client_interaction_Load(object sender, EventArgs e)// ОНО РАБОТАЛО НО ВНЕЗАПНО ПЕРЕСТАЛО
        {
            next.Visible = false;
            dataGridView1.DataSource = DB_AS.DB_LODTAB(con_p, "client");
            panelOriginalWidth = panel1.Width;
            name_e.Text = DB_AS.DB_NAME_EMP(con_p,id_e);
            MessageBox.Show(DB_AS.DB_NAME_EMP(con_p, id_e));
            panel1.Visible = false;
            textBox1.Visible = false; 
            textBox2.Visible = false;
            button1.Visible = false;
            label3.Visible = false;   
        }
        private void Client_interaction_Load_1(object sender, EventArgs e)
        {
            next.Visible = false;
            dataGridView1.DataSource = DB_AS.DB_LODTAB(con_p, "client");
            panelOriginalWidth = panel1.Width;
            name_e.Text = DB_AS.DB_NAME_EMP(con_p, id_e);
            panel1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
        }
        private void new_client_CheckStateChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void new_client_CheckedChanged(object sender, EventArgs e)
        {
                panel1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (Graphics g = textBox1.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(
                    textBox1.Text,
                    textBox1.Font,
                    0,
                    StringFormat.GenericTypographic
                );

                int newWidth = (int)textSize.Width + 20;
                textBox1.Width = newWidth;

                // Логика расширения панели
                if (newWidth > 185)
                {
                    int panelNewWidth = panelOriginalWidth + (newWidth - 185);

                    // Ограничиваем максимальную ширину панели шириной формы
                    panel1.Width = Math.Min(panelNewWidth, this.ClientSize.Width - panel1.Left - 20);
                }
                else
                {
                    // Возвращаем исходную ширину при уменьшении текста
                    panel1.Width = panelOriginalWidth;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (Graphics g = textBox2.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(
                    textBox2.Text,
                    textBox2.Font,
                    0,
                    StringFormat.GenericTypographic
                );

                int newWidth = (int)textSize.Width + 20;
                textBox2.Width = newWidth;

                // Логика расширения панели
                if (newWidth > 185)
                {
                    int panelNewWidth = panelOriginalWidth + (newWidth - 185);

                    // Ограничиваем максимальную ширину панели шириной формы
                    panel1.Width = Math.Min(panelNewWidth, this.ClientSize.Width - panel1.Left - 20);
                }
                else
                {
                    // Возвращаем исходную ширину при уменьшении текста
                    panel1.Width = panelOriginalWidth;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_AS.DB_ADD_CLIENT(con_p,textBox1.Text,textBox2.Text);
            dataGridView1.DataSource = DB_AS.DB_LODTAB(con_p, "client");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bn = dataGridView1.SelectedCells;
            next.Visible = true;
            label3.Visible = true;
            label3.Text = DB_AS.DB_NAME_CLIENT(con_p, bn);
        }

        private void next_Click(object sender, EventArgs e)
        {
            var sel = dataGridView1.SelectedCells;
            string id = DB_AS.DB_ID_CLIENT(con_p, sel);
            Order or = new Order(id, con_p,sel);
            or.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
