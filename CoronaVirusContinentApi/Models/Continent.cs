using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaVirusContinentApi.Models
{
    public class Continent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int InfectedNo { get; }

        public int RecoveredNo { get; }

        public int DeathNo { get; }

        public DateTime RefreshDate { get; }

        [NotMapped]
        public List<Country> Countries { get; set; }
    }
}
