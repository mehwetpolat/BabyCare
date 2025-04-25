using System.ComponentModel.DataAnnotations.Schema;

namespace BabyCare.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string? NameSurname { get; set; }
        public string? Age { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }
        List<Class> Classes{ get; set; }
    }
}
//https://i.pinimg.com/236x/0d/cf/e6/0dcfe6af2ae068d690cfda2cd1398a5e.jpg
//https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROLa9zXRI98qLfTjgIAVU0ei21An8gc2zPrw&s