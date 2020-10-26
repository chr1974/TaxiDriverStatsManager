using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDSM.Data.Lib;
using TDSM.Data.Lib.DataAccess;
using TDSM.Data.Lib.Models;

namespace TDSM.UI.WinForms
{
    public partial class AddTaxiCentralForm : Form
    {
        public AddTaxiCentralForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TaxiCentralModel model = new TaxiCentralModel(TaxiCentralNameTextBox.Text);

             
                GlobalConfig.Connection.CreateTaxiCentral(model);
                

                TaxiCentralNameTextBox.Text = "";
            } else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
                DialogResult = DialogResult.None;
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if(string.IsNullOrEmpty(TaxiCentralNameTextBox.Text) || string.IsNullOrWhiteSpace(TaxiCentralNameTextBox.Text) || TaxiCentralNameTextBox.Text.Length <= 3)
            {
                output = false;
            }

            return output;
        }
    }
}
