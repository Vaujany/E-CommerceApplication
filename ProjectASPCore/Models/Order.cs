using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectASPCore.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }
        public List <OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name ="First name")]
        [StringLength(50)]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(50)]
        public String  LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Address name")]
        [StringLength(200)]
        public String AdressLine1 { get; set; }

        public String AdressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        [Display(Name = "Zip code")]
        [StringLength(10,MinimumLength = 4)]
        public String ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(50)]
        public String City { get; set; }

        public String State { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        [StringLength(50)]
        public String Country { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Phone number")]
        public String PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression (@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "The email address is not entered in a correct format")]
        //(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f]
        public String Email { get; set; }

        [BindNever]
        public  decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
