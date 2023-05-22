using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.User;

namespace WebApplication2.Models.Driver
{
    public class DriverModel : IComparable<DriverModel>
    {
        [Required]
        public Guid UserID { get; set; }
        public string? CarDescription { get; set; }
        public Double? OverallRating { get; set; }
        public Double? ConfortRating { get; set; }
        public Double? PersonalityRating { get; set; }
        public String? CarBrand { get; set; }
        public String? CarModel { get; set; }
        public String? CarNumber { get; set; }

        public int CompareTo(DriverModel? other)
        {
            if ((float)this.OverallRating < (float)other.OverallRating) return -1;
            if ((float)this.OverallRating == (float)other.OverallRating) return 0;
            return 1;
        }
    }
}
