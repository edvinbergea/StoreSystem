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
    public partial class CartItem : UserControl
    {
        public UnifiedProd product {get; set; }
        Action TextboxChangedCallback;
        public CartItem(UnifiedProd product)
        {
            InitializeComponent();
            this.product = product;
            this.NameLabel.Text = product.name;
            this.IdLabel.Text = product.id;
            this.CountLabel.Text = "1";
            this.InStock.Text = "/" + product.stock;

            CountLabel.KeyPress += CountLabel_KeyPress;
            CountLabel.KeyUp += CountLabel_KeyUp;
            CountLabel.Leave += CountLabel_Leave;
        }

        private void CountLabel_Leave(object sender, EventArgs e)
        {
            CorrectLabelContent();
        }
        private void CorrectLabelContent()
        {
            if (CountLabel.Text == "0" || String.IsNullOrWhiteSpace(CountLabel.Text))
            {
                CountLabel.Text = "1";
            }
            else if (Int32.Parse(CountLabel.Text) > Int32.Parse(product.stock))
            {
                CountLabel.Text = product.stock;
            }
            TextboxChangedCallback?.Invoke();
        }
        private void CountLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                CorrectLabelContent();
            }
        }

        public void SetDeleteButtonClickFunc(Action buttonCallback)
        {
            DeleteButton.Click += (s, e) => buttonCallback.Invoke();
        }

        public void SetTextboxChangedAction(Action callback)
        {
            TextboxChangedCallback = callback;
        }

        private void CountLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SetNameLabel(string name)
        {
            NameLabel.Text = name;
        }
        public void SetIdLabel(string id)
        {
            IdLabel.Text = id;
        }
        public string GetIdLabel()
        {
            return IdLabel.Text;
        }
        public string GetNameLabel()
        {
            return NameLabel.Text;
        }
        public void setCountLabel(string count)
        {
            CountLabel.Text = count;
        }
        public string GetCountLabel()
        {
            return CountLabel.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
