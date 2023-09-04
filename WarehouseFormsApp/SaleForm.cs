using DataStruct1;
using DataStruct1.DataStructures;
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
    public partial class SaleForm : Form
    {
        private Warehouse warehouse;

        public SaleForm(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
        }

        public SaleForm()
        {
        }

        private void btnFindSuitableBox_Click(object sender, EventArgs e)
        {
            // Check if the warehouse object is initialized
            if (warehouse == null)
            {
                MessageBox.Show("Warehouse object is not properly initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double giftBaseSize;
            double giftHeight;
            int quantity;

            // Parse input values from textboxes
            if (!double.TryParse(txtGiftBaseSize.Text, out giftBaseSize) ||
                !double.TryParse(txtGiftHeight.Text, out giftHeight) ||
                !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the gift size based on base size, height, and quantity
            double giftSize = giftBaseSize * giftHeight * quantity;

            // Load settings
            AppSettings settings = SettingsManager.LoadSettings();

            // Calculate the minimum required size based on the minimum distance percentage
            double minRequiredSize = giftBaseSize * giftHeight * settings.MaxDistancePercentage / 100;

            // Check if the gift size meets the minimum required size
            if (giftSize < minRequiredSize)
            {
                MessageBox.Show($"Gift size doesn't meet the minimum required size of {settings.MaxDistancePercentage}% of the base size and height.",
                    "Size Insufficient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform null check on the warehouse object again
            if (warehouse != null)
            {
                // Call the FindSuitableBoxForGift method and handle the result
                TreeNode<double, Box> suitableBoxNode = warehouse.FindSuitableBoxForGift(giftBaseSize, giftHeight);

                if (suitableBoxNode != null)
                {
                    Box suitableBox = suitableBoxNode.Value;

                    DialogResult result = MessageBox.Show($"Suitable Box Found:\nBase Size: {suitableBox.BaseSize}, Height: {suitableBox.Height}\nDo you want to buy it?",
                                                          "Suitable Box Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        PurchaseBoxResult purchaseResult = warehouse.PurchaseBox(giftBaseSize, giftHeight, quantity);

                        if (purchaseResult.IsSuccess)
                        {
                            // Check if the quantity after buying is less than 3 and show a warning
                            if (purchaseResult.PurchasedBox.Quantity < 3)
                            {
                                MessageBox.Show($"Warning: Quantity of the purchased box is now less than 3.", "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            MessageBox.Show("Purchase successful.", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            // Update UI controls with purchased box information
                            txtResultBaseSize.Text = suitableBox.BaseSize.ToString();
                            txtResultHeight.Text = suitableBox.Height.ToString();
                            txtResultQuantity.Text = suitableBox.Quantity.ToString();

                            // Update the warehouse's inventory and save to file
                            warehouse.UpdateQuantity(suitableBox.BaseSize, suitableBox.Height, suitableBox.Quantity);
                            warehouse.SaveInventoryToFile();
                        }
                        else
                        {
                            MessageBox.Show(purchaseResult.ErrorMessage, "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No suitable box found for the gift.", "No Suitable Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }





        private void btnBuyBox_Click(object sender, EventArgs e)
        {
            double giftBaseSize;
            double giftHeight;
            int quantity;

            // Parse input values from textboxes
            if (!double.TryParse(txtGiftBaseSize.Text, out giftBaseSize) ||
                !double.TryParse(txtGiftHeight.Text, out giftHeight) ||
                !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PurchaseBoxResult purchaseResult = warehouse.PurchaseBox(giftBaseSize, giftHeight, quantity);

            if (purchaseResult.IsSuccess)
            {
                // Update UI with purchased box information
                txtResultBaseSize.Text = purchaseResult.PurchasedBox.BaseSize.ToString();
                txtResultHeight.Text = purchaseResult.PurchasedBox.Height.ToString();
                txtResultQuantity.Text = purchaseResult.PurchasedBox.Quantity.ToString();

                MessageBox.Show(purchaseResult.ErrorMessage, "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Check if the quantity after buying is less than 3 and show a warning
                if (purchaseResult.PurchasedBox.Quantity < 3)
                {
                    MessageBox.Show($"Warning: Quantity of the purchased box is now less than 3.", "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Update the warehouse's inventory and save to file
                warehouse.UpdateQuantity(giftBaseSize, giftHeight, purchaseResult.PurchasedBox.Quantity);
                warehouse.SaveInventoryToFile();
            }
            else
            {
                MessageBox.Show(purchaseResult.ErrorMessage, "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SaleForm_Load(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            // Load available items from the database into the warehouse
            warehouse.LoadInventoryFromFile();

            // Set default values for gift base size and height
            txtGiftBaseSize.Text = "0";
            txtGiftHeight.Text = "0";

            // Set default value for quantity
            txtQuantity.Text = "1";

            // Clear result box controls
            txtResultBaseSize.Text = "";
            txtResultHeight.Text = "";
            txtResultQuantity.Text = "";
        }



        private void btnTotalAvailableBoxes_Click(object sender, EventArgs e)
        {
            List<Box> availableBoxes = warehouse.GetAvailableBoxes();

            if (availableBoxes.Count > 0)
            {
                // Display information about available boxes
                StringBuilder boxInfo = new StringBuilder();
                foreach (var box in availableBoxes)
                {
                    boxInfo.AppendLine(box.ToString()); // Using the ToString implementation of the Box class
                }

                MessageBox.Show(boxInfo.ToString(), "Total Available Boxes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No available boxes in the warehouse.", "Total Available Boxes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
