using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public MainMenu()
        {
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
            viewAllQuotes = new ViewAllQuotes(deskQuoteList);
            viewAllQuotes.ShowDialog();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            viewAllQuotes = new ViewAllQuotes(deskQuoteList);
            viewAllQuotes.ShowDialog();
        }

    }
}
