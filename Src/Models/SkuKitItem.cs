namespace YourNamespace.Models
{
    public class SkuKitItem
    {
        public int SkuId { get; set; }
        public int Quantity { get; set; }

        public SkuKitItem(int skuId, int quantity)
        {
            SkuId = skuId;
            Quantity = quantity;
        }
    }
}
