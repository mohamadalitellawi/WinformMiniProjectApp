﻿using System;
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
    public partial class AdressEntry : Form
    {
        ISaveAdress _parent;
        public AdressEntry( ISaveAdress parent )
        {
            InitializeComponent();

            _parent = parent;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            AdressModel adressModel = new AdressModel
            {
                StreetAdress = tbStreetAdress.Text,
                City = tbCity.Text,
                State = tbState.Text,
                ZipCode = tbZipCode.Text
            };
            _parent.SaveAdress(adressModel);

            this.Close();
        }
    }
}
