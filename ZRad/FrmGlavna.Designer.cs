namespace ZRad
{
    partial class FrmGlavna
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
            label1 = new Label();
            btnBaterija = new Button();
            btnFormacija = new Button();
            btnPomicanje = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(262, 46);
            label1.TabIndex = 0;
            label1.Text = "Glavni izbornik";
            // 
            // btnBaterija
            // 
            btnBaterija.Location = new Point(12, 124);
            btnBaterija.Name = "btnBaterija";
            btnBaterija.Size = new Size(101, 41);
            btnBaterija.TabIndex = 1;
            btnBaterija.Text = "Baterija";
            btnBaterija.UseVisualStyleBackColor = true;
            btnBaterija.Click += btnBaterija_Click;
            // 
            // btnFormacija
            // 
            btnFormacija.Location = new Point(132, 125);
            btnFormacija.Name = "btnFormacija";
            btnFormacija.Size = new Size(101, 39);
            btnFormacija.TabIndex = 2;
            btnFormacija.Text = "Formacija";
            btnFormacija.UseVisualStyleBackColor = true;
            btnFormacija.Click += btnFormacija_Click;
            // 
            // btnPomicanje
            // 
            btnPomicanje.Location = new Point(253, 124);
            btnPomicanje.Name = "btnPomicanje";
            btnPomicanje.Size = new Size(101, 39);
            btnPomicanje.TabIndex = 3;
            btnPomicanje.Text = "Pomicanje";
            btnPomicanje.UseVisualStyleBackColor = true;
            btnPomicanje.Click += btnPomicanje_Click;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 177);
            Controls.Add(btnPomicanje);
            Controls.Add(btnFormacija);
            Controls.Add(btnBaterija);
            Controls.Add(label1);
            Name = "FrmGlavna";
            Text = "FrmGlavna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBaterija;
        private Button btnFormacija;
        private Button btnPomicanje;
    }
}