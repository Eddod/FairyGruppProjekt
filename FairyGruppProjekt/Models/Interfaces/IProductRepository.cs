﻿namespace FairyGruppProjekt.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductOnSale { get; }

        Product GetProductById(int productId);


        void DeleteProduct(int id);
        void EditProduct(Product product);
        void CreateNewProduct (Product product);

        public Task SaveAsync();

    }
}
