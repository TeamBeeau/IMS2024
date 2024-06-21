using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    [Serializable()]
    public class PackingCost
    {
        public string codePacking = "";
        
        public double PackCost = 0;
        public double STDWGT = 0;
        public PackingCost(string codePacking, double PackCost,double STDWGT) { 
            this.codePacking = codePacking;
            this.STDWGT = STDWGT;
            this.PackCost = PackCost;
        }
    }
}
