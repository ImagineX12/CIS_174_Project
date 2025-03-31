using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS_174_Project.Models.ToDoList
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [MaxLength(50, ErrorMessage = "Name can't be over 50 characters long.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description.")]
        [MaxLength(500, ErrorMessage = "Description can't be over 500 characters long.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a sprint number.")]
        [Range(1, int.MaxValue, ErrorMessage = "Sprint number must be a positive number.")]
        public int SprintNumber { get; set; }

        [Required(ErrorMessage = "Please enter a point value.")]
        [Range(1, int.MaxValue, ErrorMessage = "Point value must be a positive number.")]
        public int PointValue { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;

    }
}
