namespace ZRad
{
    partial class FrmBaterija
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
            lblBrojDronova = new Label();
            nudBrojDronova = new NumericUpDown();
            btnStart = new Button();
            btnGenerirajPodatke = new Button();
            btnStop = new Button();
            ((System.ComponentModel.ISupportInitialize)nudBrojDronova).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 18);
            label1.Name = "label1";
            label1.Size = new Size(143, 46);
            label1.TabIndex = 0;
            label1.Text = "Baterija";
            // 
            // lblBrojDronova
            // 
            lblBrojDronova.AutoSize = true;
            lblBrojDronova.Location = new Point(12, 107);
            lblBrojDronova.Name = "lblBrojDronova";
            lblBrojDronova.Size = new Size(174, 20);
            lblBrojDronova.TabIndex = 1;
            lblBrojDronova.Text = "Unesi broj dronova (3-5):";
            // 
            // nudBrojDronova
            // 
            nudBrojDronova.Location = new Point(183, 106);
            nudBrojDronova.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudBrojDronova.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudBrojDronova.Name = "nudBrojDronova";
            nudBrojDronova.Size = new Size(69, 27);
            nudBrojDronova.TabIndex = 2;
            nudBrojDronova.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.Location = new Point(264, 104);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnGenerirajPodatke
            // 
            btnGenerirajPodatke.Location = new Point(366, 104);
            btnGenerirajPodatke.Name = "btnGenerirajPodatke";
            btnGenerirajPodatke.Size = new Size(94, 29);
            btnGenerirajPodatke.TabIndex = 4;
            btnGenerirajPodatke.Text = "Generiraj";
            btnGenerirajPodatke.UseVisualStyleBackColor = true;
            btnGenerirajPodatke.Click += btnGenerirajPodatke_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(475, 103);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // FrmBaterija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 156);
            Controls.Add(btnStop);
            Controls.Add(btnGenerirajPodatke);
            Controls.Add(btnStart);
            Controls.Add(nudBrojDronova);
            Controls.Add(lblBrojDronova);
            Controls.Add(label1);
            Name = "FrmBaterija";
            Text = "FrmBaterija";
            ((System.ComponentModel.ISupportInitialize)nudBrojDronova).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBrojDronova;
        private NumericUpDown nudBrojDronova;
        private Button btnStart;
        private Button btnGenerirajPodatke;
        private Button btnStop;
    }
}