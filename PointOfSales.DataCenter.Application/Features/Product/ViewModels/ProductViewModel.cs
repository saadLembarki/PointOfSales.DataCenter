﻿using AutoMapper;
using PointOfSales.DataCenter.Application.Mappings;
using PointOfSales.Domain.Entities.Products;

namespace PointOfSales.DataCenter.Application.Features.ProductFeatures.ViewModels
{
    public class ProductViewModel : IMapFrom<Domain.Entities.Products.Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; } = true;
        public string Description { get; set; }

        public int ProductGroupId { get; set; }
        public decimal Rate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Products.Product, ProductViewModel>();
            profile.CreateMap<ProductViewModel, Domain.Entities.Products.Product>();
        }
    }
}
