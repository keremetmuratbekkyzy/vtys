namespace vtys
{
    partial class giris
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(108, 226);
            label1.Name = "label1";
            label1.Size = new Size(457, 79);
            label1.TabIndex = 0;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(233, 333);
            button1.Name = "button1";
            button1.Size = new Size(193, 62);
            button1.TabIndex = 1;
            button1.Text = "Ana Sayfa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_black_background_with_laptop_coffee_cup_calculator_top_view;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(650, 479);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}