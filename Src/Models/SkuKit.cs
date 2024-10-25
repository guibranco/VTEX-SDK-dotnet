namespace YourNamespace.Models
{
    public class SkuKit
    {
        public int Id { get; set; }
        public List<SkuKitItem> SkuComponents { get; set; }
        public int Quantity { get; set; }

        public SkuKit()
        {
            SkuComponents = new List<SkuKitItem>();
        }
    }

}
