using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk
{
    class Desk
    {
        private double width;
        private double depth;
        private string material;
        private int numberOfDrawers;

        // Non-default constructor
        public Desk(double w,double d,string m,int n)
        {
            width = w;
            depth = d;
            material = m;
            numberOfDrawers = n;
        }

        public void setWidth(double w) 
        {
            width = w;
        }

        public double getWidth()
        {
            return width;
        }

        public void setDepth(double d)
        {
            depth = d;
        }

        public double getDepth()
        {
            return depth;
        }

        public void setNumOfDrawers(int n)
        {
            numberOfDrawers = n;
        }

        public int getNumOfDrawers()
        {
            return numberOfDrawers;
        }

        public void setMaterial(string s)
        {
            material = s;
        }

        public string getMaterial()
        {
            return material;
        }

        public double getSurfaceArea()
        {
            return width * depth;
        }

    }
}
