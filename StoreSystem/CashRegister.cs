using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.CodeDom;

namespace StoreSystem
{
    internal class CashRegister
    {
        public BindingList<UnifiedProd> productList = new BindingList<UnifiedProd>();
        public List<CartItem> cart = new List<CartItem>();
        Action<CartItem> Delete;
        Action CountChanged;
        private DB database;
        public string total { get; set; } = "0";
        public CashRegister(BindingList<UnifiedProd> list, DB db) {
            productList = list;
            database = db;
        }
        public bool AddToCart(string id)
        {
            var product = productList.FirstOrDefault(x => x.id == id);
            Console.WriteLine(product);
            
            if (product != null && product.stock != "0" && cart.FirstOrDefault(x => x.GetIdLabel() == id) == null)
            {
                productList.Remove(product);
                var newCartEntry = new CartItem(product);
                newCartEntry.SetDeleteButtonClickFunc(() =>
                {
                    cart.Remove(newCartEntry);
                    CalculateTotal();
                    Delete(newCartEntry);
                    productList.Add(newCartEntry.product);
                    
                });
                newCartEntry.SetTextboxChangedAction(() =>
                {
                    CalculateTotal();
                    CountChanged();
                    
                });
                cart.Add(newCartEntry);
                CalculateTotal();
                return true;
            }
            return false;
        }

        public void ClearCart()
        {
            foreach (var item in cart)
            {
                productList.Add(item.product);
            }
            foreach(var item in cart)
            {
                Delete(item);
            }
            cart.Clear();
            CalculateTotal();


        }
        private void CalculateTotal()
        {
            int _total = 0;
            foreach (var item in cart)
            {
                _total += Int32.Parse(item.product.price) * Int32.Parse(item.GetCountLabel());
            }
            total = _total.ToString();
        }

        internal void SetDeleteCartItemFunction(Action<CartItem> value)
        {
            Delete = value;
        }
        internal void SetCountChanged(Action value)
        {
            CountChanged = value;
        }

        internal List<UnifiedProd> Checkout()
        {
            if(cart.Count() == 0) { throw new Exception("Cart empty"); }
            else if (FinalStockCheck()) { throw new Exception("Certain items, insufficient stock"); }
            else
            {
                foreach (var item in cart)
                {
                    item.product.stock = (Int32.Parse(item.product.stock) - Int32.Parse(item.GetCountLabel())).ToString();
                    database.UpdateModifiedProds(item.product.id);
                }
                ClearCart();
                return productList.ToList();
            }
        }

        private bool FinalStockCheck()
        {
            var list = database.GetUnifiedList().ToList<UnifiedProd>();
            foreach (var item in cart)
            {
                var ustock = list.FirstOrDefault(x => x.id == item.GetIdLabel()).stock;
                if (Int32.Parse(ustock) - Int32.Parse(item.GetCountLabel()) < 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
