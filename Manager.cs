using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace FpV3
{
    class Manager
    {
        [PrimaryKey, AutoIncrement]
        public int ManagerID { get; set; }

        [MaxLength(15)]
        public string ManagerName { get; set; }

        [MaxLength(50)]
        public string ArtistManaged { get; set; }

        [MaxLength(15)]
        public string ArtistID { get; set; } //get this from a different table tho??
    }
}
