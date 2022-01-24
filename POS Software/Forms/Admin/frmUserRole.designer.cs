namespace POS_Software.Forms.Admin
{
    partial class frmUserRole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRole));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.TxtUser_Role_ID = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUser_Role_Name = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser_Role_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser_Role_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 39);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(158, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Create User Role";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 43);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(482, 135);
            this.xtraTabControl1.TabIndex = 46;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.TxtUser_Role_ID);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.TxtUser_Role_Name);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(476, 107);
            this.xtraTabPage1.Text = "Add Role Type";
            // 
            // TxtUser_Role_ID
            // 
            this.TxtUser_Role_ID.Location = new System.Drawing.Point(188, 32);
            this.TxtUser_Role_ID.Name = "TxtUser_Role_ID";
            this.TxtUser_Role_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtUser_Role_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID:";
            // 
            // TxtUser_Role_Name
            // 
            this.TxtUser_Role_Name.Location = new System.Drawing.Point(188, 57);
            this.TxtUser_Role_Name.Name = "TxtUser_Role_Name";
            this.TxtUser_Role_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtUser_Role_Name.TabIndex = 7;
            this.TxtUser_Role_Name.Tag = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "User Name:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(401, 181);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 52;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(324, 181);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 51;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(170, 181);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 49;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(16, 181);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 22);
            this.BtnNew.TabIndex = 47;
            this.BtnNew.TabStop = false;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(93, 181);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 48;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(247, 181);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 22);
            this.BtnSearch.TabIndex = 50;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 210);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Role";
            this.Load += new System.EventHandler(this.frmUserRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser_Role_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser_Role_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit TxtUser_Role_ID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtUser_Role_Name;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
    }
}