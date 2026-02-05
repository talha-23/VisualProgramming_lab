namespace TASK2
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.TextBox();
            this.passcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Black;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1.Location = new System.Drawing.Point(311, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(153, 37);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "TASK #5";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(243, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "LOG IN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uname
            // 
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(318, 147);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(146, 35);
            this.uname.TabIndex = 10;
            this.uname.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // passcode
            // 
            this.passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcode.Location = new System.Drawing.Point(318, 226);
            this.passcode.Name = "passcode";
            this.passcode.Size = new System.Drawing.Size(146, 35);
            this.passcode.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.passcode);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "TASK #5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox passcode;
    }
}

