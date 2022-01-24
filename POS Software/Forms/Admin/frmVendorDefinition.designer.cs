namespace POS_Software.Forms.Admin
{
    partial class frmVendorDefinition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendorDefinition));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabVendor = new DevExpress.XtraTab.XtraTabPage();
            this.TxtTaxNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxNumber = new System.Windows.Forms.Label();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.TxtVendor_Name = new DevExpress.XtraEditors.TextEdit();
            this.TxtVendor_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.TxtContact_Number = new DevExpress.XtraEditors.TextEdit();
            this.TxtBalance = new DevExpress.XtraEditors.TextEdit();
            this.TxtLocation = new DevExpress.XtraEditors.TextEdit();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegularVendor = new System.Windows.Forms.Label();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVendor_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVendor_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContact_Number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLocation.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabVendor;
            this.xtraTabControl1.Size = new System.Drawing.Size(480, 261);
            this.xtraTabControl1.TabIndex = 47;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabVendor});
            // 
            // tabVendor
            // 
            this.tabVendor.Controls.Add(this.TxtTaxNumber);
            this.tabVendor.Controls.Add(this.lblTaxNumber);
            this.tabVendor.Controls.Add(this.CkEActive);
            this.tabVendor.Controls.Add(this.TxtVendor_Name);
            this.tabVendor.Controls.Add(this.TxtVendor_ID);
            this.tabVendor.Controls.Add(this.lblVendorID);
            this.tabVendor.Controls.Add(this.lblVendorName);
            this.tabVendor.Controls.Add(this.TxtContact_Number);
            this.tabVendor.Controls.Add(this.TxtBalance);
            this.tabVendor.Controls.Add(this.TxtLocation);
            this.tabVendor.Controls.Add(this.lblBalance);
            this.tabVendor.Controls.Add(this.lblContactNumber);
            this.tabVendor.Controls.Add(this.lblLocation);
            this.tabVendor.Name = "tabVendor";
            this.tabVendor.Size = new System.Drawing.Size(478, 236);
            this.tabVendor.Text = "Add Vendor";
            // 
            // TxtTaxNumber
            // 
            this.TxtTaxNumber.Location = new System.Drawing.Point(189, 137);
            this.TxtTaxNumber.Name = "TxtTaxNumber";
            this.TxtTaxNumber.Size = new System.Drawing.Size(145, 20);
            this.TxtTaxNumber.TabIndex = 5;
            this.TxtTaxNumber.Tag = "*";
            // 
            // lblTaxNumber
            // 
            this.lblTaxNumber.AutoSize = true;
            this.lblTaxNumber.Location = new System.Drawing.Point(118, 140);
            this.lblTaxNumber.Name = "lblTaxNumber";
            this.lblTaxNumber.Size = new System.Drawing.Size(70, 13);
            this.lblTaxNumber.TabIndex = 107;
            this.lblTaxNumber.Text = "VAT Number:";
            // 
            // CkEActive
            // 
            this.CkEActive.Location = new System.Drawing.Point(187, 189);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 6;
            // 
            // TxtVendor_Name
            // 
            this.TxtVendor_Name.Location = new System.Drawing.Point(189, 58);
            this.TxtVendor_Name.Name = "TxtVendor_Name";
            this.TxtVendor_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtVendor_Name.TabIndex = 2;
            this.TxtVendor_Name.Tag = "*";
            // 
            // TxtVendor_ID
            // 
            this.TxtVendor_ID.Location = new System.Drawing.Point(189, 32);
            this.TxtVendor_ID.Name = "TxtVendor_ID";
            this.TxtVendor_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtVendor_ID.TabIndex = 0;
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(128, 35);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(59, 13);
            this.lblVendorID.TabIndex = 3;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(112, 61);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblVendorName.TabIndex = 5;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // TxtContact_Number
            // 
            this.TxtContact_Number.Location = new System.Drawing.Point(189, 84);
            this.TxtContact_Number.Name = "TxtContact_Number";
            this.TxtContact_Number.Size = new System.Drawing.Size(145, 20);
            this.TxtContact_Number.TabIndex = 3;
            this.TxtContact_Number.Tag = "*";
            // 
            // TxtBalance
            // 
            this.TxtBalance.EditValue = "0";
            this.TxtBalance.Location = new System.Drawing.Point(189, 164);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(145, 20);
            this.TxtBalance.TabIndex = 6;
            this.TxtBalance.Tag = "*";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(189, 110);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(145, 20);
            this.TxtLocation.TabIndex = 4;
            this.TxtLocation.Tag = "";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(139, 167);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(48, 13);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Balance:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(98, 87);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(89, 13);
            this.lblContactNumber.TabIndex = 9;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(136, 113);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblRegularVendor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 39);
            this.panel1.TabIndex = 46;
            // 
            // lblRegularVendor
            // 
            this.lblRegularVendor.AutoSize = true;
            this.lblRegularVendor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularVendor.ForeColor = System.Drawing.Color.White;
            this.lblRegularVendor.Location = new System.Drawing.Point(158, 8);
            this.lblRegularVendor.Name = "lblRegularVendor";
            this.lblRegularVendor.Size = new System.Drawing.Size(158, 23);
            this.lblRegularVendor.TabIndex = 0;
            this.lblRegularVendor.Text = "Regular Vendor";
            // 
            // BtnCancel
            // 
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(404, 307);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 53;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(327, 307);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 52;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(173, 307);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 50;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(250, 307);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 22);
            this.BtnSearch.TabIndex = 51;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(96, 307);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 49;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.Location = new System.Drawing.Point(19, 307);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 22);
            this.BtnNew.TabIndex = 48;
            this.BtnNew.TabStop = false;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmVendorDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 335);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmVendorDefinition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Definition";
            this.Load += new System.EventHandler(this.frmCustomerDeffination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabVendor.ResumeLayout(false);
            this.tabVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVendor_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVendor_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContact_Number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLocation.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabVendor;
        private DevExpress.XtraEditors.TextEdit TxtVendor_Name;
        private DevExpress.XtraEditors.TextEdit TxtVendor_ID;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorName;
        private DevExpress.XtraEditors.TextEdit TxtContact_Number;
        private DevExpress.XtraEditors.TextEdit TxtLocation;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegularVendor;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.CheckEdit CkEActive;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.TextEdit TxtBalance;
        private System.Windows.Forms.Label lblBalance;
        private DevExpress.XtraEditors.TextEdit TxtTaxNumber;
        private System.Windows.Forms.Label lblTaxNumber;
    }
}