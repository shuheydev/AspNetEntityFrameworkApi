using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetEntityFrameworkApi.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

        [Required]
        public int AuthorID { get; set; }

        public Author Author { get; set; }
    }
}
