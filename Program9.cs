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
        private Conference aConference;
        private string name;
        private int numberOfAttendees, numberOfNights;
        private bool internetAccess, recCenterAccess;
        private AccomodationType accomodationChoice;

        public Program9()
        {

            InitializeComponent();


        }

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

            aConference = new Conference(name, numberOfAttendees, numberOfNights, accomodationChoice, internetAccess, recCenterAccess);

            //cal Dispaly Charges Method

            DisplayCharges();

            tbxName.Enabled = false;
            btnCreateConference.Enabled = false;
            btnModifyConference.Enabled = true;

        }

        private void btnModifyConference_Click(object sender, EventArgs e)
        {
            // call assign inputs to variable method

            AssignInputs();


            //reset properties

            aConference.AccomodationChoice = accomodationChoice;
            aConference.NumberOfAttendees = numberOfAttendees;
            aConference.NumberOfDays = numberOfNights;
            aConference.InternetAccess = internetAccess;
            aConference.RecCenterAccess = recCenterAccess;

            // call Display Charges Method
        }

        private void AssignInputs()
        {
            name = tbxName.Text;
            numberOfAttendees = Convert.ToInt32(numNumberOfAttendees.Value);
            numberOfNights = Convert.ToInt32(numNumberOfNights.Value);

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

            string strCharges = $"Accommodation Charge: {aConference.AccommodationCharge.ToString("c2")} \n Optional Services Charge: {aConference.OptionalServiceCharge.ToString("c2")} \n Discounts: {aConference.Discount.ToString("c2")} \n Total Charges: {aConference.TotalCharge.ToString("c2")}";

                // display the result in labl

            lblResults.Text = strCharges; 
        }
    }
}

    

     
