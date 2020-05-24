using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Color pallet: https://coolors.co/f2c600-db3a34-084c61-177e89-393e41-d3d0cb

namespace Mega_Desk
{
    public partial class MainMenu : Form
    {
        public AddQuote addQuote;
        public DisplayQuote displayQuote;
        public ViewAllQuotes viewAllQuotes;

        List<DeskQuote> deskQuoteList = new List<DeskQuote>();
        public double[,] rushOrderPrices;

        public MainMenu()
        {
            rushOrderPrices = loadRushOrderPrices();
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            exitConfirmation(e);
        }

        private void exitConfirmation(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit Mega Desk: Project Quote Calculator?",
                "Exit?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void newQuoteButton_Click(object sender, EventArgs e)
        {
            addQuote = new AddQuote();
            addQuote.ShowDialog();

            if (addQuote.newQuote != null)
            {
                displayQuote = new DisplayQuote(addQuote.newQuote);
                displayQuote.ShowDialog();
                deskQuoteList.Add(addQuote.newQuote);
            }
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            viewAllQuotes = new ViewAllQuotes(deskQuoteList,true);
            viewAllQuotes.ShowDialog();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            viewAllQuotes = new ViewAllQuotes(deskQuoteList);
            viewAllQuotes.ShowDialog();
        }

        public double[,] loadRushOrderPrices()
        { 
            try
            {
                int sizeCountMax = 2;
                int optionCountMax = Constants.rushOrderOptions.Count - 1;
                int sizeCount = 0;
                int optionCount = 0;

                double[,] rushOrderPrices = new double[optionCountMax + 1, Constants.rushOrderOptions.Count];

                string[] fileContents = File.ReadAllLines(Constants.filePath);

                foreach (string s in fileContents)
                {
                    double item = Convert.ToDouble(s);

                    if (optionCount < optionCountMax)
                    {
                        rushOrderPrices[optionCount, sizeCount] = item;
                        sizeCount++;

                        if (sizeCount > sizeCountMax)
                        {
                            sizeCount = 0;
                            optionCount++;
                        }
                    }

                }

                return rushOrderPrices;
            }
            catch
            {
                // show error message and return a default version of the costs
                MessageBox.Show($"An error was encountered while attempting to load {Constants.filePath}\n" +
                    "Either the file cannot be found or the file is in the wrong format.\n" +
                    "Default values will be loaded.",
                    "Error Loading File", MessageBoxButtons.OK);
                rushOrderPrices = Constants.rushOrderPrices;
                return rushOrderPrices;
            }
        }

    }

}
