﻿using System;
using Microsoft.AspNetCore.Http;

namespace EshopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageUpdateRequest
    {

        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
