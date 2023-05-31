using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityCalculator
{
    public partial class Electricity : Form
    {
        public Electricity()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name;
            decimal wattage, usage;
            int quantity;
            decimal consumption;
            name = txtName.Text;
            wattage = Convert.ToDecimal(txtWattage.Text);
            usage = Convert.ToDecimal(txtUsage.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);
            consumption = wattage * usage * quantity;
            if (rbnDay.Checked)
                consumption = consumption * 30;
            consumption = consumption / 1000;

            ListViewItem item;
            item = new ListViewItem(name);
            item.SubItems.Add(wattage.ToString());
            item.SubItems.Add(usage.ToString());
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(consumption.ToString());
            lsvAppliance.Items.Add(item);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double consumption = 0.0;
            for(int i = 0; i< lsvAppliance.Items.Count; i++)
                consumption = consumption + Convert.ToDouble(lsvAppliance.Items[i].SubItems[4].Text);
            Calculate(consumption);
        }

        private void Calculate(double consumption)
        {
            double rate = 0.0;
            double service = 0.0;
            double bill = 0.0;
            double totalbill = 0.0;
            if (consumption >= 0 && consumption <= 50)
            {
                rate = 0.2730;
                service = 10;
            }
            else if (consumption > 50 && consumption <= 100)
            {
                rate = 0.7670;
                service = 42;
            }
            else if (consumption > 100 && consumption <= 200)
            {
                rate = 1.625;
                service = 42;
            }
            else if (consumption > 200 && consumption <= 300)
            {
                rate = 2.0;
                service = 42;
            }
            else if (consumption > 300 && consumption <= 400)
            {
                rate = 2.2;
                service = 42;
            }
            else if (consumption > 400 && consumption <= 500)
            {
                rate = 2.405;
                service = 42;
            }
            else if (consumption > 500)
            {
                rate = 2.481;
                service = 42;
            }
            else { 
                MessageBox.Show("Something went wrong. Try again.");
                return;
            }
            bill = consumption * rate;
            totalbill = bill + service;
            txtConsumption.Text = consumption.ToString("f3");
            txtBillAmount.Text = bill.ToString("f3");
            txtServiceCharge.Text = service.ToString("f3");
            txtTotalBill.Text = totalbill.ToString("f3");
        }
    }
}
