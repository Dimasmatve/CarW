using CarW.Data;
using CarW.Window;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarW
{
    public partial class Avt : Form
    {
        readonly SqlConnection con = DB_AS.DB_CON();//Подключение к БД
        public Avt()
        {
            InitializeComponent();
        }

        private void Avt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = DB_AS.DB_AVT(con, textBox1.Text, textBox2.Text);
            string rou = DB_AS.DB_INI_ROULE(con,res);
            if (res != "0")
            {
                if (rou == "1")
                {

                    Client_interaction op = new Client_interaction(res, con);
                    op.ShowDialog();
                }
                else if (rou == "2")
                {
                    Adm_pan op = new Adm_pan(res, con);
                    op.ShowDialog();
                }
                else if (rou == "3")
                {
                    Wash_order w = new Wash_order(res, con);
                    w.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Роль не найдена", "ошибка");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "men_iii";
            textBox2.Text = "123m";
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "admin_kkk";
            textBox2.Text = "123a";
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "washer_iix";
            textBox2.Text = "123w";
            button1_Click(sender, e);
        }
    }
}
