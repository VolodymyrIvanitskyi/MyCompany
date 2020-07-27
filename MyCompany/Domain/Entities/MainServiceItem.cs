using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class MainServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заповність назву послуги")]
        [Display(Name = "Назва посту")]
        public override string Title { get; set; }

        [Display(Name = "Короткий опис")]
        public override string Subtitle { get; set; }

        [Display(Name = "Повний опис")]
        public override string Text { get; set; }
    }
}
