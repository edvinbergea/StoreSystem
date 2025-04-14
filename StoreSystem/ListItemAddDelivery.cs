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
    public partial class ListItemAddDelivery : UserControl
    {
        public ListItemAddDelivery()
        {
            InitializeComponent();

            CountTextBox.KeyPress += NumericTextBox_KeyPress;
            CountTextBox.Leave += LeaveTextBox;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        public void SetName(string name)
        {
            NameLabel.Text = name;
        }
        public void SetId(string id)
        {
            IdLabel.Text = id;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(!char.IsControl(e.KeyChar) && CountTextBox.Text.Length >= 6)
            {
                e.Handled = true;
            }
        }
        private void LeaveTextBox(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CountTextBox.Text))
            {
                CountTextBox.Text = "0";
            }
        }
    }
}
