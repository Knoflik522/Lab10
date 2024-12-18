using System.ComponentModel.DataAnnotations;

namespace Lab10.Models
{
    public class ConsultationFormValidator
    {
        public static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static string ValidateForm(ConsultationFormModel model)
        {
            if (model.ConsultationDate.HasValue)
            {
                var date = model.ConsultationDate.Value;

                if (date <= DateTime.Now)
                    return "Дата консультації повинна бути в майбутньому.";

                if (IsWeekend(date))
                    return "Консультація не може проходити у вихідний день.";

                if (model.Product == "Основи" && date.DayOfWeek == DayOfWeek.Monday)
                    return "Консультація щодо продукту 'Основи' не може проходити по понеділках.";
            }

            return null; // Якщо помилок немає
        }
    }
}
