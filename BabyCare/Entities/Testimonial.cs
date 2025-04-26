namespace BabyCare.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
    }
}
