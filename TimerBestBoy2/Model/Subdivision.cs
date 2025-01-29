using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerBestBoy2.Model
{
    class Subdivision
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int? SupervisorId { get; set; }

        public string Name { get; set; } = null!;
    }
}
