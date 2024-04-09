namespace OrderManagementWinform
{
    partial class AddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ItemNameBox = new TextBox();
            CustomerNameBox = new TextBox();
            ItemValueBox = new TextBox();
            panel1 = new Panel();
            ConfirmAddButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "商品名称";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 46);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "客户名称";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 85);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "商品价格";
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(112, 6);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(125, 27);
            ItemNameBox.TabIndex = 3;
            // 
            // CustomerNameBox
            // 
            CustomerNameBox.Location = new Point(112, 46);
            CustomerNameBox.Name = "CustomerNameBox";
            CustomerNameBox.Size = new Size(125, 27);
            CustomerNameBox.TabIndex = 4;
            // 
            // ItemValueBox
            // 
            ItemValueBox.Location = new Point(112, 85);
            ItemValueBox.Name = "ItemValueBox";
            ItemValueBox.Size = new Size(125, 27);
            ItemValueBox.TabIndex = 5;
            ItemValueBox.Text = "0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(ItemNameBox);
            panel1.Controls.Add(ItemValueBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CustomerNameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(71, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 6;
            // 
            // ConfirmAddButton
            // 
            ConfirmAddButton.Location = new Point(302, 235);
            ConfirmAddButton.Name = "ConfirmAddButton";
            ConfirmAddButton.Size = new Size(94, 29);
            ConfirmAddButton.TabIndex = 7;
            ConfirmAddButton.Text = "确定";
            ConfirmAddButton.UseVisualStyleBackColor = true;
            ConfirmAddButton.Click += ConfirmAddButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(439, 290);
            Controls.Add(ConfirmAddButton);
            Controls.Add(panel1);
            Name = "AddForm";
            Text = "增加订单";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ItemNameBox;
        private TextBox CustomerNameBox;
        private TextBox ItemValueBox;
        private Panel panel1;
        private Button ConfirmAddButton;
    }
}