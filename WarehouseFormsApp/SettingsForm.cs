using DataStruct1.DatabaseLoad;
using DataStruct1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseFormsApp.Settings;

namespace WarehouseFormsApp
{
    public partial class SettingsForm : Form
    {
        private AppSettings settings;
      


        public SettingsForm(AppSettings settings)
        {
            InitializeComponent();
            this.settings = settings; 
           
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Load the provided settings
            numericUpDownMaxQuantity.Value = settings.MaxQuantity;
            numericUpDownSuitableQuantity.Value = settings.SuitableQuantity;
            numericUpDownAgingDuration.Value = settings.AgingDuration;
            numericUpDownMaxDistancePercentage.Value = (decimal)settings.MaxDistancePercentage;
        }




        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update settings with new values from numeric up-down controls
            settings.MaxQuantity = (int)numericUpDownMaxQuantity.Value;
            settings.SuitableQuantity = (int)numericUpDownSuitableQuantity.Value;
            settings.MaxDistancePercentage = (double)numericUpDownMaxDistancePercentage.Value;

            // Save the updated settings
            SettingsManager.SaveSettings(settings);
        }


        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            settings.MaxQuantity = (int)numericUpDownMaxQuantity.Value;
            settings.SuitableQuantity = (int)numericUpDownSuitableQuantity.Value;
            settings.AgingDuration = (int)numericUpDownAgingDuration.Value;
            settings.MaxDistancePercentage = (double)numericUpDownMaxDistancePercentage.Value;

            SettingsManager.SaveSettings(settings);

            MessageBox.Show("Settings saved successfully.", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  
        private void numericUpDownMaxDistancePercentage_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
