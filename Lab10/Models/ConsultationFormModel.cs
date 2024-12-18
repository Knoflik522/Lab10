using System;
using System.ComponentModel.DataAnnotations;

namespace Lab10.Models
{
    public class ConsultationFormModel
    {
        [Required(ErrorMessage = "Ім'я та прізвище є обов'язковими.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email є обов'язковим.")]
        [EmailAddress(ErrorMessage = "Некоректний формат Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Дата консультації є обов'язковою.")]
        [DataType(DataType.Date, ErrorMessage = "Некоректний формат дати.")]
        public DateTime? ConsultationDate { get; set; }

        [Required(ErrorMessage = "Оберіть продукт для консультації.")]
        public string Product { get; set; }
    }
}
