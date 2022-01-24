namespace POS_Software.Forms.Sales
{
    partial class frmCPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateSize = new System.Windows.Forms.Label();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.LblComment = new System.Windows.Forms.Label();
            this.TxtComments = new DevExpress.XtraEditors.TextEdit();
            this.lblCellNo = new System.Windows.Forms.Label();
            this.TxtGetRegularCustomer = new DevExpress.XtraEditors.TextEdit();
            this.btnGetRegularCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGetRegularCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblCreateSize);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 39);
            this.panel1.TabIndex = 16;
            // 
            // lblCreateSize
            // 
            this.lblCreateSize.AutoSize = true;
            this.lblCreateSize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateSize.ForeColor = System.Drawing.Color.White;
            this.lblCreateSize.Location = new System.Drawing.Point(16, 7);
            this.lblCreateSize.Name = "lblCreateSize";
            this.lblCreateSize.Size = new System.Drawing.Size(93, 23);
            this.lblCreateSize.TabIndex = 0;
            this.lblCreateSize.Text = "Payment";
            // 
            // BtnCancel
            // 
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(408, 73);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(339, 73);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.lblCustomerName);
            this.groupControl1.Controls.Add(this.LblComment);
            this.groupControl1.Controls.Add(this.TxtComments);
            this.groupControl1.Controls.Add(this.lblCellNo);
            this.groupControl1.Controls.Add(this.TxtGetRegularCustomer);
            this.groupControl1.Controls.Add(this.btnGetRegularCustomer);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.BtnCancel);
            this.groupControl1.Location = new System.Drawing.Point(-1, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(485, 100);
            this.groupControl1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(336, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "00";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(324, 33);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(56, 19);
            this.lblCustomerName.TabIndex = 96;
            this.lblCustomerName.Text = "Name";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComment.Location = new System.Drawing.Point(45, 60);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(64, 13);
            this.LblComment.TabIndex = 95;
            this.LblComment.Text = "Payment: ";
            // 
            // TxtComments
            // 
            this.TxtComments.Location = new System.Drawing.Point(130, 58);
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(132, 20);
            this.TxtComments.TabIndex = 94;
            this.TxtComments.Tag = "*";
            // 
            // lblCellNo
            // 
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNo.Location = new System.Drawing.Point(13, 36);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(96, 13);
            this.lblCellNo.TabIndex = 93;
            this.lblCellNo.Text = "Customer Code:";
            // 
            // TxtGetRegularCustomer
            // 
            this.TxtGetRegularCustomer.EnterMoveNextControl = true;
            this.TxtGetRegularCustomer.Location = new System.Drawing.Point(130, 30);
            this.TxtGetRegularCustomer.Name = "TxtGetRegularCustomer";
            this.TxtGetRegularCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGetRegularCustomer.Properties.Appearance.Options.UseFont = true;
            this.TxtGetRegularCustomer.Size = new System.Drawing.Size(132, 22);
            this.TxtGetRegularCustomer.TabIndex = 92;
            this.TxtGetRegularCustomer.Tag = "*";
            this.TxtGetRegularCustomer.Leave += new System.EventHandler(this.TxtGetRegularCustomer_Leave);
            // 
            // btnGetRegularCustomer
            // 
            this.btnGetRegularCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRegularCustomer.Appearance.Options.UseFont = true;
            this.btnGetRegularCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGetRegularCustomer.ImageOptions.Image")));
            this.btnGetRegularCustomer.Location = new System.Drawing.Point(268, 30);
            this.btnGetRegularCustomer.Name = "btnGetRegularCustomer";
            this.btnGetRegularCustomer.Size = new System.Drawing.Size(50, 22);
            this.btnGetRegularCustomer.TabIndex = 91;
            this.btnGetRegularCustomer.Text = "Find";
            this.btnGetRegularCustomer.Click += new System.EventHandler(this.btnGetRegularCustomer_Click);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmCPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 151);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCPayment";
            this.Text = "Customer Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGetRegularCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateSize;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label LblComment;
        private DevExpress.XtraEditors.TextEdit TxtComments;
        private System.Windows.Forms.Label lblCellNo;
        private DevExpress.XtraEditors.TextEdit TxtGetRegularCustomer;
        private DevExpress.XtraEditors.SimpleButton btnGetRegularCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
    }
}