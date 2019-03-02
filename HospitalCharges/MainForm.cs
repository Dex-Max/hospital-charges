using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Program: Hospital Charge Calculator
//Developer: Randall Kim
//Date: 3/1/2019
//Description: Calculates total cost from hospital and saves to a file

namespace HospitalCharges
{
	public partial class MainForm : Form
	{
		const decimal COST_PER_DAY = 350;

		int days;
		decimal medication, surgical, lab, rehab, total;

		public MainForm()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{//calculate cost
			try
			{
				days = int.Parse(daysTextBox.Text);
				medication = decimal.Parse(medTextBox.Text);
				surgical = decimal.Parse(surgicalTextBox.Text);
				lab = decimal.Parse(labTextBox.Text);
				rehab = decimal.Parse(rehabTextBox.Text);

				if(days > 0 && medication > 0 && surgical > 0 && lab > 0 && rehab > 0)
				{//if inputs are valid
					total = CalcTotalCharges(CalcStayCharges(days), CalcMiscCharges(medication, surgical, lab, rehab));
					totalLabel.Text = "Total: " + total;
				}
				else
				{//inputs are not valid
					MessageBox.Show("Inputs must be greater than 0");
				}
			}// end try
			catch (Exception ex)
			{//parse error
				MessageBox.Show(ex.Message);
			}
		}//end calculatebutton

		private void resetButton_Click(object sender, EventArgs e)
		{//reset textBoxes
			daysTextBox.Text = "";
			medTextBox.Text = "";
			surgicalTextBox.Text = "";
			labTextBox.Text = "";
			rehabTextBox.Text = "";
			timeTextBox.Text = "";
			dateTextBox.Text = "";
			totalLabel.Text = "Total: ";
		}//end resetButton

		private void saveButton_Click(object sender, EventArgs e)
		{//saves total, time, and date to a file
			try
			{
				if (saveDialog.ShowDialog() == DialogResult.OK)
				{//if dialogresult = ok
					if(total > 0)
					{
						StreamWriter chargesFile;
						chargesFile = File.AppendText(saveDialog.FileName);

						chargesFile.WriteLine("Time: " + timeTextBox.Text + " Date: " + dateTextBox.Text + " " + totalLabel.Text);
						chargesFile.Close();
					}
					else
					{
						MessageBox.Show("Total cost is not greater than 0");
					}	
				}//end if
			}//end try
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}//end savebuttonClick

		private decimal CalcStayCharges(int days)
		{//calculate charge for stay
			return COST_PER_DAY*days;
		}//end calcstaycharges
		private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal lab, decimal rehab)
		{//calculate rest of charges
			return medication + surgical + lab + rehab;
		}//end calcmisccharges

		private decimal CalcTotalCharges(decimal stay, decimal misc)
		{//returns total charge
			return stay + misc;
		}//end calctotalcharges	
	}//end form class
}//end namespace
