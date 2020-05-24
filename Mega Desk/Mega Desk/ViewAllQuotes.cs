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
        public SearchQuotes searchQuotes;

        List<DeskQuote> deskQuotes;

        public ViewAllQuotes(List<DeskQuote> list, bool initiateSearch = false)
        {
            InitializeComponent();

            deskQuotes = list;
            prepareDataGrid();

            if (list.Count > 0)
            {
                if (initiateSearch)
                {
                    string searchCriteria = openSearchDialog();
                    populateDataGrid(searchCriteria);
                }
                else
                    populateDataGrid();
            }
            else
                MessageBox.Show("No desk quotes are available display.\nDesk quotes will be viewable here after they are added.",
                    "No quotes loaded", MessageBoxButtons.OK);

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

        private void populateDataGrid(string searchMaterial)
        {
            int count = 0;
            foreach (var quote in deskQuotes)
            {
                Desk desk = quote.getDesk();
                if (desk.getMaterial() == searchMaterial)
                {
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
        }

        private string openSearchDialog()
        {
            if (deskQuotes.Count > 0)
            {
                searchQuotes = new SearchQuotes();

                searchQuotes.ShowDialog();

                string searchCriteria = searchQuotes.criteria;

                return searchCriteria;
            }
            else
            {
                MessageBox.Show("No desk quotes are available to search.", 
                    "No quotes loaded", MessageBoxButtons.OK);
                return "null";
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = openSearchDialog();

            if (searchCriteria != "null")
            {
                resetDataGrid();
                populateDataGrid(searchCriteria);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetDataGrid();
            populateDataGrid();
        }

        private void resetDataGrid() 
        {
            while (quoteDataGrid.Rows.Count > 0)
            {
                quoteDataGrid.Rows.RemoveAt(0);
            }
        }
    }
}
