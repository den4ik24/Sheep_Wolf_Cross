﻿//using SQLite;

namespace Sheep_Wolf.Core.Models
{
    //[Table("Prey")]
    public class Prey
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string KillerId { get; set; }
        public string VictimId { get; set; }
        public int TypeOfKiller { get; set; }

        public Prey()
        {

        }
    }
}
