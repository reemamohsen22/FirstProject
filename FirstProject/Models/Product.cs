using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FirstProject.Models
{
    public class Product
    {
        //ProductId, Title, Price, Description, Quantity, ImagePath.
        public int ProductId { get; set; }

        [StringLength(12, MinimumLength = 3, ErrorMessage = "Name Must be between 3 and 12 character.")]
        [Required(ErrorMessage = "Name is Required.")]
        [DisplayName("Employee Name")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Age is Required.")]
        [Range(20, 50, ErrorMessage = "Age must be between 20 and 50.")]
        [DisplayName("Employee Age")]
        public int Price { get; set; }


        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress]
        [DisplayName("Employee Email")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Age is Required.")]
        [Range(20, 50, ErrorMessage = "Age must be between 20 and 50.")]
        [DisplayName("Employee Age")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Image Path is Required.")]
        [DisplayName("Employee Image Path")]
        public string ImagePath { get; set; }

        /*---------------------------------------------------------*/
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        //[ForeignKey("categoryId")]
        public virtual Category Category { get; set; }
        /*---------------------------------------------------------*/
    }
}
