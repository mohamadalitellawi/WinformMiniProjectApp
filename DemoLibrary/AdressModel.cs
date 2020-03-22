using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class AdressModel
    {
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; } //11852 || 00852

        public string AdressDisplayValue => $"{StreetAdress}, {City}, {State} {ZipCode}";
        //public string FullAdressView
        //{
        //    get
        //    {
        //        return $"{StreetAdress}, {City}, {State} {ZipCode}";
        //    }
        //}
    }
}
