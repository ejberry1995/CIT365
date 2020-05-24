using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk
{
    public class DeskQuote
    {
        public Customer customer;
        int productionDays;
        Desk desk;

        public void setDesk(double width, double depth, string material, int numDrawers)
        {
            desk = new Desk(width, depth, material, numDrawers);
        }

        public Desk getDesk()
        {
            return desk;
        }

        public void setCustomer(string first, string last)
        {
            customer.firstName = first;
            customer.lastName = last;
        }

        public string getCustomer()
        {
            return customer.lastName + ", " + customer.firstName; 
        }

        public void setOrderDays(int d) 
        {
            productionDays = d;
        }

        public int getProductionDays()
        {
            return productionDays;
        }

        public double getQuote()
        {
            double quote = Constants.baseDeskPrice;

            double deskSurfaceArea = desk.getSurfaceArea();

            if (deskSurfaceArea > Constants.mediumSizeLower)
                quote += deskSurfaceArea * Constants.costPerSquareInch;
                
            quote += Constants.costPerDrawer * desk.getNumOfDrawers();

            quote += Constants.materialCost[desk.getMaterial()];

            if (productionDays < Constants.standardProduction)
            {
                quote += getRushOrder(deskSurfaceArea);
            }

            return quote;
        }

        public double getRushOrder(double deskSurfaceArea)
        {
            double rushCost;
            try
            {
                int rushIndex = Constants.rushOrderOptions.IndexOf(productionDays);
                int sizeIndex;

                if (deskSurfaceArea > Constants.mediumSizeUpper)
                    sizeIndex = 2;
                else if (deskSurfaceArea <= Constants.mediumSizeUpper
                        && deskSurfaceArea >= Constants.mediumSizeLower)
                    sizeIndex = 1;
                else
                    sizeIndex = 0;

                rushCost = Constants.rushOrderPrices[rushIndex, sizeIndex];
            }
            catch
            {
                return 0;
            }

            return rushCost;
        }
    }

    public struct Customer
    {
        public string firstName;
        public string lastName;

        public Customer(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
    }
}
