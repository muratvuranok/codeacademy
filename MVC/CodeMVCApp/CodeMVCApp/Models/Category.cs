using System.ComponentModel.DataAnnotations;

namespace CodeMVCApp.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Kategori Adı Boş Geçilemez :)")]
        [Display(Name = "Kategori Adı")]
        //[MaxLength(255)]
        //[DataType(DataType.EmailAddress)]
        public string CategoryName { get; set; } = null!;



        [Display(Name = "Açıklama")]
        public string Description { get; set; } = null!;
    }
}
