﻿using System;
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
        CashRegister kassa;
        int bookTableLen = 0;
        int gameTableLen = 0;
        int movieTableLen = 0;

        int previousId = 0;
        public MainForm()
        {
            InitializeComponent();
            database = new DB();
            kassa = new CashRegister(database.GetUnifiedList());
            BooksDataGrid.DataBindingComplete += BooksDataGrid_DataBindingComplete;
            GamesDataGrid.DataBindingComplete += GamesDataGrid_DataBindingComplete;
            MoviesDataGrid.DataBindingComplete += MoviesDataGrid_DataBindingComplete;
            KassaProdDataGrid.DataBindingComplete += KassaProdDataGrid_DataBindingComplete;
            PopulateLagerTable(database);
            PopulateKassaTable();

            BookAddButton.Click += AddBook;
            GameAddButton.Click += AddGame;
            MovieAddButton.Click += AddMovie;

            BooksDataGrid.RowLeave += DataGrid_RowLeave;
            GamesDataGrid.RowLeave += DataGrid_RowLeave;
            MoviesDataGrid.RowLeave += DataGrid_RowLeave;

            BooksDataGrid.EditingControlShowing += DataGrid_EditingControlShowing;
            GamesDataGrid.EditingControlShowing += DataGrid_EditingControlShowing;
            MoviesDataGrid.EditingControlShowing += DataGrid_EditingControlShowing;

            BooksDataGrid.CellEndEdit += DataGrid_CellEndEdit;
            GamesDataGrid.CellEndEdit += DataGrid_CellEndEdit;
            MoviesDataGrid.CellEndEdit += DataGrid_CellEndEdit;

            BooksDataGrid.CellLeave += DataGridView_CellLeave;
            GamesDataGrid.CellLeave += DataGridView_CellLeave;
            MoviesDataGrid.CellLeave += DataGridView_CellLeave;

            BookDeleteButton.Click += BookDelete_click;
            GameDeleteButton.Click += GameDelete_click;
            MovieDeleteButton.Click += MovieDelete_click;

            AddDeliveryButton.Click += AddDeliveryButton_Click;

            this.FormClosing += MainForm_FormClosing;

            KassaProdDataGrid.CellContentClick += KassaProdDataGrid_CellContentClick;

            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            BuyButton.Click += BuyButton_Click;

            SyncButton.Click += SyncButton_Click;
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            database.ReSync();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try {
                var list = kassa.Checkout();
                database.AddPurchase(list);
                MessageBox.Show("Purchase made", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            if (selectedTab == Kassa)
            {
                kassa.productList = database.GetUnifiedList();
                KassaProdDataGrid.DataSource = kassa.productList;
                
            }
            else if (selectedTab == Lager)
            {
                KassaProdDataGrid.DataSource = database.GetUnifiedList();
                kassa.ClearCart();
                UpdateTotalLabel();
            }
        }

        private void UpdateTotalLabel()
        {
            TotalPriceLabel.Text = "Totalt: " + kassa.total + " kr";
        }

        private void KassaProdDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(kassa.AddToCart(KassaProdDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString()))
            {
                CartPanel.Controls.Add(kassa.cart.Last());
                kassa.cart.Last().Dock = DockStyle.Top;
                kassa.SetDeleteCartItemFunction((item) =>
                {
                    UpdateTotalLabel();
                    CartPanel.Controls.Remove(item);
                });
                kassa.SetCountChanged(() =>
                {
                    UpdateTotalLabel();
                });
                UpdateTotalLabel();
            }
        }



        /*--------------------------------------------------------------------------------------------------------------------*/
        private void AddDeliveryButton_Click(object sender, EventArgs e)
        {
            AddDeliveryForm deliveryPopup = new AddDeliveryForm(database.GetUnifiedList().ToList<UnifiedProd>());
            var res = deliveryPopup.ShowDialog();
            if (res == DialogResult.OK) {
                Console.WriteLine("OK");
                
                database.AddDelivery(deliveryPopup.itemList);
                database.UpdateUnifiedList();
                BooksDataGrid.Refresh();
                GamesDataGrid.Refresh();
                MoviesDataGrid.Refresh();
                KassaProdDataGrid.Refresh();
            }
        }

/*--------------------------------------------------------------------------------------------------------------------*/
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (database.InvalidExcist())
            {
                DialogResult result = MessageBox.Show(
                "Invalid rows will be deleted!",
                "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            database.SaveData();
        }

/*--------------------------------------------------------------------------------------------------------------------*/
        private void BookDelete_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete the item with id: {BooksDataGrid.CurrentRow.Cells["id"].Value}?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if(result == DialogResult.Yes) {
                database.RemoveBook(BooksDataGrid.CurrentRow.Cells["id"].Value.ToString());
                ResizeGrid();
            }
        }
        private void GameDelete_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete the item with id: {GamesDataGrid.CurrentRow.Cells["id"].Value}?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                database.RemoveGame(GamesDataGrid.CurrentRow.Cells["id"].Value.ToString());
                ResizeGrid();
            }
        }
        private void MovieDelete_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete the item with id: {MoviesDataGrid.CurrentRow.Cells["id"].Value}?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                database.RemoveMovie(MoviesDataGrid.CurrentRow.Cells["id"].Value.ToString());
                ResizeGrid();
            }
        }

        /*--------------------------------------------------------------------------------------------------------------------*/

        private void DataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
 /*--------------------------------------------------------------------------------------------------------------------*/
        private void DataGrid_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0 || e.RowIndex >= dgv.Rows.Count)
                return;

            var row = dgv.Rows[e.RowIndex];
            bool res = database.Validate(row.Cells);
            
            switch (Convert.ToString(row.Cells["type"].Value)){
                case ("book"): database.bookList.FirstOrDefault(b => b.id == Convert.ToString(row.Cells["id"].Value)).isValid = res; break;
                case ("game"): database.gameList.FirstOrDefault(b => b.id == Convert.ToString(row.Cells["id"].Value)).isValid = res; break;
                case ("movie"): database.movieList.FirstOrDefault(b => b.id == Convert.ToString(row.Cells["id"].Value)).isValid = res; break;
            }
            database.UpdateUnifiedList();
            if (res)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;            
            }
            else
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
            }
        }

