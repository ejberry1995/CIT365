using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            loadQuotesFromFile();
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

        private void loadQuotesFromFile()
        {
            try
            {
                string[] fileContents = File.ReadAllLines(Constants.quoteFilePath);

                foreach (string line in fileContents)
                {
                    DeskQuote deserializedQuote = JsonConvert.DeserializeObject<DeskQuote>(line);
                    deskQuoteList.Add(deserializedQuote);
                }
            }
            catch
            {
                MessageBox.Show($"Mega Desk: Project Quote Caluculator is uable to " +
                    $"open {Constants.quoteFilePath}. " +
                    $"The file may be missing or in the wrong format.\n" +
                    $"The program will proceed without loading saved quotes.",
                   "Error Encountered While Opening File", MessageBoxButtons.OK);

            }
        }

        private bool writeQuoteToFile(DeskQuote quote)
        {
            try
            {
                string json = JsonConvert.SerializeObject(quote);

                using (StreamWriter writetext = new StreamWriter(Constants.quoteFilePath, true))
                {
                    writetext.WriteLine(json);
                }
                return true;
            }
            catch
            {
                return false;
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

                // if writing the quote is successful, add to the list
                // else, alert the user the quote could not be saved
                if (writeQuoteToFile(addQuote.newQuote))
                    deskQuoteList.Add(addQuote.newQuote);
                else
                    MessageBox.Show("The desk quote could not be saved.",
                        "Error: Unable to save", MessageBoxButtons.OK);
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

                string[] fileContents = File.ReadAllLines(Constants.rushOrderFilePath);

                foreach (string line in fileContents)
                {
                    double item = Convert.ToDouble(line);

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
                MessageBox.Show($"An error was encountered while attempting to load {Constants.rushOrderFilePath}\n" +
                    "Either the file cannot be found or the file is in the wrong format.\n" +
                    "Default values will be loaded.",
                    "Error Encountered While Opening File", MessageBoxButtons.OK);
                rushOrderPrices = Constants.rushOrderPrices;
                return rushOrderPrices;
            }
        }

    }

}
