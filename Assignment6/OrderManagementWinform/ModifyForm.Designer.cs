namespace OrderManagementWinform
{
    partial class ModifyForm
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
            panel1 = new Panel();
            ModifiedDetailBox = new TextBox();
            OldDetailBox = new TextBox();
            DetailComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ConfirmModifyButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ModifiedDetailBox);
            panel1.Controls.Add(OldDetailBox);
            panel1.Controls.Add(DetailComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(75, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 143);
            panel1.TabIndex = 0;
            // 
            // ModifiedDetailBox
            // 
            ModifiedDetailBox.Location = new Point(135, 99);
            ModifiedDetailBox.Name = "ModifiedDetailBox";
            ModifiedDetailBox.Size = new Size(151, 27);
            ModifiedDetailBox.TabIndex = 5;
            // 
            // OldDetailBox
            // 
            OldDetailBox.Location = new Point(135, 60);
            OldDetailBox.Name = "OldDetailBox";
            OldDetailBox.ReadOnly = true;
            OldDetailBox.Size = new Size(151, 27);
            OldDetailBox.TabIndex = 4;
            // 
            // DetailComboBox
            // 
            DetailComboBox.FormattingEnabled = true;
            DetailComboBox.Location = new Point(135, 20);
            DetailComboBox.Name = "DetailComboBox";
            DetailComboBox.Size = new Size(151, 28);
            DetailComboBox.TabIndex = 3;
            DetailComboBox.SelectedIndexChanged += DetailComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 99);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "修改后";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "修改前";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "修改数据类型";
            // 
            // ConfirmModifyButton
            // 
            ConfirmModifyButton.Location = new Point(352, 254);
            ConfirmModifyButton.Name = "ConfirmModifyButton";
            ConfirmModifyButton.Size = new Size(94, 29);
            ConfirmModifyButton.TabIndex = 1;
            ConfirmModifyButton.Text = "确认";
            ConfirmModifyButton.UseVisualStyleBackColor = true;
            ConfirmModifyButton.Click += ConfirmModifyButton_Click;
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 314);
            Controls.Add(ConfirmModifyButton);
            Controls.Add(panel1);
            Name = "ModifyForm";
            Text = "ModifyForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox DetailComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ConfirmModifyButton;
        private TextBox ModifiedDetailBox;
        private TextBox OldDetailBox;
    }
}