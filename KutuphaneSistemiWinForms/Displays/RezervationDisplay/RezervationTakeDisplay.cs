using KutuphaneSistemiWinForms.Controller.Factory;
using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.SystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemiWinForms.Displays.RezervationDisplay
{
    public partial class RezervationTakeDisplay : Form
    {
        public RezervationTakeDisplay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = dataGridView1;
            Book selectedBook = (Book)dataGridView1.CurrentRow.DataBoundItem;

            RezervationView rezervationView = new RezervationView();
            rezervationView.book = selectedBook;
            rezervationView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookController bookController = (BookController)ControllerFactory.createController("book");
            List<List<String>> search = getSearchParameters();

            if (search.Count != 2)
            {
                return;
            }

            List<Book> books = bookController.searchBook(search[0], search[1]).Cast<Book>().ToList();

            dataGridView1.DataSource = books;
        }

        private List<List<String>> getSearchParameters()
        {
            List<String> variableNames = new List<String>();
            List<String> searchValues = new List<String>();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text) == false)
                {
                    variableNames.Add(control.Name);
                    searchValues.Add(control.Text);
                }
            }
            List<List<String>> search = new List<List<String>>
            {
                variableNames,
                searchValues
            };

            return search;
        }
    }
}
