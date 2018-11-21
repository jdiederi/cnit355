using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FpV3
{
    class TabPage : TabbedPage
    {
        public TabPage()
        {
            this.Title = "TabbedPage";
            this.Children.Add(new loginPage() { Title = "Login" });
            this.Children.Add(new ArtistInfoPage() { Title = "Artist Information" });
            this.Children.Add(new NewArtist() { Title = "New Artist" });
            this.Children.Add(new VenueInfoPage() { Title= "Venue Information"});
            this.Children.Add(new ManagerInfoPage() { Title = "Manager Information" });
            this.Children.Add(new AccountCreation() { Title = "Account Creation Page" });
        }
    }
}
