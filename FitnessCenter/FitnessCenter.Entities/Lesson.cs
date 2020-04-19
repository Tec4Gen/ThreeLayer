using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Entities
{
    public class Lesson
    {
        public int Id { get; set; }

        public int IdClinet { get; set; }

        public int IdHall { get; set; }

        public DateTime Time { get; set; }
    }
}
