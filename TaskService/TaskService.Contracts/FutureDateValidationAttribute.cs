
using System.ComponentModel.DataAnnotations;

namespace TaskService.Contracts
{
    internal class FutureDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext context)
        {
            if (value is DateTime date && date < DateTime.UtcNow)
                return new ValidationResult("Дата не может быть в прошлом");
            return ValidationResult.Success;
        }
    }


    public interface ITaskValidator
    {
        bool Validate(CreateTaskRequest request, out List<string> errors);
    }
}