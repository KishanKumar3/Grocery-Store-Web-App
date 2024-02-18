﻿namespace GroceryStoreBackEnd.ViewModels
{
    public class ProductViewModelWithImage
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductCategories { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

        public decimal ProductDiscount { get; set; } = 0;

        public string ImagePath { get; set; }

        public bool IsDeleted { get; set; }

    }
}
