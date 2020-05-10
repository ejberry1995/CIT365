using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk
{
    static class Constants
    {
        public const double minWidth = 24;
        public const double maxWidth = 96;
        public const double minDepth = 12;
        public const double maxDepth = 48;

        public const double maxNumOfDrawers = 7;

        public static Dictionary<string, double> materialCost = new Dictionary<string, double> 
           {{"laminate", 100},
            {"oak", 200},
            {"pine", 50},
            {"rosewood", 300},
            {"veneer", 125}
            };

        public const int standardProduction = 14;

        public const double baseDeskPrice = 200;
        public const double costPerSquareInch = 1;
        public const double costPerDrawer = 50;

        public const double mediumSizeLower = 1000;
        public const double mediumSizeUpper = 2000;

    }
}
