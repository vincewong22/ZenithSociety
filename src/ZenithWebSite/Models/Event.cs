using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models
{
    public class Event : IValidatableObject
    {

        [Key]
        [Display(Name = "Event")]
        public int EventId { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        public DateTime EventFromDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime EventToDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EventToDate < EventFromDate)
            {
                yield return
                  new ValidationResult(errorMessage: "End Date must be greater than Start Date",
                                       memberNames: new[] { "EventToDate" });
            }
        }

        [Display(Name = "Created By")]
        public string EnteredByUsername { get; set; }

        [Display(Name = "Activity")]
        [Required]
        public int ActivityId { get; set; }


        [Display(Name = "Activity")]
        public virtual Activity Activity { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
    }
}