/*--------------------------------------------------------------------------------------------------------------------*/
        private void DataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.ColumnIndex == dgv.Columns["id"].Index)
            {
                var cellValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (int.TryParse(cellValue, out int newId))
                {
                    if (!database.IsIdAvailable(newId))
                    {
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = previousId;
                        
                    } else Console.WriteLine(database.UnReserveId(previousId.ToString()));

                }
                else dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = previousId;
            }
            else if (dgv.Columns["playtime"] != null && e.ColumnIndex == dgv.Columns["playtime"].Index && !String.IsNullOrWhiteSpace(Convert.ToString(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)))
            {
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value += " min";
            }
        }
/*--------------------------------------------------------------------------------------------------------------------*/
        private void DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress -= NumericTextBox_KeyPress;

                if (dgv.CurrentCell.ColumnIndex == dgv.Columns["price"].Index ||
                    dgv.CurrentCell.ColumnIndex == dgv.Columns["stock"].Index)
                {
                    tb.KeyPress += NumericTextBox_KeyPress;
                }
                else if(dgv.CurrentCell.ColumnIndex == dgv.Columns["id"].Index)
                {
                    tb.KeyPress += NumericTextBox_KeyPress;
                    previousId = Int32.Parse(tb.Text);
                }
                else if(dgv.Columns["playtime"] != null && dgv.CurrentCell.ColumnIndex == dgv.Columns["playtime"].Index)
                {
                    tb.KeyPress += NumericTextBox_KeyPress;
                    var substrings = tb.Text.Split(' ');
                    tb.Text = substrings[0];
                }
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

