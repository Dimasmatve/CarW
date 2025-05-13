namespace CarW.Window
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.TextBox();
            this.models = new System.Windows.Forms.TextBox();
            this.bodwork = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.bodywork = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(15, 64);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(100, 20);
            this.marka.TabIndex = 1;
            this.marka.Visible = false;
            // 
            // models
            // 
            this.models.Location = new System.Drawing.Point(15, 102);
            this.models.Name = "models";
            this.models.Size = new System.Drawing.Size(100, 20);
            this.models.TabIndex = 2;
            this.models.Visible = false;
            // 
            // bodwork
            // 
            this.bodwork.Location = new System.Drawing.Point(15, 140);
            this.bodwork.Name = "bodwork";
            this.bodwork.Size = new System.Drawing.Size(100, 20);
            this.bodwork.TabIndex = 3;
            this.bodwork.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Марка";
            this.label2.Visible = false;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(12, 87);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(46, 13);
            this.model.TabIndex = 5;
            this.model.Text = "Модель";
            this.model.Visible = false;
            // 
            // bodywork
            // 
            this.bodywork.AutoSize = true;
            this.bodywork.Location = new System.Drawing.Point(12, 125);
            this.bodywork.Name = "bodywork";
            this.bodywork.Size = new System.Drawing.Size(37, 13);
            this.bodywork.TabIndex = 6;
            this.bodywork.Text = "Кузов";
            this.bodywork.Visible = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(15, 199);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(121, 23);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Добавить авто";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Visible = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(15, 228);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(121, 23);
            this.final.TabIndex = 8;
            this.final.Text = "Создать заказ";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 96);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID клиента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "id";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(142, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Новое авто";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Описание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Цена:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "0";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.final);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.bodywork);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bodwork);
            this.Controls.Add(this.models);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox models;
        private System.Windows.Forms.TextBox bodwork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label bodywork;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}