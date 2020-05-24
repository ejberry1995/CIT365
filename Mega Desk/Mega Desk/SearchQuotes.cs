using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk
{
    public partial class SearchQuotes : Form
    {
        public string criteria;
        List<string> materialsList = new List<string>();

        public SearchQuotes()
        {
            InitializeComponent();

            //get the materials from the material/cost dictionary 
            //and store them in a list for simpilier access in the ListBox
            int count = 0;
            foreach (string item in Constants.materialCost.Keys)
            {
                materialsList.Add(Constants.materialCost.Keys.ElementAt(count));
                count++;
            }
            //populate the materials ListBox with values from the list
            materialListBox.DataSource = materialsList;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            criteria = "null";
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            criteria = materialListBox.SelectedItem.ToString();
            Close();
        }
    }
}
