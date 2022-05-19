namespace ProyectTryAll
{
    partial class Main
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
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.Teal;
            this.PanelLogin.Controls.Add(this.button2);
            this.PanelLogin.Controls.Add(this.button1);
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Location = new System.Drawing.Point(98, 164);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(490, 353);
            this.PanelLogin.TabIndex = 5;
            this.PanelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogin_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(76, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 65);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Cerrar ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.LabelLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelLogin.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(129, 33);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(232, 32);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Prueba de sesion ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(76, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 65);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "Iniciar sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(778, 749);
            this.ControlBox = false;
            this.Controls.Add(this.PanelLogin);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

