using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace FpV3
{
    class Venue
    {
     //class for each Venue, Artist, Manager set up for database interactiability

        [PrimaryKey, AutoIncrement]
        public int VenueID { get; set; }

        [MaxLength(15)]
        public string VenueName { get; set; }

        [MaxLength(50)]
        public string VenueLocation { get; set; }
    }
}
