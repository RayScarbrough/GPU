using System.ComponentModel.DataAnnotations;

namespace GPU.Models
{
    public class GPUDetails

    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Brand { get; set; }

        [StringLength(60)]
        public string Model { get; set; }

        [Range(1999, 2030)]
        public int ReleaseYear { get; set; }

        [Range(100, 20000)]
        public int MemoryInMB { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LaunchDate { get; set; }
    }
}
