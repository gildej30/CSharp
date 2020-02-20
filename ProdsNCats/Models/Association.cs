using System.ComponentModel.DataAnnotations;

namespace ProdsNCats.Models
{
    public class Association
    {
        [Key]
        public int AssociationId {get; set;}

        public int ProductId {get; set;}

        public int CategoryId {get; set;}

        public Product Prod {get; set;} //NAVIGATIONAL PROPERTY
        public Category Cat {get; set;} //NAVIGATIONAL PROPERTY
    }
}