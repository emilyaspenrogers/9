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
        public decimal OptionalServicesCharge { get; private set; }
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

        
        private decimal ReturnAccomodationRate()
        {
            decimal rate = 0;
            switch (AccomodationChoice)
            {
                case AccomodationType.Single:
                    rate = 83.61M;
                    break;
                case AccomodationType.Double:
                    rate = 56.74M;
                    break;
                case AccomodationType.Suite:
                    rate = 101.95M;
                    break;
            }
            return rate;
        }

        private decimal CalculateConferenceCharge(int numberOfAttendees, int numberOfDays, AccomodationType accomodationChoice, bool internetAccess, bool recCenterAccess)
        {
            const decimal dailyInternet = 7.28M;
            const decimal dailyRec = 6.13M;
            const double accomodationDiscount = .12;
            const double optionalDiscount = .075;


            decimal AccommodationCharge = ReturnAccomodationRate() * (numberOfAttendees * numberOfDays);
            decimal TotalInternetCharge = dailyInternet * (numberOfDays * numberOfAttendees);
            decimal TotalRecCenterCharge = dailyRec * (numberOfDays * numberOfAttendees);
            decimal OptionalServicesCharge = TotalInternetCharge + TotalRecCenterCharge;
            decimal TotalCharge;
            decimal Discount;

            if (numberOfAttendees >= 75 && numberOfDays >= 5)
            {
                
                Discount = ((decimal)accomodationDiscount * AccommodationCharge) + ((decimal)optionalDiscount * OptionalServicesCharge);
            }
            else
            {
                Discount = 0;
            }

            if (TotalInternetCharge > 0 && TotalRecCenterCharge > 0)
            {
                OptionalServicesCharge = TotalInternetCharge + TotalRecCenterCharge;
            }
            else if (TotalRecCenterCharge > 0 && TotalInternetCharge == 0)
            {
                OptionalServicesCharge = TotalRecCenterCharge;
            }
            else if (TotalInternetCharge > 0 && TotalRecCenterCharge == 0)
            {
                OptionalServicesCharge = TotalInternetCharge;
            }
            else
            {
                OptionalServicesCharge = 0;
            }

            TotalCharge = AccommodationCharge + OptionalServicesCharge - Discount;

            return TotalCharge;

            #endregion
        }

    }

}
