using System.ComponentModel.DataAnnotations;

namespace Поправителен_изпит.Models

{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? DueDate { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public int PriorityId { get; set; }
        public Priority? Priority { get; set; }
    }
}