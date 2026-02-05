namespace practice2
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
            this.set = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl1.Location = new System.Drawing.Point(262, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(399, 48);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "WELCOME TO FORMS";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.set.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.set.Location = new System.Drawing.Point(178, 295);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(136, 48);
            this.set.TabIndex = 1;
            this.set.Text = "SET";
            this.set.UseVisualStyleBackColor = false;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel.Location = new System.Drawing.Point(407, 294);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(136, 49);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Blue;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.logout.Location = new System.Drawing.Point(667, 294);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(136, 47);
            this.logout.TabIndex = 3;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl2.Location = new System.Drawing.Point(312, 142);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(312, 33);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "WE ARE LEARNING VP";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.set);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label lbl2;
    }
}

