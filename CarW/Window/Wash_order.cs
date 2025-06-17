using CarW.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarW.Window
{
    public partial class Wash_order : Form
    {
        string id_e;
        SqlConnection con_p;
        public Wash_order(string id, SqlConnection con)
        {
            InitializeComponent();
            this.id_e = id;
            this.con_p = con;
            button1.Visible = false;
            add.Visible = false;
            label1 .Visible = false;
            label2 .Visible = false;
            label3 .Visible = false;
            label4 .Visible = false;
            button2.Visible = false;
        }

        private void Wash_order_Load(object sender, EventArgs e)
        {
            name.Text = DB_AS.DB_NAME_EMP(con_p, id_e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string se = comboBox1.SelectedItem.ToString();
            txb_ds();
            dataGridView1.DataSource = DB_WASH.SELECT_TABLE(con_p, se);
        }
        private void txb_ds()
        {
            int com = comboBox1.SelectedIndex;
            if (com == 0)
            {
                prodname.Visible = false;
                Desc.Visible = false;
                Quant.Visible = false;
                button1.Visible = true;
                add.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button2.Visible = false;
            }
            else if (com == 1)
            {
                prodname.Visible = true;
                Desc.Visible = true;
                Quant.Visible = true;
                button1.Visible = false;
                add.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4 .Visible = false;
                button2.Visible = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (prodname.Text == "" || Desc.Text == "" || Quant.Text == "")
            {
                MessageBox.Show("Заполните поля","Внимание");
            }
            else
            {
                DB_WASH.ADD_SUPLI(con_p, prodname.Text, Desc.Text, Quant.Text);
                prodname.Text = "";
                Desc.Text = "";
                Quant.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string se = comboBox1.SelectedItem.ToString();
                var sel = dataGridView1.SelectedCells;
                DB_WASH.CLOSE_ORD(con_p, sel);
                dataGridView1.DataSource = DB_WASH.SELECT_TABLE(con_p, se);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void upd_Click(object sender, EventArgs e)
        {
            string se = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = DB_WASH.SELECT_TABLE(con_p, se);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Visible=false;
            try
            {
                var sel = dataGridView1.SelectedCells;
                prodname.Text = sel[1].Value.ToString();
                Desc.Text= sel[2].Value.ToString();
                Quant.Text= sel[3].Value.ToString();
            }
            catch { }

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Visible = true;
        }
    }
}
