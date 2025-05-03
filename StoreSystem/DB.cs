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
using System.Windows.Forms.VisualStyles;

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
                if (item.isValid) unifiedList.Add(new UnifiedProd(item.id, item.name, item.price, item.author, item.genre, item.format, item.language, " ", " ", item.stock, item.type));
            }
            foreach (var item in gameList)
            {
                if (item.isValid) unifiedList.Add(new UnifiedProd(item.id, item.name, item.price, " ", " ", " ", " ", item.platform, " ", item.stock, item.type));
            }
            foreach (var item in movieList)
            {
                if (item.isValid) unifiedList.Add(new UnifiedProd(item.id, item.name, item.price, " ", " ", item.format, " ", " ", item.playtime, item.stock, item.type));
            }
            foreach (var prod in unifiedList) { Console.WriteLine("Unified: " + prod.name.ToString()); }
        }

        public BindingList<UnifiedProd> GetUnifiedList() { return unifiedList; }

        public void SaveData()
        {
            var csvHandler = new CsvHandler();
            csvHandler.SaveProds(unifiedList.ToList());
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

        public bool UnReserveId(string id) {
            return occupiedIds.Remove(Int32.Parse(id));
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
            if (string.IsNullOrWhiteSpace(Convert.ToString(dgvcc["stock"].Value))) return false;
            return true;
        }

        private void FillList() {
            var csvHandler = new CsvHandler();
            var products = csvHandler.LoadProds();
            foreach (var product in products) {
                switch (product.type)
                {
                    case ("book"):
                        bookList.Add(new Book(product.id, product.name, product.price, product.author, product.genre, product.format, product.language, product.stock, product.type));
                        break;
                    case ("game"):
                        gameList.Add(new Game(product.id, product.name, product.price, product.platform, product.stock, product.type));
                        break;
                    case ("movie"):
                        movieList.Add(new Movie(product.id, product.name, product.price, product.format, product.playtime, product.stock, product.type));
                        break;
                }
                if (Int32.Parse(product.id) == uniqueId) uniqueId++;
                occupiedIds.Add(Int32.Parse(product.id));
            }
        }

        public void MergeLists(List<UnifiedProd> list)
        {
            foreach (var product in list) {
                switch (product.type)
                {
                    case ("book"):
                        UpdateList(product, bookList, () => { CreateBook(product); });
                        break;
                    case ("game"):
                        UpdateList(product, gameList, () => { CreateGame(product); });
                        break;
                    case ("movie"):
                        UpdateList(product, movieList, () => { CreateMovie(product); });
                        break;
                }
            }
            UpdateUnifiedList();
        }

        private void UpdateList<T>(UnifiedProd prod, BindingList<T> list, Action f ) where T : Product
        {
            int index = list.IndexOf(list.FirstOrDefault(b => b.id == prod.id));
            if (index != -1)
            {
                list[index].stock = prod.stock;
                list[index].price = prod.price;
            }
            else
            {
                f.Invoke();
            }
        }
        private void CreateBook(UnifiedProd prod) { 
            AppendBook(new Book(prod.id, prod.name, prod.price, prod.author, prod.genre, prod.format, prod.language, prod.stock, prod.type));
        }
        private void CreateGame(UnifiedProd prod)
        {
            AppendGame(new Game(prod.id, prod.name, prod.price, prod.platform, prod.stock, prod.type));
        }
        private void CreateMovie(UnifiedProd prod)
        {
            ApendMovie(new Movie(prod.id, prod.name, prod.price, prod.format, prod.playtime, prod.stock, prod.type));
        }

        public void ReSync() {
            var xmlHandler = new XmlHandler();
            var items = xmlHandler.GetXML();
            MergeLists(items);
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
                            book.stock = (Int32.Parse(book.stock) + Int32.Parse(item.GetCount())).ToString();
                        }
                        break;
                    case ("game"):
                        Game game = gameList.FirstOrDefault(g => g.id == item.GetId());
                        if (game != null)
                        {
                            game.stock = (Int32.Parse(game.stock) + Int32.Parse(item.GetCount())).ToString();
                        }
                        break;
                    case ("movie"):
                        Movie movie = movieList.FirstOrDefault(m => m.id == item.GetId());
                        if (movie != null)
                        {
                            movie.stock = (Int32.Parse(movie.stock) + Int32.Parse(item.GetCount())).ToString();
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
                            book.stock = item.stock;
                        }
                        break;
                    case ("game"):
                        Game game = gameList.FirstOrDefault(g => g.id == item.id);
                        if (game != null)
                        {
                            game.stock = item.stock;
                        }
                        break;
                    case ("movie"):
                        Movie movie = movieList.FirstOrDefault(m => m.id == item.id);
                        if (movie != null)
                        {
                            movie.stock = item.stock;
                        }
                        break;
                };
            }
        }
    }
}
