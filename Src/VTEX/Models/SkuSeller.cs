namespace VTEX.Models
{
    public class SkuSeller
    {
        public int SkuId { get; set; }
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public bool IsActive { get; set; }
    }
}