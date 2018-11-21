using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

//using System.ComponentModel;
//using System.Runtime.CompilerServices;
namespace FpV3
{
    class Artist //: INotifyPropertyChanged //class names become table names by default. Can be specified differently
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement] //sql properties
        public int ArtistID { get; set; } //property names become column names by default. Column names can be specified to be different. 

        [MaxLength(15)]
        public string ArtistName { get; set; }

        [MaxLength(50)]
        public string ArtistGenre { get; set; }

        //[MaxLength(15)]
        //public string ArtistGender { get; set; }

        //[MaxLength(15)]
        //public string ArtistDOB { get; set; }

        //[MaxLength(15)]
        //public string ArtistAddress { get; set; }

        //[MaxLength(15)]
        //public string ArtistPhoneNum { get; set; }

        //[MaxLength(15)]
        //public string ArtistEmail { get; set; }

        //[PrimaryKey, AutoIncrement]
        //public int ArtistID
        //{
        //    get
        //    {
        //        return ArtistID;
        //    }
        //    set
        //    {
        //        ArtistID = value;
        //        OnPropertyChanged("ArtistID"); //this invokes the OnPropertyChanged method.
        //    }
        //}
        //public string Description
        //{
        //    get
        //    {
        //        return description;
        //    }
        //    set
        //    {
        //        description = value;
        //        OnPropertyChanged("Description"); //this invokes the OnPropertyChanged method.
        //    }

        //void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}


    }
}
