namespace BabyCare.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        List<Team> Teams { get; set; }
    }
}
