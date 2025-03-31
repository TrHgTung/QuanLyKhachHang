namespace QuanLyKhachHang
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.CheckBox chkIsCustomer;
        private System.Windows.Forms.CheckBox chkIsVendor;
        private System.Windows.Forms.CheckBox chkIsPersonal;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtDebtLimit;
        private System.Windows.Forms.TextBox txtNumberDayLimit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.chkIsCustomer = new System.Windows.Forms.CheckBox();
            this.chkIsVendor = new System.Windows.Forms.CheckBox();
            this.chkIsPersonal = new System.Windows.Forms.CheckBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtDebtLimit = new System.Windows.Forms.TextBox();
            this.txtNumberDayLimit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            // Form Settings
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.chkIsCustomer);
            this.Controls.Add(this.chkIsVendor);
            this.Controls.Add(this.chkIsPersonal);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.txtDebtLimit);
            this.Controls.Add(this.txtNumberDayLimit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "Quản lý Khách hàng";

            // Control Positions
            int xLabel = 20, xInput = 150, yStart = 20, yOffset = 35;
            int inputWidth = 200, labelWidth = 120;

            AddControl("Mã KH:", this.txtCustomerID, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Tên KH:", this.txtCustomerName, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Mã số thuế:", this.txtTaxCode, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddCheckBox("Khách hàng", this.chkIsCustomer, xLabel, ref yStart, yOffset);
            AddCheckBox("Nhà cung cấp", this.chkIsVendor, xLabel, ref yStart, yOffset);
            AddCheckBox("Cá nhân", this.chkIsPersonal, xLabel, ref yStart, yOffset);
            AddControl("Điện thoại:", this.txtMobile, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Email:", this.txtEmail, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Địa chỉ:", this.txtAddress, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Người liên hệ:", this.txtContactPerson, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Hạn mức nợ:", this.txtDebtLimit, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);
            AddControl("Số ngày nợ:", this.txtNumberDayLimit, xLabel, xInput, ref yStart, yOffset, inputWidth, labelWidth);

            // Buttons
            btnAdd.Text = "Thêm";
            btnUpdate.Text = "Sửa";
            btnDelete.Text = "Xóa";
            btnAdd.Location = new System.Drawing.Point(xLabel, yStart + 20);
            btnUpdate.Location = new System.Drawing.Point(xLabel + 100, yStart + 20);
            btnDelete.Location = new System.Drawing.Point(xLabel + 200, yStart + 20);

            this.ResumeLayout(false);
        }

        private void AddControl(string label, TextBox textBox, int xLabel, int xInput, ref int y, int yOffset, int inputWidth, int labelWidth)
        {
            Label lbl = new Label();
            lbl.Text = label;
            lbl.Location = new System.Drawing.Point(xLabel, y);
            lbl.Width = labelWidth;
            textBox.Location = new System.Drawing.Point(xInput, y);
            textBox.Width = inputWidth;
            this.Controls.Add(lbl);
            this.Controls.Add(textBox);
            y += yOffset;
        }

        private void AddCheckBox(string label, CheckBox checkBox, int xLabel, ref int y, int yOffset)
        {
            checkBox.Text = label;
            checkBox.Location = new System.Drawing.Point(xLabel, y);
            this.Controls.Add(checkBox);
            y += yOffset;
        }

        #endregion

        
    }
}
