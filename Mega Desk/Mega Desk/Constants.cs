using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk
{
    /// <summary>
    /// Define all global constants in one place 
    /// to ease use across program and simplify
    /// the process of making changes
    /// 
    /// Ideally these should probably be in a config file
    /// but that is outside the scope of this assignment
    /// </summary>
    static class Constants
    {
        public readonly static string filePath = @"rushOrderPrices.txt";
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

        public static List<int> rushOrderOptions = new List<int>() { 3, 5, 7};

        public static readonly double[,] rushOrderPrices = { { 60, 70, 80 }, { 40, 50, 60 }, { 30, 35, 40 } };

    }

}
