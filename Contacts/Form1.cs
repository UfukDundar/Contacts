using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> contactList = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            contactList.Add("Ufuk");
            contactList.Add("Ali");
            contactList.Add("Zeynep");
            contactList.Add("Ayşe");
            contactList.Add("Sema");
            contactList.Add("Fatma");
            contactList.Add("Said");
            contactList.Add("Mustafa");
            contactList.Add("Kamil");
            contactList.Add("Yiğit");
            contactList.Add("Cansu");
            contactList.Add("Elif");
            contactList.Add("Beste");
            contactList.Add("Büşra");
            contactList.Add("Ece");
            contactList.Add("Emre");
            contactList.Add("Umut");

        }

        private void txtCalls_TextChanged(object sender, EventArgs e)
        {
            if (txtCalls.Text != "")
            {
                lstFound.Items.Clear();
                foreach(string name in contactList)
                {
                    //if (name.ToLower().StartsWith(txtCalls.Text.ToLower()))
                    if(name.ToLower().Contains(txtCalls.Text.ToLower())) //text boxa ne yazarsan onu bulu önemli!!
                    {
                        lstFound.Items.Add(name);
                    }
                }
            }
        }
    }
}
