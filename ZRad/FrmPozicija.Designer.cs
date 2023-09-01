namespace ZRad
{
    partial class FrmPozicija
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
            btnStop = new Button();
            btnGenerate = new Button();
            lblPozicija = new Label();
            btnStart = new Button();
            nupbrojDronova = new NumericUpDown();
            lblbrojDronova = new Label();
            ((System.ComponentModel.ISupportInitialize)nupbrojDronova).BeginInit();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(467, 81);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 17;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Enabled = false;
            btnGenerate.Location = new Point(367, 81);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 16;
            btnGenerate.Text = "Generiraj";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblPozicija
            // 
            lblPozicija.AutoSize = true;
            lblPozicija.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPozicija.Location = new Point(204, 9);
            lblPozicija.Name = "lblPozicija";
            lblPozicija.Size = new Size(141, 46);
            lblPozicija.TabIndex = 15;
            lblPozicija.Text = "Pozicija";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(267, 81);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 14;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // nupbrojDronova
            // 
            nupbrojDronova.Location = new Point(204, 81);
            nupbrojDronova.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nupbrojDronova.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nupbrojDronova.Name = "nupbrojDronova";
            nupbrojDronova.Size = new Size(57, 27);
            nupbrojDronova.TabIndex = 13;
            nupbrojDronova.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblbrojDronova
            // 
            lblbrojDronova.AutoSize = true;
            lblbrojDronova.Location = new Point(16, 81);
            lblbrojDronova.Name = "lblbrojDronova";
            lblbrojDronova.Size = new Size(182, 20);
            lblbrojDronova.TabIndex = 12;
            lblbrojDronova.Text = "Unesi broj dronova (3 - 5):";
            // 
            // FrmPozicija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 139);
            Controls.Add(btnStop);
            Controls.Add(btnGenerate);
            Controls.Add(lblPozicija);
            Controls.Add(btnStart);
            Controls.Add(nupbrojDronova);
            Controls.Add(lblbrojDronova);
            Name = "FrmPozicija";
            Text = "FrmPozicija";
            ((System.ComponentModel.ISupportInitialize)nupbrojDronova).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStop;
        private Button btnGenerate;
        private Label lblPozicija;
        private Button btnStart;
        private NumericUpDown nupbrojDronova;
        private Label lblbrojDronova;
    }
}