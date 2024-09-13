namespace FirstProject.Models
{
    public class Category
    {
        
            /*-------CategoryId, Name, Description.-----------------------depart---------------------------*/
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public string? Description { get; set; }
            /*---------------------------------------------------------*/
            public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
            /*---------------------------------------------------------*/
    }
}
