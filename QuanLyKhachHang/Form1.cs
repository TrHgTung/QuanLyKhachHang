using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using QuanLyKhachHang.Data;


namespace QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
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

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
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

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Size = new System.Drawing.Size(760, 200);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // Labels & TextBoxes
            int startX = 12, startY = 20, spacing = 30;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                CreateLabel("Customer ID", startX, startY), txtCustomerID,
                CreateLabel("Customer Name", startX, startY + spacing), txtCustomerName,
                CreateLabel("Tax Code", startX, startY + spacing * 2), txtTaxCode,
                CreateLabel("Mobile", startX, startY + spacing * 3), txtMobile,
                CreateLabel("Email", startX, startY + spacing * 4), txtEmail,
                CreateLabel("Address", startX, startY + spacing * 5), txtAddress,
                CreateLabel("Contact Person", startX, startY + spacing * 6), txtContactPerson,
                CreateLabel("Debt Limit", startX, startY + spacing * 7), txtDebtLimit,
                CreateLabel("Number Day Limit", startX, startY + spacing * 8), txtNumberDayLimit
            });

            // CheckBoxes
            this.chkIsCustomer.Location = new System.Drawing.Point(350, startY);
            this.chkIsCustomer.Text = "Is Customer";

            this.chkIsVendor.Location = new System.Drawing.Point(350, startY + spacing);
            this.chkIsVendor.Text = "Is Vendor";

            this.chkIsPersonal.Location = new System.Drawing.Point(350, startY + spacing * 2);
            this.chkIsPersonal.Text = "Is Personal";

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                chkIsCustomer, chkIsVendor, chkIsPersonal
            });

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(500, startY);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(500, startY + spacing);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(500, startY + spacing * 2);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnLoad.Text = "Load";
            this.btnLoad.Location = new System.Drawing.Point(500, startY + spacing * 3);
            this.btnLoad.Click += new System.EventHandler(this.Form1_Load);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                btnAdd, btnUpdate, btnDelete, btnLoad
            });

            // Form Settings
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dataGridView1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Text = "Customer Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label CreateLabel(string text, int x, int y)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = text;
            label.Location = new System.Drawing.Point(x, y);
            label.AutoSize = true;
            return label;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM SL_tblCustomerList";
            dataGridView1.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = $@"
        INSERT INTO SL_tblCustomerList (CustomerID, CustomerName, TaxCode, IsCustomer, IsVendor, IsPersonal, 
                                        Mobile, Email, Address, ContactPerson, DebtLimit, NumberDayLimit)
        VALUES ('{txtCustomerID.Text}', N'{txtCustomerName.Text}', '{txtTaxCode.Text}', 
                '{(chkIsCustomer.Checked ? 1 : 0)}', '{(chkIsVendor.Checked ? 1 : 0)}', '{(chkIsPersonal.Checked ? 1 : 0)}',
                '{txtMobile.Text}', '{txtEmail.Text}', N'{txtAddress.Text}', '{txtContactPerson.Text}', 
                {txtDebtLimit.Text}, {txtNumberDayLimit.Text})";

            DatabaseHelper.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $@"
        UPDATE SL_tblCustomerList
        SET CustomerName = N'{txtCustomerName.Text}', TaxCode = '{txtTaxCode.Text}', 
            IsCustomer = '{(chkIsCustomer.Checked ? 1 : 0)}', 
            IsVendor = '{(chkIsVendor.Checked ? 1 : 0)}', 
            IsPersonal = '{(chkIsPersonal.Checked ? 1 : 0)}', 
            Mobile = '{txtMobile.Text}', Email = '{txtEmail.Text}', 
            Address = N'{txtAddress.Text}', ContactPerson = '{txtContactPerson.Text}', 
            DebtLimit = {txtDebtLimit.Text}, NumberDayLimit = {txtNumberDayLimit.Text}
        WHERE CustomerID = '{txtCustomerID.Text}'";

            DatabaseHelper.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM SL_tblCustomerList WHERE CustomerID = '{txtCustomerID.Text}'";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtTaxCode.Text = row.Cells["TaxCode"].Value.ToString();
                chkIsCustomer.Checked = (bool)row.Cells["IsCustomer"].Value;
                chkIsVendor.Checked = (bool)row.Cells["IsVendor"].Value;
                chkIsPersonal.Checked = (bool)row.Cells["IsPersonal"].Value;
                txtMobile.Text = row.Cells["Mobile"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContactPerson.Text = row.Cells["ContactPerson"].Value.ToString();
                txtDebtLimit.Text = row.Cells["DebtLimit"].Value.ToString();
                txtNumberDayLimit.Text = row.Cells["NumberDayLimit"].Value.ToString();
            }
        }


    }
}
