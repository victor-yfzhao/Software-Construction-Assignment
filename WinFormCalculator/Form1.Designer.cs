namespace WinFormCalculator
{
    partial class WinFormCal
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.opNum1 = new System.Windows.Forms.TextBox();
            this.opNum2 = new System.Windows.Forms.TextBox();
            this.Ans = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.RadioButton();
            this.sub = new System.Windows.Forms.RadioButton();
            this.mul = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.OperatorChoises = new System.Windows.Forms.Panel();
            this.OperatorTitle = new System.Windows.Forms.Label();
            this.num1Title = new System.Windows.Forms.Label();
            this.num2Title = new System.Windows.Forms.Label();
            this.inputPannel = new System.Windows.Forms.Panel();
            this.ansPanel = new System.Windows.Forms.Panel();
            this.AnsTitle = new System.Windows.Forms.Label();
            this.OperatorChoises.SuspendLayout();
            this.inputPannel.SuspendLayout();
            this.ansPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(284, 200);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(151, 37);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Calculate!";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // opNum1
            // 
            this.opNum1.Location = new System.Drawing.Point(5, 24);
            this.opNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opNum1.Name = "opNum1";
            this.opNum1.Size = new System.Drawing.Size(117, 25);
            this.opNum1.TabIndex = 1;
            // 
            // opNum2
            // 
            this.opNum2.Location = new System.Drawing.Point(148, 24);
            this.opNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opNum2.Name = "opNum2";
            this.opNum2.Size = new System.Drawing.Size(119, 25);
            this.opNum2.TabIndex = 2;
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(6, 35);
            this.Ans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ans.Name = "Ans";
            this.Ans.ReadOnly = true;
            this.Ans.Size = new System.Drawing.Size(138, 25);
            this.Ans.TabIndex = 3;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(3, 26);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(76, 19);
            this.add.TabIndex = 4;
            this.add.TabStop = true;
            this.add.Text = "Add(+)";
            this.add.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Location = new System.Drawing.Point(3, 48);
            this.sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(124, 19);
            this.sub.TabIndex = 5;
            this.sub.TabStop = true;
            this.sub.Text = "Substract(-)";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // mul
            // 
            this.mul.AutoSize = true;
            this.mul.Location = new System.Drawing.Point(3, 69);
            this.mul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(123, 19);
            this.mul.TabIndex = 6;
            this.mul.TabStop = true;
            this.mul.Text = "Multiply(×)";
            this.mul.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(3, 91);
            this.div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(107, 19);
            this.div.TabIndex = 7;
            this.div.TabStop = true;
            this.div.Text = "Divide(÷)";
            this.div.UseVisualStyleBackColor = true;
            // 
            // OperatorChoises
            // 
            this.OperatorChoises.Controls.Add(this.OperatorTitle);
            this.OperatorChoises.Controls.Add(this.add);
            this.OperatorChoises.Controls.Add(this.div);
            this.OperatorChoises.Controls.Add(this.sub);
            this.OperatorChoises.Controls.Add(this.mul);
            this.OperatorChoises.Location = new System.Drawing.Point(21, 119);
            this.OperatorChoises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OperatorChoises.Name = "OperatorChoises";
            this.OperatorChoises.Size = new System.Drawing.Size(177, 111);
            this.OperatorChoises.TabIndex = 8;
            // 
            // OperatorTitle
            // 
            this.OperatorTitle.AutoSize = true;
            this.OperatorTitle.Location = new System.Drawing.Point(3, 9);
            this.OperatorTitle.Name = "OperatorTitle";
            this.OperatorTitle.Size = new System.Drawing.Size(159, 15);
            this.OperatorTitle.TabIndex = 8;
            this.OperatorTitle.Text = "Choose an operator:";
            // 
            // num1Title
            // 
            this.num1Title.AutoSize = true;
            this.num1Title.Location = new System.Drawing.Point(3, 8);
            this.num1Title.Name = "num1Title";
            this.num1Title.Size = new System.Drawing.Size(87, 15);
            this.num1Title.TabIndex = 9;
            this.num1Title.Text = "1st Number";
            // 
            // num2Title
            // 
            this.num2Title.AutoSize = true;
            this.num2Title.Location = new System.Drawing.Point(145, 8);
            this.num2Title.Name = "num2Title";
            this.num2Title.Size = new System.Drawing.Size(87, 15);
            this.num2Title.TabIndex = 10;
            this.num2Title.Text = "2nd Number";
            // 
            // inputPannel
            // 
            this.inputPannel.Controls.Add(this.num1Title);
            this.inputPannel.Controls.Add(this.num2Title);
            this.inputPannel.Controls.Add(this.opNum1);
            this.inputPannel.Controls.Add(this.opNum2);
            this.inputPannel.Location = new System.Drawing.Point(21, 24);
            this.inputPannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPannel.Name = "inputPannel";
            this.inputPannel.Size = new System.Drawing.Size(284, 58);
            this.inputPannel.TabIndex = 11;
            // 
            // ansPanel
            // 
            this.ansPanel.Controls.Add(this.AnsTitle);
            this.ansPanel.Controls.Add(this.Ans);
            this.ansPanel.Location = new System.Drawing.Point(284, 110);
            this.ansPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansPanel.Name = "ansPanel";
            this.ansPanel.Size = new System.Drawing.Size(151, 75);
            this.ansPanel.TabIndex = 12;
            // 
            // AnsTitle
            // 
            this.AnsTitle.AutoSize = true;
            this.AnsTitle.Location = new System.Drawing.Point(4, 9);
            this.AnsTitle.Name = "AnsTitle";
            this.AnsTitle.Size = new System.Drawing.Size(63, 15);
            this.AnsTitle.TabIndex = 4;
            this.AnsTitle.Text = "Answer:";
            // 
            // WinFormCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 282);
            this.Controls.Add(this.ansPanel);
            this.Controls.Add(this.inputPannel);
            this.Controls.Add(this.OperatorChoises);
            this.Controls.Add(this.ConfirmButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WinFormCal";
            this.Text = "SimpleCalculator";
            this.Load += new System.EventHandler(this.WinFormCal_Load);
            this.OperatorChoises.ResumeLayout(false);
            this.OperatorChoises.PerformLayout();
            this.inputPannel.ResumeLayout(false);
            this.inputPannel.PerformLayout();
            this.ansPanel.ResumeLayout(false);
            this.ansPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox opNum1;
        private System.Windows.Forms.TextBox opNum2;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.RadioButton mul;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.Panel OperatorChoises;
        private System.Windows.Forms.Label OperatorTitle;
        private System.Windows.Forms.Panel inputPannel;
        private System.Windows.Forms.Label num1Title;
        private System.Windows.Forms.Label num2Title;
        private System.Windows.Forms.Panel ansPanel;
        private System.Windows.Forms.Label AnsTitle;
    }
}

