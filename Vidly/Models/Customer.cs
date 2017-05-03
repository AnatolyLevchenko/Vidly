namespace Vidly.Models
{
    public class Customer
    {
        public bool IsSubscribedToNewsletter { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}