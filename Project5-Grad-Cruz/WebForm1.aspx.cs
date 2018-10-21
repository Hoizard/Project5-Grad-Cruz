using Project3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class CalcMortgage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OtherYears.Enabled = false;
            }
        }

        private void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue.ToLower() == "Other".ToLower())
            {
                OtherYears.Enabled = true;
            }
            else
            {
                OtherYears.Enabled = false;
                OtherYears.Text = string.Empty;
            }
        }

        public static double ComputeMonthlyPayment(double principal, double years, double rate)
        {
            double monthly = 0;
            double top = principal * rate / 1200.00;
            double bottom = 1 - Math.Pow(1.0 + rate / 1200.0, -12.0 * years);
            monthly = top / bottom;
            return monthly;
        }

        public void ComputeMortgage_Click(object sender, EventArgs e)
        {
            string inPrin = PrincipleAmount.Text;
            string inYears = OtherYears.Text;
            string inRate = DropDownList1.SelectedItem.Text;

            double years = 0;

            bool check = false;

            if (double.TryParse(inPrin, out double principal) == false)
            {
                ResultPayment.Text = $"Please input a Principle Amount";
                check = true;
            }

            if (RadioButtonList1.SelectedIndex == 2)
            {
                if (double.TryParse(inYears, out years) == false)
                {
                    ResultPayment.Text = $"Please select an Loan Duration";
                    check = true;
                }
            }
            if (RadioButtonList1.SelectedIndex == 0)
            {
                years = 15;
            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                years = 30;
            }

            if (double.TryParse(inRate, out double rate) == false)
            {
                ResultPayment.Text = $"Please select an Interest Rate";
                check = true;
            }

            if (check == false)
            {
                double monthly = ComputeMonthlyPayment(principal, years, rate);
                string formattedOutput = string.Format("The monthly payment is {0:C}", monthly);
                ResultPayment.Text = formattedOutput;

                //IIOHelper fileIOHelper = new DatabaseIOHelper();
                FileIOHelper fileIOHelper = new FileIOHelper(ServerPathHelper.GetPath("~/app_data/log.txt"));
                fileIOHelper.AddMortgages(formattedOutput);
            }
        }
    }
}