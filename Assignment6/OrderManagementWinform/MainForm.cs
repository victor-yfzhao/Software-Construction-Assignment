using Assignment5.Src;
using System.ComponentModel;

namespace OrderManagementWinform
{
    public partial class MainForm : Form
    {
        private OrderManagement management = OrderManagement.GetInstance();
        string[] detail = { "SU7", "Sun", "214999" };


        public MainForm()
        {
            InitializeComponent();
            //management.CreateOrder(detail);
            //management.CreateOrder(detail);
            // orders = new BindingList<Order>(management.orders);
            InitializeDataGridView();
            //OrderGridView.DataSource = orders;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm addForm = new AddForm(new PassDetail(detail => management.CreateOrder(detail)));
                addForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionMessage.Text = ex.Message;
            }
            OrderGridView.DataSource = null;
            OrderGridView.DataSource = management.orders;
        }

        private void OrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.ColumnCount = 4;
            //orders = new BindingList<Order>(management.orders);
            OrderGridView.DataSource = management.orders;
            //OrderGridView.DataMember = "detail.itemName";

            OrderGridView.Columns[0].Name = "Id";
            OrderGridView.Columns[0].HeaderText = "订单号";
            OrderGridView.Columns[0].DataPropertyName = "id";

            OrderGridView.Columns[1].Name = "ItemName";
            OrderGridView.Columns[1].HeaderText = "商品名称";
            OrderGridView.Columns[1].DataPropertyName = "ItemName";

            OrderGridView.Columns[2].Name = "CustomerName";
            OrderGridView.Columns[2].HeaderText = "顾客名称";
            OrderGridView.Columns[2].DataPropertyName = "CustomerName";

            OrderGridView.Columns[3].Name = "ItemValue";
            OrderGridView.Columns[3].HeaderText = "商品价格";
            OrderGridView.Columns[3].DataPropertyName = "ItemValue";
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            var deleteOrder = OrderGridView.CurrentRow.DataBoundItem as Order;
            management.DeleteOrder(deleteOrder.id);
            OrderGridView.DataSource = null;
            OrderGridView.DataSource = management.orders;
        }

        private void ModifyOrderButton_Click(object sender, EventArgs e)
        {
            var modifyOrder = OrderGridView.CurrentRow.DataBoundItem as Order;
            ModifyForm modifyForm = new ModifyForm(modifyOrder.id);
            modifyForm.ShowDialog();
            OrderGridView.DataSource = null;
            OrderGridView.DataSource = management.orders;
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.ShowDialog();
        }
    }
}