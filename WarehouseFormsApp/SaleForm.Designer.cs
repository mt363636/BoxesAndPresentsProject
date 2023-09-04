namespace WarehouseFormsApp
{
    partial class SaleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFindSuitableBox = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResultBaseSize = new System.Windows.Forms.TextBox();
            this.txtResultHeight = new System.Windows.Forms.TextBox();
            this.txtResultQuantity = new System.Windows.Forms.TextBox();
            this.btnBuyBox = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGiftHeight = new System.Windows.Forms.TextBox();
            this.txtGiftBaseSize = new System.Windows.Forms.TextBox();
            this.btnTotalAvailableBoxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale (removal from stock)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gift base size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gift height size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // btnFindSuitableBox
            // 
            this.btnFindSuitableBox.AutoSize = true;
            this.btnFindSuitableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFindSuitableBox.Location = new System.Drawing.Point(135, 228);
            this.btnFindSuitableBox.Name = "btnFindSuitableBox";
            this.btnFindSuitableBox.Size = new System.Drawing.Size(130, 28);
            this.btnFindSuitableBox.TabIndex = 7;
            this.btnFindSuitableBox.Text = "Find suitable Box";
            this.btnFindSuitableBox.UseVisualStyleBackColor = true;
            this.btnFindSuitableBox.Click += new System.EventHandler(this.btnFindSuitableBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(135, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Most suitable box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantity";
            // 
            // txtResultBaseSize
            // 
            this.txtResultBaseSize.Location = new System.Drawing.Point(191, 316);
            this.txtResultBaseSize.Name = "txtResultBaseSize";
            this.txtResultBaseSize.Size = new System.Drawing.Size(100, 22);
            this.txtResultBaseSize.TabIndex = 12;
            // 
            // txtResultHeight
            // 
            this.txtResultHeight.Location = new System.Drawing.Point(191, 346);
            this.txtResultHeight.Name = "txtResultHeight";
            this.txtResultHeight.Size = new System.Drawing.Size(100, 22);
            this.txtResultHeight.TabIndex = 13;
            // 
            // txtResultQuantity
            // 
            this.txtResultQuantity.Location = new System.Drawing.Point(191, 375);
            this.txtResultQuantity.Name = "txtResultQuantity";
            this.txtResultQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtResultQuantity.TabIndex = 14;
            // 
            // btnBuyBox
            // 
            this.btnBuyBox.AutoSize = true;
            this.btnBuyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBuyBox.Location = new System.Drawing.Point(452, 373);
            this.btnBuyBox.Name = "btnBuyBox";
            this.btnBuyBox.Size = new System.Drawing.Size(80, 32);
            this.btnBuyBox.TabIndex = 15;
            this.btnBuyBox.Text = "Buy";
            this.btnBuyBox.UseVisualStyleBackColor = true;
            this.btnBuyBox.Click += new System.EventHandler(this.btnBuyBox_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(256, 170);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtGiftHeight
            // 
            this.txtGiftHeight.Location = new System.Drawing.Point(256, 141);
            this.txtGiftHeight.Multiline = true;
            this.txtGiftHeight.Name = "txtGiftHeight";
            this.txtGiftHeight.Size = new System.Drawing.Size(100, 22);
            this.txtGiftHeight.TabIndex = 5;
            // 
            // txtGiftBaseSize
            // 
            this.txtGiftBaseSize.Location = new System.Drawing.Point(256, 111);
            this.txtGiftBaseSize.Multiline = true;
            this.txtGiftBaseSize.Name = "txtGiftBaseSize";
            this.txtGiftBaseSize.Size = new System.Drawing.Size(100, 22);
            this.txtGiftBaseSize.TabIndex = 4;
            // 
            // btnTotalAvailableBoxes
            // 
            this.btnTotalAvailableBoxes.AutoSize = true;
            this.btnTotalAvailableBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTotalAvailableBoxes.Location = new System.Drawing.Point(376, 339);
            this.btnTotalAvailableBoxes.Name = "btnTotalAvailableBoxes";
            this.btnTotalAvailableBoxes.Size = new System.Drawing.Size(248, 28);
            this.btnTotalAvailableBoxes.TabIndex = 16;
            this.btnTotalAvailableBoxes.Text = "Show total available boxes in stock";
            this.btnTotalAvailableBoxes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTotalAvailableBoxes.UseVisualStyleBackColor = true;
            this.btnTotalAvailableBoxes.Click += new System.EventHandler(this.btnTotalAvailableBoxes_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTotalAvailableBoxes);
            this.Controls.Add(this.btnBuyBox);
            this.Controls.Add(this.txtResultQuantity);
            this.Controls.Add(this.txtResultHeight);
            this.Controls.Add(this.txtResultBaseSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFindSuitableBox);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGiftHeight);
            this.Controls.Add(this.txtGiftBaseSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFindSuitableBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResultBaseSize;
        private System.Windows.Forms.TextBox txtResultHeight;
        private System.Windows.Forms.TextBox txtResultQuantity;
        private System.Windows.Forms.Button btnBuyBox;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtGiftHeight;
        private System.Windows.Forms.TextBox txtGiftBaseSize;
        private System.Windows.Forms.Button btnTotalAvailableBoxes;
    }
}