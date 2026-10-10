using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hoccsharp
{
    public partial class Form1 : Form
    {
        private List<ServiceItem> allServices = new List<ServiceItem>();

        public Form1()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            allServices = new List<ServiceItem>
            {
                new ServiceItem("Khám tổng quát", 150000, "Khám bệnh"),
                new ServiceItem("Khám chuyên khoa", 250000, "Khám bệnh"),
                new ServiceItem("Xét nghiệm máu", 200000, "Xét nghiệm"),
                new ServiceItem("Xét nghiệm nước tiểu", 100000, "Xét nghiệm"),
                new ServiceItem("Chụp X-Quang Phổi", 300000, "Chụp X-Quang"),
                new ServiceItem("Chụp X-Quang Cột sống", 350000, "Chụp X-Quang"),
                new ServiceItem("Vắc-xin Cúm", 350000, "Vắc-xin"),
                new ServiceItem("Vắc-xin Viêm gan B", 250000, "Vắc-xin")
            };

            cboCategory.Items.AddRange(new string[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem == null) return;
            string selectedCategory = cboCategory.SelectedItem.ToString() ?? "";
            lstAvailableServices.Items.Clear();

            foreach (var service in allServices)
            {
                if (service.Category == selectedCategory)
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(lstAvailableServices.SelectedItem);
                CalculateTotal();
            }
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(lstAvailableServices.SelectedItem);
                CalculateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                CalculateTotal();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CalculateTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in lstSelectedServices.Items)
            {
                if (item is ServiceItem service)
                {
                    total += service.Price;
                }
            }

            decimal discountPercent = 0;
            decimal.TryParse(txtDiscount.Text, out discountPercent);

            decimal discountAmount = total * (discountPercent / 100);
            decimal finalTotal = total - discountAmount;

            lblTotal.Text = total.ToString("N0") + " VNĐ";
            lblFinalTotal.Text = finalTotal.ToString("N0") + " VNĐ";
        }
    }

    public class ServiceItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public ServiceItem(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:N0} VNĐ";
        }
    }
}