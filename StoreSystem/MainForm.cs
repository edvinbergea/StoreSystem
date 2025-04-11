using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSystem
{
    public partial class MainForm : Form
    {
        DB database;
        int bookTableLen = 0;
        int gameTableLen = 0;
        int movieTableLen = 0;
        public MainForm()
        {
            InitializeComponent();
            database = new DB();
            PopulateLagerTable(database);
        }

        private void PopulateLagerTable(DB database)
        {
            BooksDataGrid.DataSource = database.bookList;
            GamesDataGrid.DataSource = database.gameList;
            MoviesDataGrid.DataSource = database.movieList;
            ResizeGrid();
        }
        
        private void ResizeGrid()
        {
            int totalHeightBooks = BooksDataGrid.ColumnHeadersHeight;
            int totalHeightGames = GamesDataGrid.ColumnHeadersHeight;
            int totalHeightMovies = MoviesDataGrid.ColumnHeadersHeight;

            foreach (DataGridViewRow row in BooksDataGrid.Rows) {totalHeightBooks += row.Height;}
            foreach (DataGridViewRow row in GamesDataGrid.Rows) { totalHeightGames += row.Height; }
            foreach (DataGridViewRow row in MoviesDataGrid.Rows) { totalHeightMovies += row.Height; }

            BooksDataGrid.Height = totalHeightBooks;
            GamesDataGrid.Height = totalHeightGames;
            MoviesDataGrid.Height = totalHeightMovies;
        }
    }
}
