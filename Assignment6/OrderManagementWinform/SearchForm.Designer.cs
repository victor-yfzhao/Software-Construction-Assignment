namespace OrderManagementWinform
{
    partial class SearchForm
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
            SearchComboBox = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            SearchDetailBox = new TextBox();
            panel1 = new Panel();
            SearchButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchComboBox
            // 
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(131, 12);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(151, 28);
            SearchComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "查找数据类型";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 71);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 3;
            label3.Text = "值";
            // 
            // SearchDetailBox
            // 
            SearchDetailBox.Location = new Point(131, 71);
            SearchDetailBox.Name = "SearchDetailBox";
            SearchDetailBox.Size = new Size(151, 27);
            SearchDetailBox.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchDetailBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SearchComboBox);
            panel1.Location = new Point(58, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 121);
            panel1.TabIndex = 6;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(347, 250);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "查找";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 328);
            Controls.Add(SearchButton);
            Controls.Add(panel1);
            Name = "SearchForm";
            Text = "查找订单";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox SearchComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox OldDetailBox;
        private TextBox SearchDetailBox;
        private Panel panel1;
        private Button SearchButton;
    }
}