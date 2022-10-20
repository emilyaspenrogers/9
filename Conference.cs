using System;
using System.Collections.Generic;
using System.Text;

namespace ERogersProgram9
{
    #region "Enumeration"

    public enum AccomodationType
    {
        Single,
        Double,
        Suite
    }
    #endregion
    class Conference
    {
        #region "Fields"

        private int numberOfAttendees, numberOfDays;
        private AccomodationType accomodationChoice;
        private bool internetAccess, recCenterAccess;

        #endregion

        #region "Properties"

        public int NumberOfAttendees
        {
            get
            {
                return numberOfAttendees;
            }
            set
            {
                numberOfAttendees = value;
                CalculateConferenceCharge(numberOfAttendees, numberOfDays, accomodationChoice, internetAccess, recCenterAccess);
            }
        }
        public int NumberOfDays
        {
            get
            {
                return numberOfDays;
            }
            set
            {
                numberOfDays = value;
                CalculateConferenceCharge(numberOfAttendees, numberOfDays, accomodationChoice, internetAccess, recCenterAccess);
            }
        }
        
        public bool InternetAccess
        {
            get
            {
                return internetAccess;
            }
            set
            {
                internetAccess = value;
                CalculateConferenceCharge(numberOfAttendees, numberOfDays, accomodationChoice, internetAccess, recCenterAccess);
            }
        }
        public bool RecCenterAccess
        {
            get
            {
                return recCenterAccess;
            }
            set
            {
                recCenterAccess = value;
                CalculateConferenceCharge(numberOfAttendees, numberOfDays, accomodationChoice, internetAccess, recCenterAccess);
            }
        }
        public AccomodationType AccomodationChoice
        {
            get
            {
                return accomodationChoice;
            }
            set
            {
                accomodationChoice = value;
                CalculateConferenceCharge(numberOfAttendees, numberOfDays, accomodationChoice, internetAccess, recCenterAccess);
            }
        }
        
        public string NameOfConference { get; set; }
        public decimal AccommodationCharge { get; private set; }
        public decimal OptionalServiceCharge { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TotalCharge { get; private set; }

        #endregion

        #region "Constructors"

        public Conference(string name, int numberOfAttendees, int numberOfDays, AccomodationType accomodationChoice, bool internetAccess, bool recCenterAccess)
        {
            NameOfConference = name;
            NumberOfAttendees = numberOfAttendees;
            NumberOfDays = numberOfDays;
            AccomodationChoice = accomodationChoice;
            InternetAccess = internetAccess;
            RecCenterAccess = recCenterAccess; 
        }
        #endregion

        #region "Instance Methods"

        //private decimal ReturnAccomodationRate(AccomodationType accomodationChoice)
        //{


        //    switch (accomodationChoice)
        //    {
        //        case AccomodationType.Single:
        //            {
        //                return (decimal)(83.61 * (numberOfAttendees * numberOfDays));
        //            }
        //        case AccomodationType.Double:
        //            {
        //                return (decimal)(56.74 * (numberOfAttendees * numberOfDays));
        //            }
        //        case AccomodationType.Suite:
        //            {
        //                return (decimal)(101.95 * (numberOfAttendees * numberOfDays));
        //            }
        //    }
        //    return AccommodationCharge;
        //}

        private decimal ReturnAccomodationRate(AccomodationType accomodationChoice)
        {


            switch (accomodationChoice)
            {
                case AccomodationType.Single:
                    {
                        return (decimal)(83.61);
                    }
                case AccomodationType.Double:
                    {
                        return (decimal)(56.74);
                    }
                case AccomodationType.Suite:
                    {
                        return (decimal)(101.95);
                    }
            }
            return ReturnAccomodationRate(accomodationChoice);
        }

        private void CalculateConferenceCharge(int numberOfAttendees, int numberOfDays, AccomodationType accomodationChoice, bool internetAccess, bool recCenterAccess)
        {
            const decimal dailyInternet = 7.28M;
            const decimal dailyRec = 6.13M;
            const double accomodationDiscount = .12;
            const double optionalDiscount = .075;

            //decimal accommodationCharge = ReturnAccomodationRate(AccomodationChoice);
            decimal accommodationCharge = ReturnAccomodationRate(accomodationChoice) * (numberOfAttendees * numberOfDays);
            decimal totalInternetCharge = dailyInternet * (numberOfDays * numberOfAttendees);
            decimal totalRecCenterCharge = dailyRec * (numberOfDays * numberOfAttendees);
            decimal optionalServicesCharge = totalInternetCharge + totalRecCenterCharge;
            decimal totalCharge;
            decimal discount;


            if (internetAccess == true && recCenterAccess == true)
            {
                optionalServicesCharge = totalInternetCharge + totalRecCenterCharge;
            }
            else if (internetAccess == true && recCenterAccess == false)
            {
                optionalServicesCharge = totalInternetCharge;
            }
            else if (recCenterAccess == true && internetAccess == false)
            {
                optionalServicesCharge = totalRecCenterCharge;
            }
            else
            {
                optionalServicesCharge = 0;
            }

            if (numberOfAttendees >=75 && numberOfDays >= 5)
            {
                // this is erroring out. I'm not sure why. Perhaps it's my call above to my ReturnAccomodationRate method in accommodationCharge? Perhaps it the entire ReturnAccomodationRate method that's wrong? 
                discount = ((double)(Convert.ToDecimal(accomodationDiscount) * accommodationCharge) + ((double)(Convert.ToDecimal(optionalDiscount) * optionalServicesCharge);
            }
             else
            {
                discount = 0; 
            }

          

            //need to update code below that determines whether or not internet access and rec access was selected or not i.e. 
            // if (internetaccess is selected { figure out totalinternet charge }. 

            //if (totalInternetCharge > 0 && totalRecCenterCharge > 0 )
            //{
            //    optionalServicesCharge = totalInternetCharge + totalRecCenterCharge;
            //}
            //else if (totalRecCenterCharge > 0 && totalInternetCharge == 0)
            //{
            //    optionalServicesCharge = totalRecCenterCharge;
            //}
            //else if (totalInternetCharge > 0 && totalRecCenterCharge == 0)
            //{
            //    optionalServicesCharge = totalInternetCharge;
            //}
            //else
            //{
            //    optionalServicesCharge = 0; 
            //}

            totalCharge = accommodationCharge + optionalServicesCharge - discount;

            #endregion
        }

    }

}