/*--------------------------------------------------------------------------------------------------------------------*/
        private void AddMovie(object sender, EventArgs e)
        {
            var newMovie = new Movie(database.GenerateUniqueId(), "", "", "", "", "0", "movie") { isValid = false};
            database.ApendMovie(newMovie);
            database.ReserveId(newMovie.id);
            ResizeGrid();
            int newRowIndex = MoviesDataGrid.Rows.Count - 1;
            MoviesDataGrid.Rows[newRowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
            MoviesDataGrid.CurrentCell = MoviesDataGrid.Rows[newRowIndex].Cells["id"];
        }
        private void AddGame(object sender, EventArgs e)
        {
            var newGame = new Game(database.GenerateUniqueId(), "", "", "", "0", "game") { isValid = false };
            database.AppendGame(newGame);
            database.ReserveId(newGame.id);
            ResizeGrid();
            int newRowIndex = GamesDataGrid.Rows.Count - 1;
            GamesDataGrid.Rows[newRowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
            GamesDataGrid.CurrentCell = GamesDataGrid.Rows[newRowIndex].Cells["id"];
        }
        private void AddBook(object sender, EventArgs e)
        {
            var newBook = new Book(database.GenerateUniqueId(), "", "", "", "", "", "", "0", "book") { isValid = false };
            database.AppendBook(newBook);
            database.ReserveId(newBook.id);
            ResizeGrid();
            int newRowIndex = BooksDataGrid.Rows.Count - 1;
            BooksDataGrid.Rows[newRowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
            BooksDataGrid.CurrentCell = BooksDataGrid.Rows[newRowIndex].Cells["id"];
        }

/*--------------------------------------------------------------------------------------------------------------------*/

        private void PopulateLagerTable(DB database)
        {

            BooksDataGrid.DataSource = database.bookList;
            GamesDataGrid.DataSource = database.gameList;
            MoviesDataGrid.DataSource = database.movieList;

            ResizeGrid();
        }
        private void PopulateKassaTable()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "ActionColumn";
            buttonColumn.HeaderText = "";
            buttonColumn.Text = "Lägg till";
            buttonColumn.UseColumnTextForButtonValue = true;
            KassaProdDataGrid.Columns.Add(buttonColumn);
        }

        private void MoviesDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dgv = (DataGridView)sender;

            dgv.Columns["id"].DisplayIndex = 0;
            dgv.Columns["name"].DisplayIndex = 1;
            dgv.Columns["price"].DisplayIndex = 2;
            dgv.Columns["format"].DisplayIndex = 3;
            dgv.Columns["playtime"].DisplayIndex = 4;
            dgv.Columns["stock"].DisplayIndex = 5;
            dgv.Columns["type"].Visible = false;
            dgv.Columns["isValid"].Visible = false;
        }

        private void GamesDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dgv = (DataGridView)sender;

            dgv.Columns["id"].DisplayIndex = 0;
            dgv.Columns["name"].DisplayIndex = 1;
            dgv.Columns["price"].DisplayIndex = 2;
            dgv.Columns["platform"].DisplayIndex = 3;
            dgv.Columns["stock"].DisplayIndex = 4;
            dgv.Columns["type"].Visible = false;
            dgv.Columns["isValid"].Visible = false;
        }

        private void BooksDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dgv = (DataGridView)sender;

            dgv.Columns["id"].DisplayIndex = 0;
            dgv.Columns["name"].DisplayIndex = 1;
            dgv.Columns["price"].DisplayIndex = 2;
            dgv.Columns["author"].DisplayIndex = 3;
            dgv.Columns["genre"].DisplayIndex = 4;
            dgv.Columns["format"].DisplayIndex = 5;
            dgv.Columns["language"].DisplayIndex = 6;
            dgv.Columns["stock"].DisplayIndex = 7;
            dgv.Columns["type"].Visible = false;
            dgv.Columns["isValid"].Visible = false;
        }

        private void KassaProdDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dgv = (DataGridView)sender;

            dgv.Columns["id"].DisplayIndex = 0;
            dgv.Columns["name"].DisplayIndex = 1;
            dgv.Columns["price"].DisplayIndex = 2;
            dgv.Columns["stock"].DisplayIndex = 3;
            dgv.Columns["author"].Visible = false;
            dgv.Columns["genre"].Visible = false;
            dgv.Columns["format"].Visible = false;
            dgv.Columns["language"].Visible = false;
            dgv.Columns["playtime"].Visible = false;
            dgv.Columns["platform"].Visible = false;
            dgv.Columns["type"].Visible = false;
        }

        private void ResizeGrid()
        {
            int totalHeightBooks = BooksDataGrid.ColumnHeadersHeight;
            int totalHeightGames = GamesDataGrid.ColumnHeadersHeight;
            int totalHeightMovies = MoviesDataGrid.ColumnHeadersHeight;

            foreach (DataGridViewRow row in BooksDataGrid.Rows) {totalHeightBooks += row.Height;}
            foreach (DataGridViewRow row in GamesDataGrid.Rows) { totalHeightGames += row.Height; }
            foreach (DataGridViewRow row in MoviesDataGrid.Rows) { totalHeightMovies += row.Height; }

            int margin = 2;
            BookPanel.Height = totalHeightBooks + margin;
            GamePanel.Height = totalHeightGames +margin;
            MoviePanel.Height = totalHeightMovies +margin;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
