﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlWebApp.Models;
using SqlWebApp.Services;

namespace SqlWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product>? Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();

        }
    }
}