using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProduct> Products;

        public Artist()
        {
            Products = new List<IProduct>();
        }
        
        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }
    }
}
