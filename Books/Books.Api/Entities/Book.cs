using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }

        // Foriegn key to the author table 
        public Guid AuthorId { get; set; }

        // Navigation property - can access Author table from this entity
        public Author Author { get; set; }
    }
}
