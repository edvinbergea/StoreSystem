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
        BindingList<UnifiedProd> unifiedList = new BindingList<UnifiedProd>();

        public int uniqueId = 0;

        public DB() {
            bookList = new BindingList<Book>();
            gameList = new BindingList<Game>();
            movieList = new BindingList<Movie>();
            occupiedIds = new HashSet<int>();

            FillList();
        }

        public void UpdateUnifiedList()
        {
            Console.WriteLine("updating unified list");
            
            foreach (var prod in bookList) { Console.WriteLine("Booklist: " + prod.name.ToString() + " " + prod.isValid.ToString()); }
            unifiedList.Clear();
            foreach (var item in bookList)
            {
                if (item.isValid) unifiedList.Add(new UnifiedProd(item.id, item.name, item.price, item.author, item.genre, item.format, item.language, " ", " ", item.quantity, item.type));
            }
            foreach (var item in gameList)
            {
                if (item.isValid) unifiedList.Add(new UnifiedProd(item.id, item.name, item.price, " ", " ", " ", " ", item.platform, " ", item.quantity, item.type));
            }
            foreach (var item in movieList)
            {
                if (item.isValid) unifiedList.Add(new UnifiedProd(item.id, item.name, item.price, " ", " ", item.format, " ", " ", item.playtime, item.quantity, item.type));
            }
            foreach (var prod in unifiedList) { Console.WriteLine("Unified: " + prod.name.ToString()); }
        }

        public BindingList<UnifiedProd> GetUnifiedList() { return unifiedList; }
        
        public void SaveData()
        {
            foreach (var prod in unifiedList) { Console.WriteLine(prod.name); }
            using (var writer = new StreamWriter("..\\..\\Resources\\database.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<UnifiedMap>();
                    csv.WriteRecords(unifiedList);
                }
            }
        }

        public bool InvalidExcist()
        {
            foreach (var item in bookList)
            {
                if (!item.isValid) return true;
            }
            foreach (var item in gameList)
            {
                if (!item.isValid) return true;
            }
            foreach (var item in movieList)
            {
                if (!item.isValid) return true;
            }
            return false;
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
                        switch (type)
                        {
                            case ("book"): 
                                bookList.Add(new Book(row.id, row.name, row.price, row.author, row.genre, row.format, row.language, row.quantity, row.type));
                                break;
                            case ("game"): 
                                gameList.Add(new Game(row.id, row.name, row.price, row.platform, row.quantity, row.type));
                                break;
                            case ("movie"): 
                                movieList.Add(new Movie(row.id, row.name, row.price, row.format, row.playtime, row.quantity, row.type));
                                break;
                        };
                        if (Int32.Parse(row.id) == uniqueId) uniqueId++;
                        occupiedIds.Add(Int32.Parse(row.id));
                    }
                }
            }
        }

        internal void AddDelivery(List<ListItemAddDelivery> itemList)
        {
            foreach (ListItemAddDelivery item in itemList) {
                switch (item.itemType)
                {
                    case ("book"):
                        Book book = bookList.FirstOrDefault(b => b.id == item.GetId());
                        if (book != null)
                        {
                            book.quantity = (Int32.Parse(book.quantity) + Int32.Parse(item.GetCount())).ToString();
                        }
                        break;
                    case ("game"):
                        Game game = gameList.FirstOrDefault(g => g.id == item.GetId());
                        if (game != null)
                        {
                            game.quantity = (Int32.Parse(game.quantity) + Int32.Parse(item.GetCount())).ToString();
                        }
                        break;
                    case ("movie"):
                        Movie movie = movieList.FirstOrDefault(m => m.id == item.GetId());
                        if (movie != null)
                        {
                            movie.quantity = (Int32.Parse(movie.quantity) + Int32.Parse(item.GetCount())).ToString();
                        }
                        break;
                };
            }
        }

        public void AddPurchase(List<UnifiedProd> prodList) {
            foreach(UnifiedProd item in prodList)
            {
                switch (item.type)
                {
                    case ("book"):
                        Book book = bookList.FirstOrDefault(b => b.id == item.id);
                        if (book != null)
                        {
                            book.quantity = item.quantity;
                        }
                        break;
                    case ("game"):
                        Game game = gameList.FirstOrDefault(g => g.id == item.id);
                        if (game != null)
                        {
                            game.quantity = item.quantity;
                        }
                        break;
                    case ("movie"):
                        Movie movie = movieList.FirstOrDefault(m => m.id == item.id);
                        if (movie != null)
                        {
                            movie.quantity = item.quantity;
                        }
                        break;
                };
            }
        }
    }
}
