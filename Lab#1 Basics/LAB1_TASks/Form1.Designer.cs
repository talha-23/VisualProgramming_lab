namespace LAB1_TASks
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
            tb1 = new TextBox();
            btn1 = new Button();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb1.Location = new Point(287, 154);
            tb1.Name = "tb1";
            tb1.Size = new Size(189, 39);
            tb1.TabIndex = 0;
            tb1.Tag = "Enter name";
            tb1.Text = "Enter Name";
            tb1.TextAlign = HorizontalAlignment.Center;
            tb1.TextChanged += tb1_TextChanged;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(0, 0, 192);
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ControlLightLight;
            btn1.Location = new Point(305, 245);
            btn1.Name = "btn1";
            btn1.Size = new Size(155, 43);
            btn1.TabIndex = 1;
            btn1.Text = "CLICK ME";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Black;
            lbl1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = SystemColors.ControlLightLight;
            lbl1.Location = new Point(314, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(129, 40);
            lbl1.TabIndex = 2;
            lbl1.Text = "TASK #1";
            lbl1.Click += lbl1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Controls.Add(btn1);
            Controls.Add(tb1);
            Name = "Form1";
            Text = "TASK#1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private Button btn1;
        private Label lbl1;
    }
}
