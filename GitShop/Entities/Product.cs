using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitShop.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Name { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Category { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Price { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
