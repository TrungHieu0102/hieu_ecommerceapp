﻿using HieuEcommerce.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace HieuEcommerce.Public.Products
{
    public class ProductDto : IEntityDto<Guid>
    {

        public Guid ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Slug { get; set; }
        public ProductType ProductType { get; set; }
        public string SKU { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public string SeoMetaDescription { get; set; }
        public string Description { get; set; }
        public string ThumbnailPicture { get; set; }
        public Guid Id { get; set; }
        public double sellPrice { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
    }
}