using GraphX.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerBestBoy2.Model
{
    public class OrgEdge: EdgeBase<OrgVertex>
    {
        public OrgEdge(OrgVertex source, OrgVertex target) : base(source, target)
        {

        }
    }
}
