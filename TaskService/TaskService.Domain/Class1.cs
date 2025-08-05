namespace TaskService.Domain
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DueDate { get; set; }
    }


}