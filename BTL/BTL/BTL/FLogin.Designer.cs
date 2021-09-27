namespace BTL
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMK
            // 
            this.txtMK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMK.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(133, 127);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(232, 37);
            this.txtMK.TabIndex = 0;
            this.txtMK.Text = "MẬT KHẨU";
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(133, 70);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(232, 37);
            this.txtTK.TabIndex = 1;
            this.txtTK.Text = "Tên tài khoản";
            this.txtTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btLogin.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Location = new System.Drawing.Point(-6, 190);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(523, 66);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "ĐỒNG Ý";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(518, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtMK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label1;
    }
}