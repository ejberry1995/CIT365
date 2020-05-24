using Newtonsoft.Json;
namespace Mega_Desk
{
    public class Desk
    {
        [JsonProperty]
        private double width;

        [JsonProperty]
        private double depth;

        [JsonProperty]
        private string material;

        [JsonProperty]
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
