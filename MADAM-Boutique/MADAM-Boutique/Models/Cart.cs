﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADAM_Boutique.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public CartLine Get(int id) => Lines.FirstOrDefault(b => b.CartLineID == id);
      
        public void AddItems(Product product, int quantity)
        {
            CartLine line = Lines.Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();
            if(line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(int index) =>
         Lines.RemoveAt(index);

        public int isExist(long id)
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Product.ProductID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public double ComputetTotalValue() =>
            Lines.Sum(e => e.Product.UnitPrice * e.Quantity);

        public void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
