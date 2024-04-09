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
    public delegate void PassDetail(string[] _detail);

    public partial class AddForm : Form
    {
        private PassDetail passDetail;
        public AddForm(PassDetail passDetail)
        {
            InitializeComponent();
            this.passDetail = passDetail;
        }

        private void ConfirmAddButton_Click(object sender, EventArgs e)
        {
            string[] detail = new string[3];
            detail[0] = ItemNameBox.Text;
            detail[1] = CustomerNameBox.Text;
            detail[2] = ItemValueBox.Text;
            passDetail(detail);
            this.Close();
        }
    }
}
