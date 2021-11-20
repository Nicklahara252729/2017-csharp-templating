namespace Template
{
    partial class home
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.White;
            this.pnl_menu.Controls.Add(this.label1);
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(61, 603);
            this.pnl_menu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(62, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 46);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "UK";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_menu);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

