using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class Sfotware_house
    {
        //[Key]
        public long S_house_Id { get; set; }

        public string Name { get; set; }

        public string Country{ get; set; }

        public List<Videogame> Videogames { get; set; }
        public Videogame videogame { get; set; }
    }
}
}
