using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerBestBoy2.Model
{
    public class Education
    {
        public int Id { get; set; }

        public DateOnly DateStart { get; set; }

        public DateOnly DateEnd { get; set; }

        public int ClassificationId { get; set; }

        public string? Description { get; set; }
    }
}
