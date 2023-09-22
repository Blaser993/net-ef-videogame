
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    //[Table("videogame")]
    //[Index(nameof(id) IsUnique = true]
    public class Videogame
    {
        [Key]
        public long VideogameId { get; set; }

        public string Name { get; set; }

        public string? Overview { get; set; }

        public DateTime Relase_date { get; set; }


        public long S_house_Id { get; set; }
    
    }
}
