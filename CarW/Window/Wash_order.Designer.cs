namespace CarW.Window
{
    partial class Wash_order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.Desc = new System.Windows.Forms.TextBox();
            this.Quant = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Order",
            "Supplies"});
            this.comboBox1.Location = new System.Drawing.Point(13, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            // 
            // prodname
            // 
            this.prodname.Location = new System.Drawing.Point(12, 219);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(122, 20);
            this.prodname.TabIndex = 3;
            this.prodname.Visible = false;
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(12, 245);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(122, 20);
            this.Desc.TabIndex = 4;
            this.Desc.Visible = false;
            // 
            // Quant
            // 
            this.Quant.Location = new System.Drawing.Point(12, 271);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(122, 20);
            this.Quant.TabIndex = 5;
            this.Quant.Visible = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 298);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(122, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Создать заявку";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Wash_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.prodname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Wash_order";
            this.Text = "Wash_order";
            this.Load += new System.EventHandler(this.Wash_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.Button add;
    }
}