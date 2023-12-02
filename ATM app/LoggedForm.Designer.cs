namespace ATM_app
{
    partial class LoggedForm
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
            this.header1Label = new System.Windows.Forms.Label();
            this.header2Label = new System.Windows.Forms.Label();
            this.depositWithdrawButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1Label
            // 
            this.header1Label.AutoSize = true;
            this.header1Label.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.header1Label.Location = new System.Drawing.Point(432, 9);
            this.header1Label.Name = "header1Label";
            this.header1Label.Size = new System.Drawing.Size(202, 35);
            this.header1Label.TabIndex = 0;
            this.header1Label.Text = "Hello <name>";
            // 
            // header2Label
            // 
            this.header2Label.AutoSize = true;
            this.header2Label.Location = new System.Drawing.Point(396, 65);
            this.header2Label.Name = "header2Label";
            this.header2Label.Size = new System.Drawing.Size(222, 23);
            this.header2Label.TabIndex = 1;
            this.header2Label.Text = "What do you want to do?";
            // 
            // depositWithdrawButton
            // 
            this.depositWithdrawButton.Location = new System.Drawing.Point(127, 216);
            this.depositWithdrawButton.Name = "depositWithdrawButton";
            this.depositWithdrawButton.Size = new System.Drawing.Size(200, 150);
            this.depositWithdrawButton.TabIndex = 2;
            this.depositWithdrawButton.Text = "Deposit/Withdraw Money";
            this.depositWithdrawButton.UseVisualStyleBackColor = true;
            this.depositWithdrawButton.Click += new System.EventHandler(this.depositWithdrawButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(408, 216);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(200, 150);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "Show transaction history";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // exitAppButton
            // 
            this.exitAppButton.Location = new System.Drawing.Point(689, 216);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(200, 150);
            this.exitAppButton.TabIndex = 4;
            this.exitAppButton.Text = "Exit ATM";
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // LoggedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 537);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.depositWithdrawButton);
            this.Controls.Add(this.header2Label);
            this.Controls.Add(this.header1Label);
            this.Font = new System.Drawing.Font("Miriam CLM", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoggedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header1Label;
        private System.Windows.Forms.Label header2Label;
        private System.Windows.Forms.Button depositWithdrawButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button exitAppButton;
    }
}