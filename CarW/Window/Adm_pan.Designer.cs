using System.Windows.Forms;

namespace CarW.Window
{
    partial class Adm_pan : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.three = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.TextBox();
            this.five = new System.Windows.Forms.TextBox();
            this.six = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.Color.MediumBlue;
            this.name.Location = new System.Drawing.Point(13, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(16, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cars",
            "Clients",
            "Employ",
            "Login_History",
            "Order",
            "Servic",
            "Supplies",
            "State"});
            this.comboBox1.Location = new System.Drawing.Point(71, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица:";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(203, 197);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 21);
            this.update.TabIndex = 4;
            this.update.Text = "ОБНОВИТЬ";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.LightBlue;
            this.one.ForeColor = System.Drawing.Color.Navy;
            this.one.Location = new System.Drawing.Point(97, 230);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(100, 20);
            this.one.TabIndex = 5;
            this.one.Visible = false;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.LightBlue;
            this.two.ForeColor = System.Drawing.Color.Navy;
            this.two.Location = new System.Drawing.Point(97, 256);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(100, 20);
            this.two.TabIndex = 6;
            this.two.Visible = false;
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.LightBlue;
            this.three.ForeColor = System.Drawing.Color.Navy;
            this.three.Location = new System.Drawing.Point(97, 280);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(100, 20);
            this.three.TabIndex = 7;
            this.three.Visible = false;
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.LightBlue;
            this.four.ForeColor = System.Drawing.Color.Navy;
            this.four.Location = new System.Drawing.Point(97, 306);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(100, 20);
            this.four.TabIndex = 8;
            this.four.Visible = false;
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.LightBlue;
            this.five.ForeColor = System.Drawing.Color.Navy;
            this.five.Location = new System.Drawing.Point(97, 332);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(100, 20);
            this.five.TabIndex = 9;
            this.five.Visible = false;
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.LightBlue;
            this.six.ForeColor = System.Drawing.Color.Navy;
            this.six.Location = new System.Drawing.Point(97, 358);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(100, 20);
            this.six.TabIndex = 10;
            this.six.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(16, 254);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 21);
            this.delete.TabIndex = 12;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(16, 280);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 21);
            this.add.TabIndex = 13;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox2.ForeColor = System.Drawing.Color.Navy;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cars",
            "Clients",
            "Employ",
            "Login_History",
            "Order",
            "Servic",
            "Supplies"});
            this.comboBox2.Location = new System.Drawing.Point(447, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(445, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Стобец для фильтрации";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(447, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Adm_pan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name);
            this.Name = "Adm_pan";
            this.Text = "Adm_pan";
            this.Load += new System.EventHandler(this.Adm_pan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.TextBox five;
        private System.Windows.Forms.TextBox six;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}