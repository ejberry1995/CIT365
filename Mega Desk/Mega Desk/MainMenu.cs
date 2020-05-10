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
    public partial class MainMenu : Form
    {
        AddQuote addQuote = new AddQuote();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            addQuote.ShowDialog();

        }

    }
}
