﻿namespace RealEstateWebUI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int CategoryId { get; set; }
        public string CoverImage { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool DealOfTheDay { get; set; }
        public int EmployeeId { get; set; }
        public bool Status { get; set; }
    }
}
