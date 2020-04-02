using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boodschappen_lijst
{

    public partial class AddBoodschap : Form
    {
        public Form1 f1 = new Form1();
        bool changeItem = false;
        int selectedItemIndex;
        public AddBoodschap()
        {
            InitializeComponent();
        }

        private void loadItems()
        {
            LSBItems.Items.Clear();
            for (int i = 0; i < f1.items.Count(); i++)
            {
                f1.items.ToString();
                LSBItems.Items.Add(f1.items[i].ToString());
            }
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            f1.Enabled = true;
            f1.LoadComboBox();
            this.Close();
        }

        private void BTAddProduct_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TBProduct.Text) == false || string.IsNullOrWhiteSpace(TBUnit.Text) == false)
            {
                if(changeItem) // delete item before adding changed version
                {
                    f1.items.RemoveAt(selectedItemIndex);
                    changeItem = false;
                    LSBItems.Enabled = true;
                }
                f1.items.Add(TBProduct.Text + "(" + TBUnit.Text + ")");
            }
            else
            {
                MessageBox.Show("Nie alle velden zijn ingevuld");
            }
            loadItems();
            TBProduct.Text = "";
            TBUnit.Text = "";
        }

        private void AddBoodschap_Load(object sender, EventArgs e)
        {
            loadItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete
            if (LSBItems.SelectedIndex >= 0)
            {
                int selectedItemIndex = LSBItems.SelectedIndex;
                f1.items.RemoveAt(selectedItemIndex);
                loadItems();
            }
            else
            {
                MessageBox.Show("Selecteer een product uit de lijst om te verwijderen");
            }
        }

        private void AddBoodschap_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Enabled = true;
        }

        private void BTWijzig_Click(object sender, EventArgs e)
        {
            if (LSBItems.SelectedIndex >= 0)
            {
                selectedItemIndex = LSBItems.SelectedIndex;
                string selecteditem = f1.items[selectedItemIndex];
                char[] spearator = { '(' ,')' };
                String[] strlist = selecteditem.Split(spearator);
                string productname = strlist[0];
                string unit = strlist[1];
                TBProduct.Text = productname;
                TBUnit.Text = unit;
                changeItem = true;
                LSBItems.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecteer een product uit de lijst om te wijzigen");
            }
        }
    }
}
