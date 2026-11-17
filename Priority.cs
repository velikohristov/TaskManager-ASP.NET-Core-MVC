using System.ComponentModel.DataAnnotations;

namespace Поправителен_изпит.Models

{
    public class Priority
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
    }
}