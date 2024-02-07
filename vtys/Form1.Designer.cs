namespace vtys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            dtbit = new DateTimePicker();
            dtbas = new DateTimePicker();
            label5 = new Label();
            cmbdur = new ComboBox();
            btnpsil = new Button();
            btnpgun = new Button();
            btnpekle = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtpad = new TextBox();
            txtpid = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(353, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(720, 319);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtbit);
            groupBox1.Controls.Add(dtbas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbdur);
            groupBox1.Controls.Add(btnpsil);
            groupBox1.Controls.Add(btnpgun);
            groupBox1.Controls.Add(btnpekle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpad);
            groupBox1.Controls.Add(txtpid);
            groupBox1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(5, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 409);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proje işlemleri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtbit
            // 
            dtbit.Location = new Point(175, 185);
            dtbit.Name = "dtbit";
            dtbit.Size = new Size(140, 34);
            dtbit.TabIndex = 14;
            // 
            // dtbas
            // 
            dtbas.Location = new Point(175, 147);
            dtbas.Name = "dtbas";
            dtbas.Size = new Size(140, 34);
            dtbas.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 231);
            label5.Name = "label5";
            label5.Size = new Size(146, 26);
            label5.TabIndex = 13;
            label5.Text = "Proje durumu";
            label5.Click += label5_Click;
            // 
            // cmbdur
            // 
            cmbdur.FormattingEnabled = true;
            cmbdur.Location = new Point(175, 223);
            cmbdur.Name = "cmbdur";
            cmbdur.Size = new Size(140, 34);
            cmbdur.TabIndex = 12;
            cmbdur.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnpsil
            // 
            btnpsil.Location = new Point(245, 273);
            btnpsil.Name = "btnpsil";
            btnpsil.Size = new Size(70, 29);
            btnpsil.TabIndex = 11;
            btnpsil.Text = "Sil";
            btnpsil.UseVisualStyleBackColor = true;
            btnpsil.Click += btnpsil_Click;
            // 
            // btnpgun
            // 
            btnpgun.Location = new Point(175, 312);
            btnpgun.Name = "btnpgun";
            btnpgun.Size = new Size(140, 29);
            btnpgun.TabIndex = 10;
            btnpgun.Text = "Güncelle";
            btnpgun.UseVisualStyleBackColor = true;
            btnpgun.Click += btnpgun_Click;
            // 
            // btnpekle
            // 
            btnpekle.Location = new Point(175, 273);
            btnpekle.Name = "btnpekle";
            btnpekle.Size = new Size(64, 29);
            btnpekle.TabIndex = 9;
            btnpekle.Text = "Ekle";
            btnpekle.UseVisualStyleBackColor = true;
            btnpekle.Click += btnpekle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 153);
            label4.Name = "label4";
            label4.Size = new Size(169, 26);
            label4.TabIndex = 8;
            label4.Text = "Başlangıç Tarihi";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 191);
            label3.Name = "label3";
            label3.Size = new Size(121, 26);
            label3.TabIndex = 7;
            label3.Text = "Bitiş Tarihi";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label2.Location = new Point(23, 115);
            label2.Name = "label2";
            label2.Size = new Size(95, 26);
            label2.TabIndex = 6;
            label2.Text = "ProjeAdı";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 70);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 5;
            label1.Text = "ProjeID";
            label1.Click += label1_Click;
            // 
            // txtpad
            // 
            txtpad.Location = new Point(176, 107);
            txtpad.Name = "txtpad";
            txtpad.Size = new Size(140, 34);
            txtpad.TabIndex = 1;
            // 
            // txtpid
            // 
            txtpid.Location = new Point(175, 67);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(140, 34);
            txtpid.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button4.Location = new Point(464, 517);
            button4.Name = "button4";
            button4.Size = new Size(128, 52);
            button4.TabIndex = 2;
            button4.Text = "Görevler";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            button5.Location = new Point(761, 517);
            button5.Name = "button5";
            button5.Size = new Size(121, 52);
            button5.TabIndex = 3;
            button5.Text = "Çalışanlar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(541, 49);
            label6.Name = "label6";
            label6.Size = new Size(256, 62);
            label6.TabIndex = 6;
            label6.Text = "PROJELER";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Без_названия;
            pictureBox1.Location = new Point(418, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(968, 517);
            button1.Name = "button1";
            button1.Size = new Size(94, 52);
            button1.TabIndex = 8;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1074, 593);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proje";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtpad;
        private TextBox txtpid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnpsil;
        private Button btnpgun;
        private Button btnpekle;
        private Button button4;
        private Button button5;
        private ComboBox cmbdur;
        private Label label5;
        private DateTimePicker dtbit;
        private DateTimePicker dtbas;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
