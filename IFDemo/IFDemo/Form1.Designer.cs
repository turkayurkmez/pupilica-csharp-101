namespace IFDemo
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
            components = new System.ComponentModel.Container();
            labelSlot1 = new Label();
            labelSlot2 = new Label();
            labelSlot3 = new Label();
            buttonBaslat = new Button();
            timerSlot = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelSlot1
            // 
            labelSlot1.BorderStyle = BorderStyle.FixedSingle;
            labelSlot1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelSlot1.Location = new Point(82, 90);
            labelSlot1.Name = "labelSlot1";
            labelSlot1.Size = new Size(204, 188);
            labelSlot1.TabIndex = 0;
            labelSlot1.Text = "0";
            labelSlot1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSlot2
            // 
            labelSlot2.BorderStyle = BorderStyle.FixedSingle;
            labelSlot2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelSlot2.Location = new Point(292, 90);
            labelSlot2.Name = "labelSlot2";
            labelSlot2.Size = new Size(204, 188);
            labelSlot2.TabIndex = 1;
            labelSlot2.Text = "0";
            labelSlot2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSlot3
            // 
            labelSlot3.BorderStyle = BorderStyle.FixedSingle;
            labelSlot3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelSlot3.Location = new Point(502, 90);
            labelSlot3.Name = "labelSlot3";
            labelSlot3.Size = new Size(204, 188);
            labelSlot3.TabIndex = 2;
            labelSlot3.Text = "0";
            labelSlot3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBaslat
            // 
            buttonBaslat.Location = new Point(292, 325);
            buttonBaslat.Name = "buttonBaslat";
            buttonBaslat.Size = new Size(184, 29);
            buttonBaslat.TabIndex = 3;
            buttonBaslat.Text = "Başlat";
            buttonBaslat.UseVisualStyleBackColor = true;
            buttonBaslat.Click += buttonBaslat_Click;
            // 
            // timerSlot
            // 
            timerSlot.Interval = 10;
            timerSlot.Tick += timerSlot_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBaslat);
            Controls.Add(labelSlot3);
            Controls.Add(labelSlot2);
            Controls.Add(labelSlot1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelSlot1;
        private Label labelSlot2;
        private Label labelSlot3;
        private Button buttonBaslat;
        private System.Windows.Forms.Timer timerSlot;
    }
}
