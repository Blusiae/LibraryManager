using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain
{
    public class ReaderEntity : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        [NotMapped]
        public virtual IEnumerable<BorrowEntity> Borrows { get; set; } //Every borrow has a reader (borrower).
    }
}
