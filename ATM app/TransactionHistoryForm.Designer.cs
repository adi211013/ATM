namespace ATM_app
{
    partial class TransactionHistoryForm
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
            this.transactionHistoryGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionHistoryGridView
            // 
            this.transactionHistoryGridView.AllowUserToAddRows = false;
            this.transactionHistoryGridView.AllowUserToDeleteRows = false;
            this.transactionHistoryGridView.AllowUserToResizeColumns = false;
            this.transactionHistoryGridView.AllowUserToResizeRows = false;
            this.transactionHistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionHistoryGridView.Location = new System.Drawing.Point(0, 0);
            this.transactionHistoryGridView.Name = "transactionHistoryGridView";
            this.transactionHistoryGridView.Size = new System.Drawing.Size(1467, 621);
            this.transactionHistoryGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(667, 667);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(176, 99);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 796);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transactionHistoryGridView);
            this.Font = new System.Drawing.Font("Miriam CLM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TransactionHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM app";
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionHistoryGridView;
        private System.Windows.Forms.Button backButton;
    }
}