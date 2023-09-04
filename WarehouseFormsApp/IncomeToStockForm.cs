using DataStruct1.DatabaseLoad;
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
using DataStruct1.DataStructures;
using WarehouseFormsApp.Settings;

namespace WarehouseFormsApp
{
    
    public partial class IncomeToStockForm : Form
    {
        private Warehouse warehouse;
        private System.Windows.Forms.NumericUpDown numericUpDownAgingDuration;
        private Tree<double, Box> boxTree;
        public IncomeToStockForm()
        {
            InitializeComponent();
            boxTree = new Tree<double, Box>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            // Validate input values
            if (!double.TryParse(textBox1.Text, out double baseSize) ||
                !double.TryParse(textBox2.Text, out double height) ||
                !int.TryParse(textBox3.Text, out int quantity))
            {
                MessageBox.Show("Invalid input values. Please enter valid numbers for Base Size, Height, and Quantity.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (baseSize <= 0 || height <= 0 || quantity <= 0)
            {
                MessageBox.Show("All values must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Load settings
            AppSettings settings = SettingsManager.LoadSettings();

            // Check maximum quantity
            if (quantity > settings.MaxQuantity)
            {
                MessageBox.Show($"Quantity exceeds the maximum allowed quantity of {settings.MaxQuantity}.",
                    "Quantity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check suitable quantity
            if (quantity < settings.SuitableQuantity)
            {
                MessageBox.Show($"You should add at least {settings.SuitableQuantity} boxes.",
                    "Not Suitable Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check aging duration
            if (baseSize + height > settings.MaxDistancePercentage)
            {
                MessageBox.Show($"The sum of Base Size and Height exceeds the maximum allowed distance percentage of {settings.MaxDistancePercentage}.",
                    "Size Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Load existing inventory from the file
            List<Box> existingInventory = LoadAndSaveData.LoadDataFromFile();

            // Check if a box with the same base size and height exists in the inventory
            Box existingBox = existingInventory.FirstOrDefault(box => box.BaseSize == baseSize && box.Height == height);
            if (existingBox != null)
            {
                // Calculate the total quantity after adding the new quantity
                int totalQuantity = existingBox.Quantity + quantity;

                // Check if the total quantity exceeds the limit of 10
                if (totalQuantity > 10)
                {
                    MessageBox.Show($"Total quantity after addition exceeds the maximum limit of 10 for an existing box: {existingBox}",
                        "Quantity Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the existing box's quantity and expiration date
                existingBox.Quantity = totalQuantity;
                existingBox.ExpiryDate = DateTime.Now.AddDays(settings.AgingDuration);

                // Save the updated inventory to the file
                LoadAndSaveData.SaveDataInFile(existingInventory);

                // Display success message or update UI
                MessageBox.Show($"Quantity and Expiration Date updated for existing box: {existingBox}",
                    "Existing Box Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                ClearInputFields();
                return;
            }

            // Create a new box
            Box newBox = new Box(baseSize, height, quantity, settings.AgingDuration);

            // Add the new box to the existing inventory
            existingInventory.Add(newBox);

            // Save the updated inventory to the file
            LoadAndSaveData.SaveDataInFile(existingInventory);

            // Display success message or update UI
            MessageBox.Show("Box added to inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            ClearInputFields();
        }




        private List<Box> ConvertTreeToInventory(TreeNode<double, Box> node)
        {
            List<Box> inventory = new List<Box>();

            if (node != null)
            {
                inventory.Add(node.Value);
                inventory.AddRange(ConvertTreeToInventory(node.Left));
                inventory.AddRange(ConvertTreeToInventory(node.Right));
            }

            return inventory;
        }
        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
         
        }

        private void IncomeToStockForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowExpired_Click(object sender, EventArgs e)
        {
            List<Box> existingInventory = LoadAndSaveData.LoadDataFromFile();
            DateTime currentTime = DateTime.Now;
            List<Box> expiredBoxes = new List<Box>();

            foreach (var box in existingInventory)
            {
                if (box.ExpiryDate <= currentTime)
                {
                    expiredBoxes.Add(box);
                }
            }

            if (expiredBoxes.Count == 0)
            {
                MessageBox.Show("No expired boxes found.", "Expired Boxes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StringBuilder expiredBoxesInfo = new StringBuilder();

                foreach (var expiredBox in expiredBoxes)
                {
                    expiredBoxesInfo.AppendLine(expiredBox.ToString());
                }

                MessageBox.Show($"Expired Boxes:\n\n{expiredBoxesInfo.ToString()}", "Expired Boxes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Remove the expired boxes from the existingInventory list
                foreach (var expiredBox in expiredBoxes)
                {
                    existingInventory.Remove(expiredBox);
                }

                // Save the updated existingInventory list to a file
                LoadAndSaveData.SaveDataInFile(existingInventory);

  
                MessageBox.Show("Expired boxes have been removed from inventory and inventory data has been updated.", "Expired Boxes Removed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void TraverseBoxTree(TreeNode<double, Box> node, List<Box> boxList)
        {
            if (node == null)
            {
                return;
            }

            boxList.Add(node.Value);
            TraverseBoxTree(node.Left, boxList);
            TraverseBoxTree(node.Right, boxList);
        }




    }
}
