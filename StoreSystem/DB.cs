using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace StoreSystem
{
    internal class DB
    {
        public BindingList<Book> bookList;
        public BindingList<Game> gameList;
        public BindingList<Movie> movieList;
        public HashSet<int> occupiedIds;   

        public int uniqueId = 0;

        public DB() {
            bookList = new BindingList<Book>();
            gameList = new BindingList<Game>();
            movieList = new BindingList<Movie>();
            occupiedIds = new HashSet<int>();

            FillList();
        }

        public void SaveData()
        {
            using (var writer = new StreamWriter("..\\..\\Resources\\test.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(bookList);
                    csv.WriteRecords(gameList);
                    csv.WriteRecords(movieList);
                }
            }
        }

        public void AppendBook(Book book)
        {
            bookList.Add(book);
            occupiedIds.Add(Int32.Parse(book.id));
        }

        public void AppendGame(Game game)
        {
            gameList.Add(game);
            occupiedIds.Add(Int32.Parse(game.id));
        }

        public void ApendMovie(Movie movie)
        {
            movieList.Add(movie);
            occupiedIds.Add(Int32.Parse(movie.id));
        }

        public void RemoveBook(string id)
        {
            Book book = bookList.FirstOrDefault(b => b.id == id);
            if (book != null)
            {
                bookList.Remove(book);
                occupiedIds.Remove(Int32.Parse(id));
            }
        }

        public void RemoveGame(string id)
        {
            Game game = gameList.FirstOrDefault(g => g.id == id);
            if (game != null)
            {
                gameList.Remove(game);
                occupiedIds.Remove(Int32.Parse(id));
            }
        }
        public void RemoveMovie(string id)
        {
            Movie movie = movieList.FirstOrDefault(m => m.id == id);
            if (movie != null)
            {
                movieList.Remove(movie);
                occupiedIds.Remove(Int32.Parse(id));
            }
        }

        public string GenerateUniqueId()
        {
            if (IsIdAvailable(uniqueId)) return uniqueId.ToString();
            else
            {
                uniqueId++;
                return GenerateUniqueId();
            }
        }

        public void ReserveId(string id)
        {
            if (occupiedIds.Contains(Int32.Parse(id))) return;
            else occupiedIds.Add(Int32.Parse(id));
        }
        public bool IsIdAvailable(int a)
        {
            if (occupiedIds.Contains(a)) return false;
            else return true;
        }

        public bool Validate(DataGridViewCellCollection dgvcc)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(dgvcc["id"].Value))) return false;
            if (string.IsNullOrWhiteSpace(Convert.ToString(dgvcc["name"].Value))) return false;
            if (string.IsNullOrWhiteSpace(Convert.ToString(dgvcc["price"].Value))) return false;
            if (string.IsNullOrWhiteSpace(Convert.ToString(dgvcc["quantity"].Value))) return false;
            return true;
        }

        private void FillList()
        {
            using (var reader = new StreamReader("..\\..\\Resources\\database.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var rows = csv.GetRecords<dynamic>();

                    foreach (var row in rows)
                    {
                        string type = row.type;

                        Product product;
                        switch (type)
                        {
                            case ("book"): 
                                product = new Book(row.id, row.name, row.price, row.author, row.genre, row.format, row.language, row.quantity, row.type);
                                bookList.Add((Book)product);
                                break;
                            case ("game"): 
                                product = new Game(row.id, row.name, row.price, row.platform, row.quantity, row.type); 
                                gameList.Add((Game)product);
                                break;
                            case ("movie"): 
                                product = new Movie(row.id, row.name, row.price, row.format, row.play_time, row.quantity, row.type); 
                                movieList.Add((Movie)product);
                                break;
                        };
                        if (Int32.Parse(row.id) == uniqueId) uniqueId++;
                        occupiedIds.Add(Int32.Parse(row.id));
                    }
                }
            }
        }
    }
}
