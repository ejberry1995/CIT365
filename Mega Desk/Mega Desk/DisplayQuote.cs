using System;
using System.Windows.Forms;

namespace Mega_Desk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            Desk desk = deskQuote.getDesk();

            customerLabel.Text += deskQuote.getCustomer();
            widthLabel.Text += desk.getWidth();
            depthLabel.Text += desk.getDepth();
            drawersLabel.Text += desk.getNumOfDrawers();
            materialLabel.Text += desk.getMaterial();
            daysLabel.Text += deskQuote.getProductionDays();
            quoteLable.Text += deskQuote.getQuote();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
