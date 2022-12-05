using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsWithDB
{
    internal class Product
    {
        public Product(int productId, string productName, decimal unitPrice, int unitsInStock)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        private int _productId;
        public int ProductId
        {
            get { return _productId; }
            private set { _productId = value; }
        }

        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private decimal _unitPrice;
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        private int _unitsInStock;

        public int UnitsInStock
        {
            get { return _unitsInStock; }
            set { _unitsInStock = value; }
        }

    }
}
