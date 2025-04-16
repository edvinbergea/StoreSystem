using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal abstract class Product : INotifyPropertyChanged
    {
        
        public bool isValid { get; set; } = true;
        public string _name;
        public string name { get => _name; set { if (_name != value) { _name = value;  OnPropertyChanged(nameof(name)); } } }
        public string _price;
        public string price { get => _price; set { if (_price != value) { _price = value; OnPropertyChanged(nameof(price)); } } }
        public string _quantity;
        public string quantity { get => _quantity; set { if (_quantity != value) { _quantity = value; OnPropertyChanged(nameof(quantity)); } } }
        public string _type;
        public string type { get => _type; set { if (_type != value) { _type = value; OnPropertyChanged(nameof(type)); } } }
        public string _id;
        public string id { get => _id; set { if (_id != value) { _id = value; OnPropertyChanged(nameof(id)); } } }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
