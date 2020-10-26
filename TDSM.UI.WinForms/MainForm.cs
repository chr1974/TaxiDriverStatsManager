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

namespace TDSM.UI.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            label1.Text = $"ConnectionString: {GlobalConfig.GetConnectionString("TDMSDatabase")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTaxiCentralForm frm = new AddTaxiCentralForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("New Taxi Central Saved");
            }
            else
            {
                MessageBox.Show("User Canceled");
            }
        }
    }
}
