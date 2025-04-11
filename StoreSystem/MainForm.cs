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
            foreach (var product in database.productList)
            {
                switch (product.type)
                {
                    case ("book"):
                        bookTableLen = BookTable.RowCount++;
                        BookTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                        Console.WriteLine(bookTableLen);
                        AddBook(product);
                        break;
                    case ("game"):
                        gameTableLen = GameTable.RowCount++;
                        GameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                        AddGame(product);
                        break;
                    case ("movie"):
                        movieTableLen = MovieTable.RowCount++;
                        MovieTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                        AddMovie(product);
                        break;
                }
            }
        }

        private void AddMovie(Product product)
        {
            Movie movie = (Movie)product;
            List<Label> labels = new List<Label>();
            for (int i = 0; i < MovieTable.ColumnCount; i++)
            {
                labels.Add(new Label());
                labels[i].Dock = DockStyle.Fill;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].AutoSize = true;
            }
            MovieTable.Controls.Add(labels[0], 0, movieTableLen);
            labels[0].Text = movie.id.ToString();
            MovieTable.Controls.Add(labels[1], 1, movieTableLen);
            labels[1].Text = movie.name;
            MovieTable.Controls.Add(labels[2], 2, movieTableLen);
            labels[2].Text = movie.price.ToString();
            MovieTable.Controls.Add(labels[3], 3, movieTableLen);
            labels[3].Text = movie.format;
            MovieTable.Controls.Add(labels[4], 4, movieTableLen);
            labels[4].Text = movie.playtime;
            MovieTable.Controls.Add(labels[5], 5, movieTableLen);
            labels[5].Text = movie.quantity.ToString();
        }

        private void AddGame(Product product)
        {
            Game game = (Game)product;
            List<Label> labels = new List<Label>();
            for (int i = 0; i < GameTable.ColumnCount; i++) {
                labels.Add(new Label());
                labels[i].Dock = DockStyle.Fill;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].AutoSize = true;
            }
            GameTable.Controls.Add(labels[0], 0, gameTableLen);
            labels[0].Text = game.id.ToString();
            GameTable.Controls.Add(labels[1], 1, gameTableLen);
            labels[1].Text = game.name;
            GameTable.Controls.Add(labels[2], 2, gameTableLen);
            labels[2].Text = game.price.ToString();
            GameTable.Controls.Add(labels[3], 3, gameTableLen);
            labels[3].Text = game.platform;
            GameTable.Controls.Add(labels[4], 4, gameTableLen);
            labels[4].Text = game.quantity.ToString();
        }

        private void AddBook(Product product)
        {
            Book book = (Book)product;
            List<Label> labels = new List<Label>();
            for (int i = 0; i < BookTable.ColumnCount; i++) {
                labels.Add(new Label());
                labels[i].Dock = DockStyle.Fill;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].AutoSize = true;
            }
            BookTable.Controls.Add(labels[0], 0, bookTableLen);
            labels[0].Text = book.id.ToString();
            BookTable.Controls.Add(labels[1], 1, bookTableLen);
            labels[1].Text = book.name;
            BookTable.Controls.Add(labels[2], 2, bookTableLen);
            labels[2].Text = book.price.ToString();
            BookTable.Controls.Add(labels[3], 3, bookTableLen);
            labels[3].Text = book.author;
            BookTable.Controls.Add(labels[4], 4, bookTableLen);
            labels[4].Text = book.genre;
            BookTable.Controls.Add(labels[5], 5, bookTableLen);
            labels[5].Text = book.format;
            BookTable.Controls.Add(labels[6], 6, bookTableLen);
            labels[6].Text = book.language;
            BookTable.Controls.Add(labels[7], 7, bookTableLen);
            labels[7].Text = book.quantity.ToString();

        }
    }
}
