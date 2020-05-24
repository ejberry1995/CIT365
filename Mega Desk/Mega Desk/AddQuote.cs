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
    public partial class AddQuote : Form
    {
        public DeskQuote newQuote;

        List<string> materialsList = new List<string>();
        List<string> rushOptionsList = new List<string>();

        public AddQuote()
        {
            InitializeComponent();
            newQuote = null;

            populateSelectionBoxes();

        }

        private void populateSelectionBoxes()
        {
            // simplify the input of the width and depth 
            // by defaulting the values to the minimum
            widthBox.Value = (decimal)Constants.minWidth;
            depthBox.Value = (decimal)Constants.minDepth;

            //get the materials from the material/cost dictionary 
            //and store them in a list for simpilier access in the ListBox
            int count = 0;
            foreach (string item in Constants.materialCost.Keys)
            {
                materialsList.Add(Constants.materialCost.Keys.ElementAt(count));
                count++;
            }
            //populate the ListBoxes with values from the cooresponding lists
            materialListBox.DataSource = materialsList;

            foreach (int item in Constants.rushOrderOptions)
                rushOptionsList.Add(item.ToString() + " days");
            
            rushOptionsListBox.DataSource = rushOptionsList;

            standardOrderRadio.Text += "(" + Constants.standardProduction + " days)";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you cancel this quote?",
                "Cancel?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            bool firstNameValid = checkFirstName();
            bool lastNameValid = checkLastName();
            bool widthValid = checkWidth();
            bool depthValid = checkDepth();
            bool numDrawersValid = checkNumDrawers();

            if ( firstNameValid && lastNameValid &&
                 widthValid && depthValid && numDrawersValid)
            {
                if(MessageBox.Show("Quote Ready to be calculated. Continue?",
                    "Calculate quote?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    createDeskQuote();
                    Close();
                }
            }
        }

        private bool checkFirstName()
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text))
            {
                firstNameErrorProvider.SetError(this.firstNameBox, "First name is required.");
                return false;
            }
            else
            {
                firstNameErrorProvider.SetError(this.firstNameBox, String.Empty);
                return true;
            }  
        }

        private bool checkLastName()
        {
            if (string.IsNullOrWhiteSpace(lastNameBox.Text))
            {
                lastNameErrorProvider.SetError(this.lastNameBox, "Last name is required.");
                return false;
            }
            else
            {
                lastNameErrorProvider.SetError(this.lastNameBox, String.Empty);
                return true;
            }
        }

        private bool checkWidth()
        {
            if ((double)widthBox.Value < Constants.minWidth)
            {
                widthErrorProvider.SetError(this.widthBox, 
                    $"Width must be greater than or equal to {Constants.minWidth}");
                return false;
            }
            else if ((double)widthBox.Value > Constants.maxWidth)
            {
                widthErrorProvider.SetError(this.widthBox, 
                    $"Width must be less than or equal to {Constants.maxWidth}");
                return false;
            }
            else
            {
                widthErrorProvider.SetError(this.widthBox, String.Empty);
                return true;
            }
        }

        private bool checkDepth()
        {
            if ((double)depthBox.Value < Constants.minDepth)
            {
                widthErrorProvider.SetError(this.depthBox,
                    $"Depth must be greater than or equal to {Constants.minDepth}");
                return false;
            }
            else if ((double)depthBox.Value > Constants.maxDepth)
            {
                widthErrorProvider.SetError(depthBox,
                    $"Depth must be less than or equal to {Constants.maxDepth}");
                return false;
            }
            else
            {
                widthErrorProvider.SetError(depthBox, String.Empty);
                return true;
            }
        }

        private bool checkNumDrawers()
        {
            if ((int)numDrawersUpDown.Value < 0)
            {
                numDrawersErrorProvider.SetError(numDrawersUpDown,
                    "Number of drawers cannot be less that 0");
                return false;
            }
            else if ((int)numDrawersUpDown.Value > Constants.maxNumOfDrawers)
            {
                numDrawersErrorProvider.SetError(numDrawersUpDown,
                    $"Number of drawers cannot be more than {Constants.maxNumOfDrawers}");
                return false;
            }
            else 
            {
                numDrawersErrorProvider.SetError(numDrawersUpDown, String.Empty);
                return true;
            }
        }

        private void createDeskQuote()
        {
            newQuote = new DeskQuote();

            newQuote.setDesk((double)widthBox.Value, (double)depthBox.Value,
                getMaterialSelection(), (int)numDrawersUpDown.Value);
            newQuote.setCustomer(firstNameBox.Text, lastNameBox.Text);
            newQuote.setOrderDays(getDaysSelection());
        }

        private int getDaysSelection() 
        {
            if (standardOrderRadio.Checked == true)
                return Constants.standardProduction;
            else
            {
               string selection = rushOptionsListBox.SelectedItem.ToString();
                return int.Parse(selection[0].ToString());
            }
        }

        private string getMaterialSelection()
        {
            return materialListBox.SelectedItem.ToString();
        }

        private void widthBox_Leave(object sender, EventArgs e)
        {
            checkWidth();
        }

        private void depthBox_Leave(object sender, EventArgs e)
        {
            checkDepth();
        }

        private void numDrawersUpDown_Leave(object sender, EventArgs e)
        {
            checkNumDrawers();
        }

        private void firstNameBox_Leave(object sender, EventArgs e)
        {
            checkFirstName();
        }

        private void lastNameBox_Leave(object sender, EventArgs e)
        {
            checkLastName();
        }

        private void rushOrderRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rushOrderRadio.Checked == true)
                rushOptionsListBox.Enabled = true;
            else
                rushOptionsListBox.Enabled = false;
        }
    }
}
