using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18064249_HwAss07.ViewModel
{
    public class ShowItemViewModel
    {
        private string mName;
        private string mDescription;
        private double mPrice;
        private int mQuantityAvailable;

        public string Name { get => mName; set => mName = value; }
        public string Description { get => mDescription; set => mDescription = value; }
        public double Price { get => mPrice; set => mPrice = value; }
        public int QuantityAvailable { get => mQuantityAvailable; set => mQuantityAvailable = value; }

        public ShowItemViewModel(string Name, string Description, double Price,int QuantityAvailable)
        {
            mName = Name;
            mDescription = Description;
            mPrice = Price;
            mQuantityAvailable = QuantityAvailable;
        }
    }
}