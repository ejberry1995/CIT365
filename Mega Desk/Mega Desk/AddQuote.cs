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

        public AddQuote()
        {
            InitializeComponent();
            newQuote = null;

            radioMaterial0.Text = Constants.materialCost.Keys.ElementAt(0);
            radioMaterial1.Text = Constants.materialCost.Keys.ElementAt(1);
            radioMaterial2.Text = Constants.materialCost.Keys.ElementAt(2);
            radioMaterial3.Text = Constants.materialCost.Keys.ElementAt(3);
            radioMaterial4.Text = Constants.materialCost.Keys.ElementAt(4);

            widthBox.Value = (decimal)Constants.minWidth;
            depthBox.Value = (decimal)Constants.minDepth;
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
            if (radioRush3.Checked == true)
            {
                return 3;
            }
            else if (radioRush5.Checked == true)
            {
                return 5;
            }
            else if (radioRush7.Checked == true)
            {
                return 7;
            }
            else
                return Constants.standardProduction;
        }

        private string getMaterialSelection()
        {
            if (this.radioMaterial0.Checked == true)
            {
                return Constants.materialCost.Keys.ElementAt(0);
            }
            else if (this.radioMaterial1.Checked == true)
            {
                return Constants.materialCost.Keys.ElementAt(1);
            }
            else if (this.radioMaterial2.Checked == true)
            {
                return Constants.materialCost.Keys.ElementAt(2);
            }
            else if (this.radioMaterial3.Checked == true)
            {
                return Constants.materialCost.Keys.ElementAt(3);
            }
            else if (this.radioMaterial4.Checked == true)
            {
                return Constants.materialCost.Keys.ElementAt(4);
            }

            return "unknown";
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
    }
}
