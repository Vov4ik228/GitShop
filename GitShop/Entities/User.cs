using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitShop.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Name { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string LastName { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Role { get; set; }

        public Product Product { get; set; }
    }
}
