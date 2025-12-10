namespace basitTakvim
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
            comboBoxGun = new ComboBox();
            comboBoxAy = new ComboBox();
            comboBoxYil = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxGun
            // 
            comboBoxGun.FormattingEnabled = true;
            comboBoxGun.Location = new Point(133, 82);
            comboBoxGun.Name = "comboBoxGun";
            comboBoxGun.Size = new Size(151, 28);
            comboBoxGun.TabIndex = 0;
            // 
            // comboBoxAy
            // 
            comboBoxAy.FormattingEnabled = true;
            comboBoxAy.Location = new Point(290, 82);
            comboBoxAy.Name = "comboBoxAy";
            comboBoxAy.Size = new Size(151, 28);
            comboBoxAy.TabIndex = 1;
            // 
            // comboBoxYil
            // 
            comboBoxYil.FormattingEnabled = true;
            comboBoxYil.Location = new Point(447, 82);
            comboBoxYil.Name = "comboBoxYil";
            comboBoxYil.Size = new Size(151, 28);
            comboBoxYil.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxYil);
            Controls.Add(comboBoxAy);
            Controls.Add(comboBoxGun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxGun;
        private ComboBox comboBoxAy;
        private ComboBox comboBoxYil;
    }
}
