namespace BabyCare.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string NameSurname { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
