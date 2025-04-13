using Domain.Entities;

namespace crud.Models.Entities
{
    public class ApplicationStudent: BaseEntity
    {
        public int ApplicationStudentId { get; set; }
        public int StudentId { get; set; }
        public int Name { get; set; }
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public bool IsActive { get; set; }

        public virtual Student Student { get; set; }

    }
}
