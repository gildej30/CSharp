using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class RSVP //ASSOCIATED DATABASE 
    {
        [Key]
        public int RsvpId {get; set;}
        public int UserId {get; set;}
        public int WeddingId {get; set;}
        public User Guest {get; set;}
        public Wedding Wedding {get; set;}
    }
}