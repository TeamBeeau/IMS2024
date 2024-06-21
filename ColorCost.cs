using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    [Serializable()]
    public class ColorCost
    {
        public string Color = "";
        public double FixedCost = 0;
        public double CommissionCost = 0;
        public double Transportation = 0;
        public double VariableCost = 0;
        public double OtherCost = 0;
        public ColorCost(string Color, double VariableCost, double FixedCost, double Transportation, double OtherCost ) { 
            this.Color = Color;
            this.FixedCost = FixedCost;
            this.VariableCost = VariableCost;
            this.Transportation = Transportation;
            this.OtherCost = OtherCost;
        }
    }
}
