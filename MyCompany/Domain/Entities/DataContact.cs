using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class DataContact //: EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Вкажіть ім'я")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина імені від 3 до 50 символів")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Некоректний Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Некоректний номер телефону")]
        [Display(Name = "Номер телефону")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Повідомлення")]
        public string Message { get; set; }
    }
}
