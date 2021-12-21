using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Grub.Model
{
    public class ProductInfo: INotifyPropertyChanged
    {
        private string productId;
        private string productName;
        private string productPrice;
        private string productUnit;
        private string productRank;

        public string ProductPrice
        {
            get { return productPrice; }
            set
            {
                productPrice = value;
                OnPropertyChanged("ProductPrice");
            }
        }
        public string ProductUnit
        {
            get { return productUnit; }
            set
            {
                productUnit = value;
                OnPropertyChanged("ProductUnit");
            }
        }

        public string ProductId
        {
            get { return productId; }
            set
            {
                productId = value;
                OnPropertyChanged("ProductId");
            }
        }
        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }
        }
        public string ProductRank
        {
            get { return productRank; }
            set
            {
                productRank = value;
                OnPropertyChanged("ProductRank");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
