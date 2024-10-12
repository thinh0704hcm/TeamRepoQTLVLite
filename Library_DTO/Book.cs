using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_DTO
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string ISBN { get; set; }

        public bool isBorrowed { get; set; }

        public override string ToString()
        {
            return $"{BookId}: {Title} by {Author}";
        }

    }
}

