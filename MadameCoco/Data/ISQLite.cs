using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MadameCoco.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
