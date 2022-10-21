/*
 * Project: Assignment Set 4 - Program 9
 * Date: October 2022
 * Developed by: ER
 * Class Name: Conference
 * Last modified: 10/21/2022
 * Descriptions: Using Business Logic class calculate and determine the cost of a conference and apply he appropriate charges and discounts based on different user selections.
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace ERogersProgram9
{
    #region "Enumeration"

    // set the enumerations for accomodation types for class 

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

        //pricate fields 

        private int numberOfAttendees, numberOfDays;
        private AccomodationType accomodationChoice;
        private bool internetAccess, recCenterAccess;

        #endregion

        #region "Properties"

        // using two step process to set the properties of the above fields 
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

        // auto implamented properties 

        public string NameOfConference { get; set; }
        public decimal AccommodationCharge { get; private set; }
        public decimal OptionalServicesCharge { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TotalCharge { get; private set; }

        #endregion

        #region "Constructors"

        // constructor to instantiate Conference object

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
            const decimal accomodationDiscount = (decimal).12;
            const decimal optionalDiscount = (decimal).075;

            //so i previously had a lot 'Dicount' 'Optional Service Charge' Total Charge' ect listed here, by keeping those here, it was preventin these methods from 'setting' the properties. 
            // I removed these, only leaving Accommodation Charge and that now seems to be returning values on my form when I run the program. I still can't get the Discount to work though. 
            
            AccommodationCharge = ReturnAccomodationRate() * (numberOfAttendees * numberOfDays);
           

            if (numberOfAttendees >= 75 && numberOfDays >= 5)
            {
                //I fucked with this formula to see if that changed anything in my results but no luck. not sure if it's the const above that causing the issues :/ 
                Discount = (accomodationDiscount * AccommodationCharge) + (optionalDiscount * OptionalServicesCharge);
            }
            else
            {
                Discount = 0;
            }

            if (internetAccess == true && recCenterAccess == true)
            {
                OptionalServicesCharge = (dailyInternet + dailyRec) * (numberOfDays * numberOfAttendees);
            }
            else if (internetAccess == true)
            {
                OptionalServicesCharge = dailyInternet * (numberOfDays * numberOfAttendees);
            }
            else if (recCenterAccess == true)
            {
                OptionalServicesCharge = dailyRec * (numberOfDays * numberOfAttendees);
            }
      

            TotalCharge = AccommodationCharge + OptionalServicesCharge - Discount;

            return TotalCharge;

            #endregion
        }

    }

}


