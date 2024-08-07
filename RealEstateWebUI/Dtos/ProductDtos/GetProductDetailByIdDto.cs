namespace RealEstateWebUI.Dtos.ProductDtos
{
    public class GetProductDetailByIdDto
    {
        public int ProductDetailsId { get; set; }
        public int Size { get; set; }
        public int BedRoomCount { get; set; }
        public int BathCount { get; set; }
        public int RoomCount { get; set; }
        public int GarageSize { get; set; }
        public string BuildYear { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public int ProductId { get; set; }
    }
}
