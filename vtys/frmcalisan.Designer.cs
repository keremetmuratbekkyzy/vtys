namespace vtys
{
    partial class frmcalisan
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
            dataGridView1 = new DataGridView();
            txtcalid = new TextBox();
            txtcalsoyad = new TextBox();
            txtcalad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(557, 214);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtcalid
            // 
            txtcalid.Location = new Point(126, 142);
            txtcalid.Name = "txtcalid";
            txtcalid.Size = new Size(125, 27);
            txtcalid.TabIndex = 1;
            // 
            // txtcalsoyad
            // 
            txtcalsoyad.Location = new Point(126, 224);
            txtcalsoyad.Name = "txtcalsoyad";
            txtcalsoyad.Size = new Size(125, 27);
            txtcalsoyad.TabIndex = 3;
            // 
            // txtcalad
            // 
            txtcalad.Location = new Point(126, 181);
            txtcalad.Name = "txtcalad";
            txtcalad.Size = new Size(125, 27);
            txtcalad.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label1.Location = new Point(13, 145);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 5;
            label1.Text = "ÇalışanID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 184);
            label2.Name = "label2";
            label2.Size = new Size(46, 26);
            label2.TabIndex = 6;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label3.Location = new Point(13, 224);
            label3.Name = "label3";
            label3.Size = new Size(75, 26);
            label3.TabIndex = 7;
            label3.Text = "Soyadı";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button1.Location = new Point(135, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button2.Location = new Point(135, 327);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 9;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button3.Location = new Point(135, 292);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(698, 387);
            button4.Name = "button4";
            button4.Size = new Size(80, 40);
            button4.TabIndex = 11;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Sylfaen", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(325, 32);
            label4.Name = "label4";
            label4.Size = new Size(323, 62);
            label4.TabIndex = 12;
            label4.Text = "ÇALIŞANLAR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Без_названия1;
            pictureBox1.Location = new Point(166, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // frmcalisan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(821, 439);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcalad);
            Controls.Add(txtcalsoyad);
            Controls.Add(txtcalid);
            Controls.Add(dataGridView1);
            Name = "frmcalisan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalışanlar";
            Load += frmcalisan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtcalid;
        private TextBox txtcalsoyad;
        private TextBox txtcalad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private PictureBox pictureBox1;
    }
}