namespace OrderManagementWinform
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrderGridView = new DataGridView();
            AddOrderButton = new Button();
            ModifyOrderButton = new Button();
            SearchOrderButton = new Button();
            DeleteOrderButton = new Button();
            ExceptionMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderGridView
            // 
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(30, 55);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.RowTemplate.Height = 29;
            OrderGridView.Size = new Size(553, 434);
            OrderGridView.TabIndex = 0;
            OrderGridView.CellContentClick += OrderGridView_CellContentClick;
            // 
            // AddOrderButton
            // 
            AddOrderButton.Location = new Point(752, 299);
            AddOrderButton.Name = "AddOrderButton";
            AddOrderButton.Size = new Size(94, 29);
            AddOrderButton.TabIndex = 1;
            AddOrderButton.Text = "添加订单";
            AddOrderButton.UseVisualStyleBackColor = true;
            AddOrderButton.Click += AddOrderButton_Click;
            // 
            // ModifyOrderButton
            // 
            ModifyOrderButton.Location = new Point(752, 334);
            ModifyOrderButton.Name = "ModifyOrderButton";
            ModifyOrderButton.Size = new Size(94, 29);
            ModifyOrderButton.TabIndex = 2;
            ModifyOrderButton.Text = "修改订单";
            ModifyOrderButton.UseVisualStyleBackColor = true;
            ModifyOrderButton.Click += ModifyOrderButton_Click;
            // 
            // SearchOrderButton
            // 
            SearchOrderButton.Location = new Point(752, 369);
            SearchOrderButton.Name = "SearchOrderButton";
            SearchOrderButton.Size = new Size(94, 29);
            SearchOrderButton.TabIndex = 3;
            SearchOrderButton.Text = "查找订单";
            SearchOrderButton.UseVisualStyleBackColor = true;
            SearchOrderButton.Click += SearchOrderButton_Click;
            // 
            // DeleteOrderButton
            // 
            DeleteOrderButton.Location = new Point(752, 404);
            DeleteOrderButton.Name = "DeleteOrderButton";
            DeleteOrderButton.Size = new Size(94, 29);
            DeleteOrderButton.TabIndex = 4;
            DeleteOrderButton.Text = "删除订单";
            DeleteOrderButton.UseVisualStyleBackColor = true;
            DeleteOrderButton.Click += DeleteOrderButton_Click;
            // 
            // ExceptionMessage
            // 
            ExceptionMessage.AutoSize = true;
            ExceptionMessage.Location = new Point(48, 502);
            ExceptionMessage.Name = "ExceptionMessage";
            ExceptionMessage.Size = new Size(0, 20);
            ExceptionMessage.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 582);
            Controls.Add(ExceptionMessage);
            Controls.Add(DeleteOrderButton);
            Controls.Add(SearchOrderButton);
            Controls.Add(ModifyOrderButton);
            Controls.Add(AddOrderButton);
            Controls.Add(OrderGridView);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "订单管理";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView OrderGridView;
        private Button AddOrderButton;
        private Button ModifyOrderButton;
        private Button SearchOrderButton;
        private Button DeleteOrderButton;
        private Label ExceptionMessage;
    }
}