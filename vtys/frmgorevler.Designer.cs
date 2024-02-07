namespace vtys
{
    partial class frmgorevler
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
            txtgid = new TextBox();
            txtgad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbp = new ComboBox();
            cmbc = new ComboBox();
            cmbd = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dbas = new DateTimePicker();
            dbit = new DateTimePicker();
            txtgec = new TextBox();
            button4 = new Button();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtgid
            // 
            txtgid.Location = new Point(209, 141);
            txtgid.Name = "txtgid";
            txtgid.Size = new Size(151, 27);
            txtgid.TabIndex = 0;
            // 
            // txtgad
            // 
            txtgad.Location = new Point(209, 181);
            txtgad.Name = "txtgad";
            txtgad.Size = new Size(151, 27);
            txtgad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(20, 137);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 5;
            label1.Text = "Gorev ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 177);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 6;
            label2.Text = "Gorev Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 217);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 7;
            label3.Text = "Proje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(18, 257);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 8;
            label4.Text = "Calisan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 297);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 9;
            label5.Text = "Durum";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(366, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(922, 387);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button1.Location = new Point(61, 478);
            button1.Name = "button1";
            button1.Size = new Size(107, 43);
            button1.TabIndex = 11;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button2.Location = new Point(174, 478);
            button2.Name = "button2";
            button2.Size = new Size(107, 43);
            button2.TabIndex = 12;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button3.Location = new Point(117, 527);
            button3.Name = "button3";
            button3.Size = new Size(107, 43);
            button3.TabIndex = 13;
            button3.Text = "Guncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cmbp
            // 
            cmbp.FormattingEnabled = true;
            cmbp.Location = new Point(209, 218);
            cmbp.Name = "cmbp";
            cmbp.Size = new Size(151, 28);
            cmbp.TabIndex = 14;
            // 
            // cmbc
            // 
            cmbc.FormattingEnabled = true;
            cmbc.Location = new Point(209, 259);
            cmbc.Name = "cmbc";
            cmbc.Size = new Size(151, 28);
            cmbc.TabIndex = 15;
            // 
            // cmbd
            // 
            cmbd.FormattingEnabled = true;
            cmbd.Location = new Point(209, 300);
            cmbd.Name = "cmbd";
            cmbd.Size = new Size(151, 28);
            cmbd.TabIndex = 16;
            cmbd.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 337);
            label6.Name = "label6";
            label6.Size = new Size(161, 28);
            label6.TabIndex = 17;
            label6.Text = "Başlangıç Tarihi";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(22, 377);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 18;
            label7.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(18, 417);
            label8.Name = "label8";
            label8.Size = new Size(154, 28);
            label8.TabIndex = 19;
            label8.Text = "Gecikme süresi";
            // 
            // dbas
            // 
            dbas.Location = new Point(209, 341);
            dbas.Name = "dbas";
            dbas.Size = new Size(151, 27);
            dbas.TabIndex = 20;
            dbas.ValueChanged += dtbas_ValueChanged;
            // 
            // dbit
            // 
            dbit.Location = new Point(209, 381);
            dbit.Name = "dbit";
            dbit.Size = new Size(151, 27);
            dbit.TabIndex = 21;
            // 
            // txtgec
            // 
            txtgec.Location = new Point(209, 421);
            txtgec.Name = "txtgec";
            txtgec.Size = new Size(151, 27);
            txtgec.TabIndex = 22;
            // 
            // button4
            // 
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button4.Location = new Point(1091, 548);
            button4.Name = "button4";
            button4.Size = new Size(107, 43);
            button4.TabIndex = 23;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(679, 40);
            label9.Name = "label9";
            label9.Size = new Size(279, 62);
            label9.TabIndex = 24;
            label9.Text = "GÖREVLER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Без_названия__1_;
            pictureBox1.Location = new Point(538, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // frmgorevler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1307, 617);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(txtgec);
            Controls.Add(dbit);
            Controls.Add(dbas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbd);
            Controls.Add(cmbc);
            Controls.Add(cmbp);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtgad);
            Controls.Add(txtgid);
            Name = "frmgorevler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gorevler";
            Load += frmgorevler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtgid;
        private TextBox txtgad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cmbp;
        private ComboBox cmbc;
        private ComboBox cmbd;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dbas;
        private DateTimePicker dbit;
        private TextBox txtgec;
        private Button button4;
        private Label label9;
        private PictureBox pictureBox1;
    }
}