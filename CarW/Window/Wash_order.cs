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
            }
            else if (com == 1)
            {
                prodname.Visible = true;
                Desc.Visible = true;
                Quant.Visible = true;
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
    }
}
