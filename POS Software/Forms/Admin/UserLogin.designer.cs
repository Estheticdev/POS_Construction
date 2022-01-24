namespace POS_Software.Forms.Admin
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.TxtUSER_NAME = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUSER_NAME.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.BtnCancel);
            this.groupControl1.Controls.Add(this.BtnLogin);
            this.groupControl1.Controls.Add(this.TxtPASSWORD);
            this.groupControl1.Controls.Add(this.lblUsername);
            this.groupControl1.Controls.Add(this.lblPassword);
            this.groupControl1.Controls.Add(this.TxtUSER_NAME);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 146);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "User Login";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_Software.Properties.Resources.Userlogin1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(305, 111);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(61, 24);
            this.BtnCancel.TabIndex = 122;
            this.BtnCancel.Text = "Close";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Appearance.Options.UseFont = true;
            this.BtnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.ImageOptions.Image")));
            this.BtnLogin.Location = new System.Drawing.Point(236, 111);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(61, 24);
            this.BtnLogin.TabIndex = 121;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPASSWORD
            // 
            this.TxtPASSWORD.EnterMoveNextControl = true;
            this.TxtPASSWORD.Location = new System.Drawing.Point(183, 73);
            this.TxtPASSWORD.Name = "TxtPASSWORD";
            this.TxtPASSWORD.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TxtPASSWORD.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPASSWORD.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPASSWORD.Properties.Appearance.Options.UseFont = true;
            this.TxtPASSWORD.Properties.MaxLength = 15;
            this.TxtPASSWORD.Properties.PasswordChar = '*';
            this.TxtPASSWORD.Size = new System.Drawing.Size(183, 20);
            this.TxtPASSWORD.TabIndex = 118;
            this.TxtPASSWORD.Tag = "*";
            this.TxtPASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPASSWORD_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lblUsername.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Appearance.Options.UseBackColor = true;
            this.lblUsername.Appearance.Options.UseFont = true;
            this.lblUsername.Location = new System.Drawing.Point(113, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 14);
            this.lblUsername.TabIndex = 120;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Appearance.Options.UseBackColor = true;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(113, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 14);
            this.lblPassword.TabIndex = 119;
            this.lblPassword.Text = "Password:";
            // 
            // TxtUSER_NAME
            // 
            this.TxtUSER_NAME.EnterMoveNextControl = true;
            this.TxtUSER_NAME.Location = new System.Drawing.Point(183, 45);
            this.TxtUSER_NAME.Name = "TxtUSER_NAME";
            this.TxtUSER_NAME.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TxtUSER_NAME.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUSER_NAME.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUSER_NAME.Properties.Appearance.Options.UseFont = true;
            this.TxtUSER_NAME.Properties.MaxLength = 15;
            this.TxtUSER_NAME.Size = new System.Drawing.Size(183, 20);
            this.TxtUSER_NAME.TabIndex = 117;
            this.TxtUSER_NAME.Tag = "*";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 151);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("UserLogin.IconOptions.Icon")));
            this.Location = new System.Drawing.Point(430, 180);
            this.Name = "UserLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUSER_NAME.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtPASSWORD;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit TxtUSER_NAME;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}