using GraphX.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimerBestBoy2.Model
{
    public class OrgVertex: VertexBase
    {
        public string Name { get; set; }
        public OrgVertex(string name)
        {
            Name = name;
        }
        public override string ToString() =>Name;
    }
}
