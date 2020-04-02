﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Boodschappen_lijst
{
    public partial class Form1 : Form
    {
        public List<Boodschap> boodschappenLijst = new List<Boodschap>();
        public List<string> items = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadItems();
            LoadComboBox();
            decrypt();
        }

        public void LoadComboBox()
        {
            CBBoodschap.Items.Clear();
            for(int i =0; i < items.Count(); i++)
            {
                CBBoodschap.Items.Add(items[i].ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accept numbers no letters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

       
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BTAddToList_Click(object sender, EventArgs e)
        {
            //check empty fields
            if(CBBoodschap.SelectedIndex >= 0 && string.IsNullOrWhiteSpace(TBAmount.Text) == false)
            {
                bool alreadyExists = true;
                //check if already added
                for (int i = 0; i < boodschappenLijst.Count(); i++)
                {
                    if (CBBoodschap.SelectedItem.ToString() == Convert.ToString(boodschappenLijst[i].Item))
                    {
                        alreadyExists = false;
                        MessageBox.Show("Boodschap staat al in de lijst op regel: " + (i+1) );
                    }
                }
                if(alreadyExists)
                { 
                    //add item to list
                    Boodschap bs = new Boodschap(CBBoodschap.SelectedItem.ToString(), Convert.ToInt32(TBAmount.Text));
                    boodschappenLijst.Add(bs);
                    displayBoodschappenLijst();
                    CBBoodschap.SelectedIndex = -1;
                    TBAmount.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Niet alle velden zijn ingevuld.");
            }
        }

        private void displayBoodschappenLijst()
        {
            LW1.Items.Clear();
            for (int i = 0; i< boodschappenLijst.Count(); i++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(boodschappenLijst[i].Item));
                item.SubItems.Add(Convert.ToString(boodschappenLijst[i].Amount));
                item.Font = new Font("Microsoft Sans Serif", 13);
                LW1.Items.Add(item);
            }
        }

        private void BTAddToWhat_Click(object sender, EventArgs e)
        {
            //add boodschap aan lijst
            this.Enabled = false;
            AddBoodschap ab = new AddBoodschap();
            ab.f1 = this;
            ab.ShowDialog();
        }

        public void SaveItems()
        {
            if (items.Count() > 0)
            {
                using (XmlWriter writer = XmlWriter.Create("storage.xml"))
                {
                    writer.WriteStartElement("products");
                    for (int i = 0; i < items.Count(); i++)
                    {
                        writer.WriteElementString("Item" + i, items[i].ToString());
                    }
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }

        private void loadItems()
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load("storage.xml");
            }
            catch (Exception e)
            {
                XmlWriter writer = XmlWriter.Create("storage.xml");
                writer.WriteStartElement("products");
                writer.WriteEndElement();
                writer.Flush();
            }
            try
            {
                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    string loadedItem = node.InnerText;
                    items.Add(loadedItem);
                }
            }
            catch (Exception e)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save data
            SaveItems();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (LW1.SelectedItems.Count > 0)
            {
                boodschappenLijst.RemoveAt(LW1.SelectedIndices[0]);
                displayBoodschappenLijst();
            }
            else
            {
                MessageBox.Show("Selecteert product om te verwijderen");
            }
        }

        private void BTSendMail_Click(object sender, EventArgs e)
        {
            if(CHBRemberPass.Checked == true)
            {
                encrypt();
            }
            Mail m = new Mail();
            if (string.IsNullOrWhiteSpace(TBUsername.Text) == false && string.IsNullOrWhiteSpace(TBPassword.Text) == false && string.IsNullOrWhiteSpace(TBDestination.Text) == false)
            {
                if (m.Sendmail(TBUsername.Text, TBPassword.Text, TBDestination.Text, this, TBNotes.Text) == 1)
                {
                    TBNotes.Text = "";
                    MessageBox.Show("Mail verzonden");
                }
            }
            else
            {
                MessageBox.Show("Niet alle E-mail velden zijn ingevuld");
            }
        }

        private void encrypt()
        {
            DateTime thisDay = DateTime.Today.Date;
            string lastdate = thisDay.ToString("MM/yyyy");
            File.WriteAllText(@"lastDate.txt", lastdate);
            int keyCounter = 0;
            String datekey = thisDay.ToString("dd/MM/yyyy");
            char[] key = datekey.ToCharArray();
            char[] passwordToEncrypt = TBPassword.Text.ToCharArray();
            String encryptedpassword = "";
            for(int i = 0; i<passwordToEncrypt.Count(); i++)
            {
                char temp =Convert.ToChar(passwordToEncrypt[i] ^ key[keyCounter]);
                encryptedpassword += temp;
                if(keyCounter >= key.Count()-1)
                {
                    keyCounter = 0;
                }
                else
                {
                    keyCounter++;
                }
            }
            //write to txt
            File.WriteAllText(@"password.txt", encryptedpassword);
            File.WriteAllText(@"username.txt", TBUsername.Text);
        }

        private void decrypt()
        {
            string lastDate = "";
            string currentDate = "";
            try
            {
                lastDate = File.ReadAllText(@"lastDate.txt");
                DateTime thisDay = DateTime.Today.Date;
                currentDate = thisDay.ToString("MM/yyyy");

                if(currentDate == lastDate)
                {
                    try
                    {
                        string username = File.ReadAllText(@"username.txt");
                        string password = File.ReadAllText(@"password.txt");
                        TBUsername.Text = username;
                        TBPassword.Text = password;
                        CHBRemberPass.Checked = true;
                    }
                    catch
                    {
                
                    }
                }
                else
                {
                    try
                    {
                        string username = File.ReadAllText(@"username.txt");
                        TBUsername.Text = username;
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }
    }
}
