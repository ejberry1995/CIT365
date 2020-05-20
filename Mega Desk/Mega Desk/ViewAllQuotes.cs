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
    public partial class ViewAllQuotes : Form
    {
        List<DeskQuote> deskQuotes;

        public ViewAllQuotes(List<DeskQuote> list)
        {
            deskQuotes = list;
            InitializeComponent();
            prepareDataGrid();
            if (list.Count > 0)
                populateDataGrid();
        }

        private void prepareDataGrid()
        {
            quoteDataGrid.Columns.Add("lastNameCol", "Last Name");
            quoteDataGrid.Columns.Add("firstNameCol", "First Name");
            quoteDataGrid.Columns.Add("materialCol","Material");
            quoteDataGrid.Columns.Add("widthCol", "Width");
            quoteDataGrid.Columns.Add("depthCol", "Depth");
            quoteDataGrid.Columns.Add("numDrawersCol", "Number of Drawers");
            quoteDataGrid.Columns.Add("productionDaysCol", "Production Days");
            quoteDataGrid.Columns.Add("quoteCol", "Desk Quote");

        }

        private void populateDataGrid()
        {
            int count = 0;
            foreach (var quote in deskQuotes)
            {
                Desk desk = quote.getDesk();
                string[] row = {quote.customer.lastName, quote.customer.firstName, 
                    desk.getMaterial(), 
                    desk.getWidth().ToString(), desk.getDepth().ToString(), 
                    desk.getNumOfDrawers().ToString(), 
                    quote.getProductionDays().ToString(),
                    quote.getQuote().ToString()}; 

                quoteDataGrid.Rows.Add(row);
                quoteDataGrid.Rows[count].HeaderCell.Value = count.ToString();

                count++;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
