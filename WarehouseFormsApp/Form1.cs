using DataStruct1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseFormsApp.Settings;

namespace WarehouseFormsApp
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncomeToStock_Click(object sender, EventArgs e)
        {
            IncomeToStockForm incomeForm = new IncomeToStockForm();
            incomeForm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
            SettingsForm settingsForm = new SettingsForm(SettingsManager.LoadSettings());
            settingsForm.ShowDialog();
        }



        private void btnSale_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            SaleForm saleForm = new SaleForm(warehouse);
            if (warehouse == null)
            {
                MessageBox.Show("Warehouse object is not properly initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            saleForm.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowLoginForm();

            label1.Anchor = AnchorStyles.None| AnchorStyles.Top;
            // Rearrange controls and adjust automatically when maximized
            btnExit.Anchor = AnchorStyles.None | AnchorStyles.None;
            btnCredits.Anchor = AnchorStyles.None | AnchorStyles.None;

            // Anchor PictureBox controls
            pictureBox1.Anchor = AnchorStyles.None | AnchorStyles.Left;
            pictureBox2.Anchor = AnchorStyles.None | AnchorStyles.Right;

            // Anchor the main menu buttons
            btnIncomeToStock.Anchor = AnchorStyles.None | AnchorStyles.None;
            btnSettings.Anchor = AnchorStyles.None | AnchorStyles.None;
            btnSale.Anchor = AnchorStyles.None | AnchorStyles.None;
            CenterTitleLabel();

        }
        private void CenterTitleLabel()
        {
            // Center the title label horizontally and position it at the top
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, 50); // Adjust the Y-coordinate (20) as needed
        }


        private void ShowLoginForm()
        {
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Close(); 
                }
            }
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            string creditsMessage = "Boxes and Presents Forms Application\n" +
                          "Build Version: 1.0.0\n" +
                          "Developed by Martin Terniak\n" +
                          "© 2023 All Rights Reserved.";

            MessageBox.Show(creditsMessage, "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
