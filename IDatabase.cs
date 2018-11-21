using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace FpV3
{
    public interface IDatabase
    {
        SQLiteConnection ConnectToDB();
    }
}
