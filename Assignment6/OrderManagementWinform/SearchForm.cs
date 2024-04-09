using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5.Src;

namespace OrderManagementWinform
{
    
    public partial class SearchForm : Form
    {
        private MainForm mainForm;
        private OrderManagement management = OrderManagement.GetInstance();
        
        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();
            SearchComboBox.Items.Add("商品名称");
            SearchComboBox.Items.Add("顾客名称");
            SearchComboBox.Items.Add("商品价格");
            SearchComboBox.Items.Add("订单号");
            this.mainForm = mainForm;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Order> searchOrders = new List<Order>();
            if (SearchComboBox.SelectedIndex == -1)
            {
                mainForm.OrderGridView.DataSource = null;
                mainForm.OrderGridView.DataSource = management.orders;
                this.Close();
                return;
            }
            switch (SearchComboBox.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                    Order[] _searchOrders = (management.SearchOrderByDetail((DetailType)SearchComboBox.SelectedIndex,
                                                                  SearchDetailBox.Text));
                    searchOrders.AddRange(_searchOrders);
                    break;
                case 3:
                    searchOrders.Add(management.SearchOrderById(Convert.ToInt32(SearchDetailBox.Text)));
                    break;
            }
            mainForm.OrderGridView.DataSource = null;
            mainForm.OrderGridView.DataSource = searchOrders;
            this.Close();
        }
    }
}
