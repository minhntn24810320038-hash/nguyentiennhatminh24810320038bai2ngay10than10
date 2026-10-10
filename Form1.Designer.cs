namespace hoccsharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblFinalTotalTitle = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 20);
            this.lblCategory.Text = "Loại dịch vụ:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(110, 17);
            this.cboCategory.Size = new System.Drawing.Size(200, 23);
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);

            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(20, 55);
            this.lblAvailable.Text = "Danh sách dịch vụ:";

            this.lstAvailableServices.Location = new System.Drawing.Point(20, 75);
            this.lstAvailableServices.Size = new System.Drawing.Size(220, 186);
            this.lstAvailableServices.DoubleClick += new System.EventHandler(this.lstAvailableServices_DoubleClick);

            this.btnSelect.Location = new System.Drawing.Point(255, 90);
            this.btnSelect.Size = new System.Drawing.Size(50, 30);
            this.btnSelect.Text = ">";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);

            this.btnRemove.Location = new System.Drawing.Point(255, 135);
            this.btnRemove.Size = new System.Drawing.Size(50, 30);
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            this.btnClearAll.Location = new System.Drawing.Point(255, 180);
            this.btnClearAll.Size = new System.Drawing.Size(50, 30);
            this.btnClearAll.Text = "<<";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);

            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(320, 55);
            this.lblSelected.Text = "Dịch vụ đã chọn:";

            this.lstSelectedServices.Location = new System.Drawing.Point(320, 75);
            this.lstSelectedServices.Size = new System.Drawing.Size(220, 186);

            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Location = new System.Drawing.Point(20, 280);
            this.lblTotalTitle.Text = "Tổng tiền chưa giảm:";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(160, 280);
            this.lblTotal.Text = "0 VNĐ";

            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Location = new System.Drawing.Point(20, 310);
            this.lblDiscountTitle.Text = "Chiết khấu (%):";

            this.txtDiscount.Location = new System.Drawing.Point(160, 307);
            this.txtDiscount.Size = new System.Drawing.Size(80, 23);
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);

            this.lblFinalTotalTitle.AutoSize = true;
            this.lblFinalTotalTitle.Location = new System.Drawing.Point(20, 340);
            this.lblFinalTotalTitle.Text = "Thành tiền thanh toán:";

            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotal.ForeColor = System.Drawing.Color.Red;
            this.lblFinalTotal.Location = new System.Drawing.Point(160, 340);
            this.lblFinalTotal.Text = "0 VNĐ";

            this.ClientSize = new System.Drawing.Size(565, 385);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.lblTotalTitle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountTitle);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblFinalTotalTitle);
            this.Controls.Add(this.lblFinalTotal);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Tính Tiền Dịch Vụ Và Chiết Khấu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblFinalTotalTitle;
        private System.Windows.Forms.Label lblFinalTotal;
    }
}