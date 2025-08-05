using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskService.Contracts
{
    internal class UpdateTaskRequest
    {

        [Required, MinLength(3), MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        [FutureDateValidation]
        public DateTime? DueDate { get; set; }
    }
}
