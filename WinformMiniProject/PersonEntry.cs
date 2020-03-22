using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;
namespace WinformMiniProject
{
    public partial class PersonEntry : Form, ISaveAdress
    {
        BindingList<AdressModel> adresses = new BindingList<AdressModel>();
        public PersonEntry()
        {
            InitializeComponent();

            listBoxAdressesList.DataSource = adresses;
            listBoxAdressesList.DisplayMember = nameof(AdressModel.AdressDisplayValue);
        }

        private void btAddAdress_Click(object sender, EventArgs e)
        {
            
            // Open the adress entry form
            AdressEntry entry = new AdressEntry(this);

            entry.Show();
        }


        public void SaveAdress(AdressModel adressModel)
        {
            adresses.Add(adressModel);
        }
    }
}
