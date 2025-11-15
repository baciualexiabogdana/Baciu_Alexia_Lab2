using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baciu_Alexia_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")] 
        [Range(3, 150)]
        [Required]
        public string Title { get; set; }
        
        
        [Column(TypeName = "decimal(6,2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        
        [DataType(DataType.Date)] 
        public DateTime PublishingDate { get; set; }

        // si relatia lui book cu publisher
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }

        //relatia lui book cu author
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
    }
}