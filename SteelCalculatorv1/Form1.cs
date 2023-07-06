using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelCalculatorv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var TotalDays = (calendarDateDue.Value - calendarEndDate.Value.AddDays(1)).TotalDays;
            txtDaysBetween.Text = Math.Abs(TotalDays).ToString();
            var RentAmount = Math.Round(Math.Abs(Convert.ToDouble(txtRentAmount.Text)),2);
            txtRentOwed.Text = Math.Round(Math.Abs((TotalDays * RentAmount)),2).ToString();

        }
    }
}
