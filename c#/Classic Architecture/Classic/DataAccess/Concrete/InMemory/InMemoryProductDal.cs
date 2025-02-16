﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> products;
        public InMemoryProductDal()
        {
            products = new List<Product>()
            {
                // From Any DB service
                new Product { ProductId=1,CategoryId=1, ProductName = "Bardak", UnitPrice =15, UnitsInStock=15},
                new Product { ProductId=2,CategoryId=1, ProductName = "Kamera", UnitPrice =500, UnitsInStock=3},
                new Product { ProductId=3,CategoryId=2, ProductName = "Telefon", UnitPrice =1500, UnitsInStock=2},
                new Product { ProductId=4,CategoryId=2, ProductName = "Klavye", UnitPrice =150, UnitsInStock=65},
                new Product { ProductId=5,CategoryId=2, ProductName = "Fare", UnitPrice =85, UnitsInStock=1},

            };
        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(Product product)
        {
            
            // If you simply use .remove method it won't work because it is not called by reference, to avoid this
            // you can find the toDeleteProduct's id with a loop but it is not cost effective since there may be 
            //lots of products in your list. Instead of we use LINQ - Language Integrated Query

            Product productToDelete = products.SingleOrDefault(p=>p.ProductId == product.ProductId); 

            products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return products.Where(p =>p.CategoryId == CategoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            
            Product productToUpdate = products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;
        }
    }
}
