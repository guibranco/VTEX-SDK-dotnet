using Microsoft.EntityFrameworkCore;

namespace VTEX.Database
{
    public class SalesChannelSchema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        // Additional fields and relationships can be added here
    }
}
