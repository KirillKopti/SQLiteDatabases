using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteDatabases
{
    [Table("Friends")]
    public class Friend
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
    }
}
