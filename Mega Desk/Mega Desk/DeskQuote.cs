using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk
{
    public class DeskQuote
    {
        private Customer customer;
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

        public int getOrderDays()
        {
            return productionDays;
        }

        public double getQuote()
        {
            double quote = 0;
            double deskSurfaceArea = desk.getSurfaceArea();

            if (deskSurfaceArea > Constants.mediumSizeLower)
                quote += deskSurfaceArea * Constants.costPerSquareInch;
            else
                quote += Constants.costPerDrawer * desk.getNumOfDrawers();

            quote += Constants.materialCost[desk.getMaterial()];

            if (productionDays > Constants.standardProduction)
            {
                if (deskSurfaceArea < Constants.mediumSizeLower)
                    quote += 0;
                else if (deskSurfaceArea > Constants.mediumSizeUpper)
                    quote += 0;
                else
                    quote += 0;
            }

            return quote;
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
