using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERogersProgram9
{
    public partial class Program9 : Form
    {
       
        public Program9()
        {

            InitializeComponent();
        }
        //declare class level variables

        private Conference aConference;
        private string name;
        private int numberOfAttendees, numberOfDays;
        private bool internetAccess, recCenterAccess;
        private AccomodationType accomodationChoice;

        private void btnCreateConference_Click(object sender, EventArgs e)
        {
            //check name TextBox

            if (tbxName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Conference name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error); tbxName.Focus();
                return;
            }

            // call assign inputs to variable method

            AssignInputs();

            // instantiate object

            aConference = new Conference(name, numberOfAttendees, numberOfDays, accomodationChoice, internetAccess, recCenterAccess);

            //cal Dispaly Charges Method

            DisplayCharges();

            // disable/enable controls

            tbxName.Enabled = false;
            btnCreateConference.Enabled = false;
            btnModifyConference.Enabled = true;

        }

        private void btnModifyConference_Click(object sender, EventArgs e)
        {
            // call assign inputs to variable method

            AssignInputs();

            // reset properties

            aConference.AccomodationChoice = accomodationChoice;
            aConference.NumberOfAttendees = numberOfAttendees;
            aConference.NumberOfDays = numberOfDays;
            aConference.InternetAccess = internetAccess;
            aConference.RecCenterAccess = recCenterAccess;

            // call Display Charges Method

            DisplayCharges();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for new inputs

            tbxName.Clear();
            numNumberOfAttendees.Value = numNumberOfAttendees.Minimum;
            numNumberOfNights.Value = numNumberOfNights.Minimum;
            rbtnSingle.Checked = true;
            rbtnDouble.Checked = false;
            rbtnSuite.Checked = false;
            chbxInternetAccess.Checked = false;
            chbxRecCenterAccess.Checked = false;
            lblResults.Text = null;

            //enable/disable controls

            tbxName.Enabled = true;
            btnCreateConference.Enabled = true;
            btnModifyConference.Enabled = false;

            //set focus
            tbxName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult aResult;

            aResult = MessageBox.Show("Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                tbxName.Focus();
            }
        }

        private void AssignInputs()
        {


            name = tbxName.Text;
            numberOfAttendees = Convert.ToInt32(numNumberOfAttendees.Value);
            numberOfDays = Convert.ToInt32(numNumberOfNights.Value);

            if (rbtnSingle.Checked)
            {
                accomodationChoice = AccomodationType.Single;
            }
            else if (rbtnDouble.Checked)
            {
                accomodationChoice = AccomodationType.Double;
            }
            else
            {
                accomodationChoice = AccomodationType.Suite;
            }

            internetAccess = (chbxInternetAccess.Checked) ? true : false;
            recCenterAccess = (chbxRecCenterAccess.Checked) ? true : false;
        }

        private void DisplayCharges()
        {
            //prepare message to dispaly

            string Results = $"Accommodation Charge: {aConference.AccommodationCharge.ToString("C")} \n Optional Services Charge: {aConference.OptionalServicesCharge.ToString("C")} \n Discounts: {aConference.Discount.ToString("C")} \n Total Charges: {aConference.TotalCharge.ToString("C")}";

                // display the result in labl

            lblResults.Text = Results; 
        }
    }
}

    

     
