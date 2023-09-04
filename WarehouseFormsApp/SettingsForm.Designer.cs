namespace WarehouseFormsApp
{
    partial class SettingsForm
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
            this.numericUpDownMaxQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSuitableQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAgingDuration = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMaxDistancePercentage = new System.Windows.Forms.NumericUpDown();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuitableQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgingDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDistancePercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(318, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(104, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum quality  in stock per box";
            // 
            // numericUpDownMaxQuantity
            // 
            this.numericUpDownMaxQuantity.Location = new System.Drawing.Point(110, 117);
            this.numericUpDownMaxQuantity.Name = "numericUpDownMaxQuantity";
            this.numericUpDownMaxQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaxQuantity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(107, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suitable quantity in stock per box";
            // 
            // numericUpDownSuitableQuantity
            // 
            this.numericUpDownSuitableQuantity.Location = new System.Drawing.Point(110, 193);
            this.numericUpDownSuitableQuantity.Name = "numericUpDownSuitableQuantity";
            this.numericUpDownSuitableQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSuitableQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(110, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duration T for box aging";
          
            // 
            // numericUpDownAgingDuration
            // 
            this.numericUpDownAgingDuration.Location = new System.Drawing.Point(113, 270);
            this.numericUpDownAgingDuration.Name = "numericUpDownAgingDuration";
            this.numericUpDownAgingDuration.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAgingDuration.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(110, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Maximum Distance % of the Size of a Suitable Box for a Gift";
            // 
            // numericUpDownMaxDistancePercentage
            // 
            this.numericUpDownMaxDistancePercentage.Location = new System.Drawing.Point(113, 347);
            this.numericUpDownMaxDistancePercentage.Name = "numericUpDownMaxDistancePercentage";
            this.numericUpDownMaxDistancePercentage.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaxDistancePercentage.TabIndex = 8;
          
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.AutoSize = true;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveSettings.Location = new System.Drawing.Point(284, 400);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(108, 28);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(452, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.numericUpDownMaxDistancePercentage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownAgingDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownSuitableQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMaxQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuitableQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgingDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDistancePercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSuitableQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAgingDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxDistancePercentage;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancel;
    }
}