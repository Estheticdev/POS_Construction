namespace POS_Software.Forms.Admin
{
    partial class frmCustomerDeffination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDeffination));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.TxtTaxNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxNumber = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.LuECustomerType_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.TxtCustomer_Name = new DevExpress.XtraEditors.TextEdit();
            this.TxtCustomer_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.TxtContact_Number = new DevExpress.XtraEditors.TextEdit();
            this.TxtBalance = new DevExpress.XtraEditors.TextEdit();
            this.TxtLocation = new DevExpress.XtraEditors.TextEdit();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegularCustomer = new System.Windows.Forms.Label();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuECustomerType_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCustomer_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCustomer_ID.Properties)).BeginInit();
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
            this.xtraTabControl1.SelectedTabPage = this.tabCustomer;
            this.xtraTabControl1.Size = new System.Drawing.Size(480, 261);
            this.xtraTabControl1.TabIndex = 47;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCustomer});
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.TxtTaxNumber);
            this.tabCustomer.Controls.Add(this.lblTaxNumber);
            this.tabCustomer.Controls.Add(this.lblCustomerType);
            this.tabCustomer.Controls.Add(this.LuECustomerType_ID);
            this.tabCustomer.Controls.Add(this.CkEActive);
            this.tabCustomer.Controls.Add(this.TxtCustomer_Name);
            this.tabCustomer.Controls.Add(this.TxtCustomer_ID);
            this.tabCustomer.Controls.Add(this.lblCustomerId);
            this.tabCustomer.Controls.Add(this.lblCustomerName);
            this.tabCustomer.Controls.Add(this.TxtContact_Number);
            this.tabCustomer.Controls.Add(this.TxtBalance);
            this.tabCustomer.Controls.Add(this.TxtLocation);
            this.tabCustomer.Controls.Add(this.lblBalance);
            this.tabCustomer.Controls.Add(this.lblContactNumber);
            this.tabCustomer.Controls.Add(this.lblLocation);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(478, 236);
            this.tabCustomer.Text = "Add Customer";
            // 
            // TxtTaxNumber
            // 
            this.TxtTaxNumber.Location = new System.Drawing.Point(189, 146);
            this.TxtTaxNumber.Name = "TxtTaxNumber";
            this.TxtTaxNumber.Size = new System.Drawing.Size(145, 20);
            this.TxtTaxNumber.TabIndex = 5;
            this.TxtTaxNumber.Tag = "*";
            // 
            // lblTaxNumber
            // 
            this.lblTaxNumber.AutoSize = true;
            this.lblTaxNumber.Location = new System.Drawing.Point(118, 149);
            this.lblTaxNumber.Name = "lblTaxNumber";
            this.lblTaxNumber.Size = new System.Drawing.Size(70, 13);
            this.lblTaxNumber.TabIndex = 107;
            this.lblTaxNumber.Text = "VAT Number:";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(103, 44);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(84, 13);
            this.lblCustomerType.TabIndex = 105;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // LuECustomerType_ID
            // 
            this.LuECustomerType_ID.Location = new System.Drawing.Point(189, 41);
            this.LuECustomerType_ID.Name = "LuECustomerType_ID";
            this.LuECustomerType_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuECustomerType_ID.Properties.Appearance.Options.UseFont = true;
            this.LuECustomerType_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuECustomerType_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer_Name", "Customer_Name")});
            this.LuECustomerType_ID.Properties.NullText = "";
            this.LuECustomerType_ID.Properties.PopupFormMinSize = new System.Drawing.Size(50, 50);
            this.LuECustomerType_ID.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize;
            this.LuECustomerType_ID.Properties.PopupSizeable = false;
            this.LuECustomerType_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuECustomerType_ID.Properties.ShowFooter = false;
            this.LuECustomerType_ID.Size = new System.Drawing.Size(145, 20);
            this.LuECustomerType_ID.TabIndex = 1;
            this.LuECustomerType_ID.TabStop = false;
            // 
            // CkEActive
            // 
            this.CkEActive.Location = new System.Drawing.Point(187, 198);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 6;
            // 
            // TxtCustomer_Name
            // 
            this.TxtCustomer_Name.Location = new System.Drawing.Point(189, 67);
            this.TxtCustomer_Name.Name = "TxtCustomer_Name";
            this.TxtCustomer_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtCustomer_Name.TabIndex = 2;
            this.TxtCustomer_Name.Tag = "*";
            // 
            // TxtCustomer_ID
            // 
            this.TxtCustomer_ID.Location = new System.Drawing.Point(189, 15);
            this.TxtCustomer_ID.Name = "TxtCustomer_ID";
            this.TxtCustomer_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtCustomer_ID.TabIndex = 0;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(116, 18);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(71, 13);
            this.lblCustomerId.TabIndex = 3;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(100, 70);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(87, 13);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // TxtContact_Number
            // 
            this.TxtContact_Number.Location = new System.Drawing.Point(189, 93);
            this.TxtContact_Number.Name = "TxtContact_Number";
            this.TxtContact_Number.Size = new System.Drawing.Size(145, 20);
            this.TxtContact_Number.TabIndex = 3;
            this.TxtContact_Number.Tag = "*";
            // 
            // TxtBalance
            // 
            this.TxtBalance.EditValue = "0";
            this.TxtBalance.Location = new System.Drawing.Point(189, 173);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(145, 20);
            this.TxtBalance.TabIndex = 4;
            this.TxtBalance.Tag = "*";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(189, 119);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(145, 20);
            this.TxtLocation.TabIndex = 4;
            this.TxtLocation.Tag = "";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(139, 176);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(48, 13);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Balance:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(98, 96);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(89, 13);
            this.lblContactNumber.TabIndex = 9;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(136, 122);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblRegularCustomer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 39);
            this.panel1.TabIndex = 46;
            // 
            // lblRegularCustomer
            // 
            this.lblRegularCustomer.AutoSize = true;
            this.lblRegularCustomer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularCustomer.ForeColor = System.Drawing.Color.White;
            this.lblRegularCustomer.Location = new System.Drawing.Point(158, 8);
            this.lblRegularCustomer.Name = "lblRegularCustomer";
            this.lblRegularCustomer.Size = new System.Drawing.Size(182, 23);
            this.lblRegularCustomer.TabIndex = 0;
            this.lblRegularCustomer.Text = "Regular Customer";
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
            // frmCustomerDeffination
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
            this.Name = "frmCustomerDeffination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Definition";
            this.Load += new System.EventHandler(this.frmCustomerDeffination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuECustomerType_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCustomer_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCustomer_ID.Properties)).EndInit();
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
        private DevExpress.XtraTab.XtraTabPage tabCustomer;
        private DevExpress.XtraEditors.TextEdit TxtCustomer_Name;
        private DevExpress.XtraEditors.TextEdit TxtCustomer_ID;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private DevExpress.XtraEditors.TextEdit TxtContact_Number;
        private DevExpress.XtraEditors.TextEdit TxtLocation;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegularCustomer;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.CheckEdit CkEActive;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.LookUpEdit LuECustomerType_ID;
        private System.Windows.Forms.Label lblCustomerType;
        private DevExpress.XtraEditors.TextEdit TxtBalance;
        private System.Windows.Forms.Label lblBalance;
        private DevExpress.XtraEditors.TextEdit TxtTaxNumber;
        private System.Windows.Forms.Label lblTaxNumber;
    }
}