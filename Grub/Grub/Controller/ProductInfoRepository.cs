using Grub.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Grub.Controller
{
    public class ProductInfoRepository
    {
        private ObservableCollection<ProductInfo> productInfo;
        public ProductInfoRepository()
        {
            GenerateBookInfo();
        }

        public ObservableCollection<ProductInfo> ProductInfo
        {
            get { return productInfo; }
            set { this.productInfo = value; }
        }

        internal void GenerateBookInfo()
        {
            productInfo = new ObservableCollection<ProductInfo>();
            productInfo.Add(new ProductInfo() { ProductName = "Thai  Banana", ProductRank = "4.9",ProductPrice="100$",ProductUnit="500g" });
            productInfo.Add(new ProductInfo() { ProductName = "Gala Apple", ProductRank = "5.0", ProductPrice = "100$", ProductUnit = "500g" });
            productInfo.Add(new ProductInfo() { ProductName = "Chocolate Cake", ProductRank = "4.8", ProductPrice = "100$", ProductUnit = "500g" });
            productInfo.Add(new ProductInfo() { ProductName = "Strawberries", ProductRank = "4.5", ProductPrice = "100$", ProductUnit = "500g" });
            productInfo.Add(new ProductInfo() { ProductName = "Cappuccino", ProductRank = "3.5", ProductPrice = "100$", ProductUnit = "500g" });
        }
    }
}