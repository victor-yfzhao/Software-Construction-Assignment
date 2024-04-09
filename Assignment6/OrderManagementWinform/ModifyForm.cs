using Assignment5.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWinform
{
    public partial class ModifyForm : Form
    {
        private OrderManagement management = OrderManagement.GetInstance();
        private Order modifyOrder;
        private DetailType detailType;

        public ModifyForm(int modifyId)
        {
            InitializeComponent();
            DetailComboBox.Items.Add("商品名称");
            DetailComboBox.Items.Add("顾客名称");
            DetailComboBox.Items.Add("商品价格");
            modifyOrder = management.SearchOrderById(modifyId);
        }

        private void DetailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            detailType = (DetailType)DetailComboBox.SelectedIndex;
            switch (DetailComboBox.SelectedIndex)
            {
                case 0:
                    OldDetailBox.Text = modifyOrder.ItemName; break;
                case 1:
                    OldDetailBox.Text = modifyOrder.CustomerName; break;
                case 2:
                    OldDetailBox.Text = "" + modifyOrder.ItemValue; break;
            }
        }

        private void ConfirmModifyButton_Click(object sender, EventArgs e)
        {
            management.ModifyOrder(modifyOrder, detailType, ModifiedDetailBox.Text);
            this.Close();
        }
    }
}
