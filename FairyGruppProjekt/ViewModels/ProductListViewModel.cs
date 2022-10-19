﻿using FairyGruppProjekt.Models;

namespace FairyGruppProjekt.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public string CurrentCategory { get; set; }

    }
}
