using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FpV3
{
        public class AccountCreation : ContentPage
        {
            public AccountCreation()
            {
                Entry firstEntry = new Entry
                {
                    Placeholder = "*First Name:"
                };

                Entry lastEntry = new Entry
                {
                    Placeholder = "*Last Name:"
                };

                Entry venueName = new Entry
                {
                    Placeholder = "Venue Name"
                };

                Entry billingAddress = new Entry
                {
                    Placeholder = "Billing Adress: "
                };

                Entry cardEntry = new Entry
                {
                    Placeholder = "Card #: "
                };

                Entry cvEntry = new Entry
                {
                    Placeholder = "CV"
                };

                Entry expEntry = new Entry
                {
                    Placeholder = "Exp Date: "
                };
            }
        }
    }