using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
	public partial class MainForm : Form
	{
		const decimal COST_PER_DAY = 350;

		public MainForm()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{//calculate cost
			int days;
			decimal medication, surgical, lab, rehab;

			try
			{
				days = int.Parse(daysTextBox.Text);
				medication = decimal.Parse(medTextBox.Text);
				surgical = decimal.Parse(surgicalTextBox.Text);
				lab = decimal.Parse(labTextBox.Text);
				rehab = decimal.Parse(rehabTextBox.Text);

				if(days > 0 && medication > 0 && surgical > 0 && lab > 0 && rehab > 0)
				{//if inputs are valid
					totalLabel.Text = "Total: " + CalcTotalCharges(CalcStayCharges(days), CalcMiscCharges(medication, surgical, lab, rehab));
				}
				else
				{//inputs are not valid
					MessageBox.Show("Inputs must be greater than 0");
				}
			}
			catch (Exception ex)
			{//parse error
				MessageBox.Show(ex.Message);
			}
		}

		private decimal CalcStayCharges(int days)
		{//calculate charge for stay
			return COST_PER_DAY*days;
		}

		private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal lab, decimal rehab)
		{//calculate rest of charges
			return medication + surgical + lab + rehab;
		}

		private decimal CalcTotalCharges(decimal stay, decimal misc)
		{//returns total charge
			return stay + misc;
		}
	}
}
