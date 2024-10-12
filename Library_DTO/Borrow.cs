using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DTO
{
    public class Borrow
    {
        [Required]
        public int BorrowId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int BorrowBookId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
    }
}
