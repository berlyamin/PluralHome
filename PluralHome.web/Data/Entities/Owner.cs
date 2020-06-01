using PluralHome.Data.Entities;
using PluralHome.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PluralHome.web.Data.Entities
{
    public class Owner

    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Document { get; set; }

        [Required] 
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FullName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNamewithDocument => $"{FullName} {LastName} -{Document}";

        public ICollection<Product> Products { get; set; }

        public ICollection<Contact> Contacts { get; set; }



    }
}
