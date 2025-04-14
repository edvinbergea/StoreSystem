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
    public partial class AddDeliveryForm : Form
    {
        private List<UnifiedProd> prodList;
        public AddDeliveryForm(List<UnifiedProd> prodList)
        {
            this.prodList = prodList;
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList() {
            prodList.Sort((x, y) => (Int32.Parse(x.id)).CompareTo(Int32.Parse(y.id)));
            prodList.Reverse();
            foreach (var item in prodList)
            {
                var listItem = new ListItemAddDelivery();
                listItem.SetName(item.name);
                listItem.SetId(item.id);
                panel1.Controls.Add(listItem);
                listItem.Dock = DockStyle.Top;
            }
        }

        private void AddDeliveryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
