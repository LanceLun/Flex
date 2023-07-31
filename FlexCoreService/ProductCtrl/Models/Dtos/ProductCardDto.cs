namespace FlexCoreService.ProductCtrl.Models.Dtos
{
    public class ProductCardDto
    {
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? UnitPrice { get; set; }
        public int SalesPrice { get; set; }
        public string? FirstImgPath { get; set; }
    }
}
