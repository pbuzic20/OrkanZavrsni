namespace ZRad
{
    partial class FrmFormacija
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
            btnStart = new Button();
            nupbrojDronova = new NumericUpDown();
            lblBrojDronova = new Label();
            lblFormation = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupbrojDronova).BeginInit();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(469, 107);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 10;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Enabled = false;
            btnGenerate.Location = new Point(369, 107);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generiraj";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(269, 107);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // nupbrojDronova
            // 
            nupbrojDronova.Location = new Point(206, 107);
            nupbrojDronova.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nupbrojDronova.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nupbrojDronova.Name = "nupbrojDronova";
            nupbrojDronova.Size = new Size(57, 27);
            nupbrojDronova.TabIndex = 7;
            nupbrojDronova.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblBrojDronova
            // 
            lblBrojDronova.AutoSize = true;
            lblBrojDronova.Location = new Point(18, 107);
            lblBrojDronova.Name = "lblBrojDronova";
            lblBrojDronova.Size = new Size(182, 20);
            lblBrojDronova.TabIndex = 6;
            lblBrojDronova.Text = "Unesi broj dronova (3 - 5):";
            // 
            // lblFormation
            // 
            lblFormation.AutoSize = true;
            lblFormation.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormation.ForeColor = SystemColors.ButtonFace;
            lblFormation.Location = new Point(186, 168);
            lblFormation.Name = "lblFormation";
            lblFormation.Size = new Size(117, 46);
            lblFormation.TabIndex = 11;
            lblFormation.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 25);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 12;
            label1.Text = "Formacija";
            // 
            // FrmFormacija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(label1);
            Controls.Add(lblFormation);
            Controls.Add(btnStop);
            Controls.Add(btnGenerate);
            Controls.Add(btnStart);
            Controls.Add(nupbrojDronova);
            Controls.Add(lblBrojDronova);
            Name = "FrmFormacija";
            Text = "FrmFormacija";
            ((System.ComponentModel.ISupportInitialize)nupbrojDronova).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStop;
        private Button btnGenerate;
        private Button btnStart;
        private NumericUpDown nupbrojDronova;
        private Label lblBrojDronova;
        private Label lblFormation;
        private Label label1;
    }
}